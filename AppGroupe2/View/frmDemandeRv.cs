using AppGroupe2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGroupe2.View;

namespace AppGroupe2.View
{
    public partial class frmDemandeRv : Form
    {
        BdRvMedicalContext db = new BdRvMedicalContext();
        public frmDemandeRv(string nomPatient = "")
        {
            InitializeComponent();
            cbSpecialite.SelectedIndexChanged += cbSpecialite_SelectedIndexChanged;
            cbSoin.SelectedIndexChanged += cbSoin_SelectedIndexChanged;


            //MessageBox.Show("Nom reçu : " + nomPatient); // Vérification

            if (!string.IsNullOrEmpty(nomPatient))
            {
                txtNomPrenom.Text = nomPatient;
                txtNomPrenom.ReadOnly = true;
            }
            txtCout.ReadOnly = true; // Empêche la saisie manuelle

        }






        private void frmDemandeRv_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void lblSpecialite_Click(object sender, EventArgs e)
        {

        }
        private void ResetForm()
        {
            //txtNomPrenom.Text = string.Empty;
            txtCout.Text = string.Empty;
            txtRefPayement.Text = string.Empty;
            txtNumeroRecu.Text = string.Empty;

            cbSpecialite.DataSource = LoadCbSpecialite();
            cbSpecialite.ValueMember = "Value";
            cbSpecialite.DisplayMember = "Text";

            cbSoin.DataSource = LoadCbSoin();
            cbSoin.ValueMember = "Value";
            cbSoin.DisplayMember = "Text";

            cbPayement.DataSource = LoadCbPaymentMode();
            cbPayement.ValueMember = "Value";
            cbPayement.DisplayMember = "Text";

            LoadMedecinsBySpecialite(null);

            txtNomPrenom.Focus();
        }

        private void LoadMedecinsBySpecialite(int? idSpecialite)
        {
            if (idSpecialite.HasValue)
            {
                dgMedecin.DataSource = db.Medecins
                    .Where(m => m.Specialite.IdSpecialite == idSpecialite.Value)
                    .Select(m => new
                    {
                        m.IdU,
                        m.NumeroOrdre,
                        m.Identifiant,
                        m.Specialite,
                        m.NomPrenom,
                        m.Tel,
                        m.Email
                    })
                    .ToList();
            }
            else
            {
                dgMedecin.DataSource = db.Medecins
                    .Select(m => new
                    {
                        m.IdU,
                        m.NumeroOrdre,
                        m.Identifiant,
                        m.Specialite,
                        m.NomPrenom,
                        m.Tel,
                        m.Email
                    })
                    .ToList();
            }
        }



        private void cbSpecialite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSpecialite.SelectedValue != null && int.TryParse(cbSpecialite.SelectedValue.ToString(), out int idSpecialite))
            {
                
                LoadMedecinsBySpecialite(idSpecialite);
            }
            else
            {
                LoadMedecinsBySpecialite(null);
            }
        }


        private void cbSpecialite_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


        private List<SelectListViewModel> LoadCbSpecialite()
        {
            var m = db.Specialite.ToList();
            List<SelectListViewModel> liste = new List<SelectListViewModel>();
            SelectListViewModel b = new SelectListViewModel();
            b.Text = "Selectionnez...";
            b.Value = "";
            liste.Add(b);
            foreach (var c in m)
            {
                SelectListViewModel a = new SelectListViewModel();
                a.Text = c.NomSpecialite;
                a.Value = c.IdSpecialite.ToString();
                liste.Add(a);
            }
            return liste;
        }


        private List<SelectListViewModel> LoadCbSoin()
        {
            var m = db.Soin.ToList();
            List<SelectListViewModel> liste = new List<SelectListViewModel>();

            liste.Add(new SelectListViewModel { Text = "Selectionnez...", Value = "" });

            foreach (var c in m)
            {
                liste.Add(new SelectListViewModel { Text = c.nomSoin, Value = c.IdSoin.ToString() });
            }
            return liste;
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgMedecin.SelectedRows.Count > 0) // Vérifie si un médecin est sélectionné
            {
                int idMedecin = Convert.ToInt32(dgMedecin.SelectedRows[0].Cells["IdU"].Value);

                // Charger l'agenda du médecin dans dgListeAgenda
                LoadAgendaMedecin(idMedecin);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un médecin.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadAgendaMedecin(int idMedecin)
        {
            var agenda = db.Agenda
                .Where(a => a.IdMedecin == idMedecin)
                .Select(a => new
                {
                    a.IdAgenda,
                    a.DatePlanifie,
                    a.HeureDebut,
                    a.HeureFin,
                    a.Statut,
                    a.Creneau
                })
                .ToList();

            dgListeAgenda.DataSource = agenda; // Affiche les résultats dans dgListeAgenda
        }


        private void cbSoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSoin.SelectedValue != null && int.TryParse(cbSoin.SelectedValue.ToString(), out int idSoin))
            {
                // Récupérer le prix du soin sélectionné
                var soin = db.Soin.FirstOrDefault(s => s.IdSoin == idSoin);
                if (soin != null)
                {
                    txtCout.Text = soin.Cout.ToString(); // Affiche le prix dans txtCout
                }
            }
            else
            {
                txtCout.Text = ""; // Réinitialise si aucune sélection
            }
        }

        private string NormalizeTimeString(string timeStr)
        {
            if (string.IsNullOrEmpty(timeStr))
                return timeStr;

            // Si la chaîne contient "h" sans ":" (ex: "8h" ou "8h30"), on la convertit
            if (timeStr.Contains("h") && !timeStr.Contains(":"))
            {
                if (timeStr.EndsWith("h"))
                {
                    // "8h" devient "8:00"
                    timeStr = timeStr.Replace("h", ":00");
                }
                else
                {
                    // Par exemple "8h30" devient "8:30"
                    timeStr = timeStr.Replace("h", ":");
                }
            }
            return timeStr;
        }



        private void btnVoirCreneau_Click(object sender, EventArgs e)
        {
            if (dgListeAgenda.SelectedRows.Count > 0)
            {
                // Récupérer la ligne d'agenda sélectionnée
                DataGridViewRow selectedRow = dgListeAgenda.SelectedRows[0];

                // Récupérer les valeurs brutes
                string heureDebutStr = selectedRow.Cells["HeureDebut"].Value.ToString();
                string heureFinStr = selectedRow.Cells["HeureFin"].Value.ToString();
                int slotDuration = Convert.ToInt32(selectedRow.Cells["Creneau"].Value); // durée en minutes

                // Normaliser les chaînes (ex: "8h" -> "8:00", "8h30" -> "8:30")
                heureDebutStr = NormalizeTimeString(heureDebutStr);
                heureFinStr = NormalizeTimeString(heureFinStr);

                DateTime heureDebut, heureFin;
                try
                {
                    heureDebut = DateTime.Parse(heureDebutStr);
                    heureFin = DateTime.Parse(heureFinStr);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Erreur de format d'heure : " + ex.Message);
                    return;
                }

                // Générer la liste des créneaux
                List<string> timeSlots = GenerateTimeSlots(heureDebut, heureFin, slotDuration);

                // Afficher la liste dans dgCreneau
                dgCreneau.DataSource = timeSlots.Select(s => new { Creneau = s }).ToList();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un agenda.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private List<string> GenerateTimeSlots(DateTime start, DateTime end, int durationMinutes)
        {
            List<string> timeSlots = new List<string>();
            DateTime current = start;

            while (current.AddMinutes(durationMinutes) <= end)
            {
                DateTime slotEnd = current.AddMinutes(durationMinutes);
                // Format simple, par exemple "8h-8h30"
                string slot = $"{current.ToString("H'h'mm")}-{slotEnd.ToString("H'h'mm")}";
                timeSlots.Add(slot);
                current = slotEnd;
            }
            return timeSlots;
        }




        private List<SelectListViewModel> LoadCbPaymentMode()
        {
            List<SelectListViewModel> liste = new List<SelectListViewModel>();
            liste.Add(new SelectListViewModel { Text = "Wave", Value = "Wave" });
            liste.Add(new SelectListViewModel { Text = "Orange Money", Value = "Orange Money" });
            liste.Add(new SelectListViewModel { Text = "Paypal", Value = "Paypal" });
            liste.Add(new SelectListViewModel { Text = "Liquide", Value = "Liquide" });
            return liste;
        }

        private void cbPayement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (dgCreneau.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un créneau.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Récupérer le créneau sélectionné
            DataGridViewRow selectedRow = dgCreneau.SelectedRows[0];
            string slotStr = selectedRow.Cells["Creneau"].Value.ToString(); // ex: "8h-8h30"
            string startTimeStr = slotStr.Split('-')[0];                    // ex: "8h"
            string normalizedTime = NormalizeTimeString(startTimeStr);      // ex: "08:00"

            // 2. Vérifier si un agenda est sélectionné dans dgListeAgenda
            if (dgListeAgenda.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un agenda.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Récupérer l'ID de l'agenda sélectionné
            int IdAgenda = Convert.ToInt32(dgListeAgenda.SelectedRows[0].Cells["IdAgenda"].Value);

            // 4. Chercher l'agenda en base
            var agenda = db.Agenda.FirstOrDefault(a => a.IdAgenda == IdAgenda);
            if (agenda == null)
            {
                MessageBox.Show("Agenda introuvable !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5. Créer un nouveau RendezVous
            RendezVous newRv = new RendezVous
            {
                HeureRv = normalizedTime,                // Heure du rendez-vous
                DateRv = agenda.DatePlanifie ?? DateTime.Now, // Date du rendez-vous (agenda ou date actuelle)
                IdMedecin = agenda.IdMedecin             // Médecin associé
                                                         // Ajoute d'autres champs si nécessaire (patient, soin, etc.)
            };

            // 6. Enregistrer dans la base
            db.RendezVous.Add(newRv);
            db.SaveChanges();

            // Rafraîchir la liste des rendez-vous dans frmRendezVous s'il est ouvert
            var frmRv = Application.OpenForms.OfType<frmRendezVous>().FirstOrDefault();
            if (frmRv != null)
            {
                frmRv.LoadRendezVous(); // Met à jour la liste
            }


            MessageBox.Show("Rendez-vous ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





        private void dgMedecin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            if (dgCreneau.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un créneau.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Récupérer le créneau sélectionné
            DataGridViewRow selectedRow = dgCreneau.SelectedRows[0];
            string slotStr = selectedRow.Cells["Creneau"].Value.ToString(); // ex: "8h-8h30"
            string startTimeStr = slotStr.Split('-')[0];                    // ex: "8h"
            string normalizedTime = NormalizeTimeString(startTimeStr);      // ex: "08:00"

            // 2. Vérifier si un agenda est sélectionné dans dgListeAgenda
            if (dgListeAgenda.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un agenda.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Récupérer l'ID de l'agenda sélectionné
            int IdAgenda = Convert.ToInt32(dgListeAgenda.SelectedRows[0].Cells["IdAgenda"].Value);

            // 4. Chercher l'agenda en base
            var agenda = db.Agenda.FirstOrDefault(a => a.IdAgenda == IdAgenda);
            if (agenda == null)
            {
                MessageBox.Show("Agenda introuvable !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5. Créer un nouveau RendezVous
            RendezVous newRv = new RendezVous
            {
                HeureRv = normalizedTime,                // Heure du rendez-vous
                DateRv = agenda.DatePlanifie ?? DateTime.Now, // Date du rendez-vous (agenda ou date actuelle)
                IdMedecin = agenda.IdMedecin             // Médecin associé
                                                         // Ajoute d'autres champs si nécessaire (patient, soin, etc.)
            };

            // 6. Enregistrer dans la base
            db.RendezVous.Add(newRv);
            db.SaveChanges();

            // Rafraîchir la liste des rendez-vous dans frmRendezVous s'il est ouvert
            var frmRv = Application.OpenForms.OfType<frmRendezVous>().FirstOrDefault();
            if (frmRv != null)
            {
                frmRv.LoadRendezVous(); // Met à jour la liste
            }


            MessageBox.Show("Rendez-vous ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }
    }
}