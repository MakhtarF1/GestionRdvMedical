using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGroupe2.Model;

namespace AppGroupe2.View
{
    public partial class frmMedecin : Form
    {
        BdRvMedicalContext db= new BdRvMedicalContext();
        public frmMedecin()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Medecin m = new Medecin();

            // Vérification des champs obligatoires
            if (string.IsNullOrWhiteSpace(txtNomPrenom.Text) || string.IsNullOrWhiteSpace(txtAdresse.Text) ||
                string.IsNullOrWhiteSpace(txtNumeroOrdre.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelephone.Text) || string.IsNullOrWhiteSpace(txtIdentifiant.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            m.Adresse = txtAdresse.Text;
            m.NumeroOrdre = txtNumeroOrdre.Text;
            m.Email = txtEmail.Text;
            m.NomPrenom = txtNomPrenom.Text;
            m.Tel = txtTelephone.Text;
            m.Identifiant = txtIdentifiant.Text;
            m.Statut = false;

            // Vérifier si une spécialité est sélectionnée et récupérer son ID
            if (cbSpecialite.SelectedValue != null && int.TryParse(cbSpecialite.SelectedValue.ToString(), out int specialiteId))
            {
                m.IdSpecialite = specialiteId;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une spécialité.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Enregistrer dans la base de données avec gestion des erreurs
            try
            {
                db.Medecins.Add(m);
                db.SaveChanges();
                ResetForm();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                string errorMessage = "Erreur de validation :\n";
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        errorMessage += $"Propriété : {validationError.PropertyName} - Erreur : {validationError.ErrorMessage}\n";
                    }
                }
                MessageBox.Show(errorMessage, "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            txtAdresse.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtIdentifiant.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            txtNomPrenom.Text = string.Empty;
            txtNumeroOrdre.Text = string.Empty;

            // Recharger la liste des spécialités
            cbSpecialite.DataSource = LoadCbSpecialite();
            cbSpecialite.ValueMember = "Value";
            cbSpecialite.DisplayMember = "Text";
            cbSpecialite.SelectedIndex = 0; // Sélectionner la première option par défaut

            // Recharger les médecins dans le DataGridView
            dgMedecin.DataSource = db.Medecins.Select(a => new
            {
                a.IdU,
                a.NumeroOrdre,
                a.Identifiant,
                Specialite = a.Specialite.NomSpecialite, // Correction : afficher le nom de la spécialité
                a.NomPrenom,
                a.Tel,
                a.Email
            }).ToList();

            txtNomPrenom.Focus();
        }


        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
            var m = db.Medecins.Find(id);
            m.Adresse = txtAdresse.Text;
            m.NumeroOrdre = txtNumeroOrdre.Text;
            m.Email = txtEmail.Text;
            m.NomPrenom = txtNomPrenom.Text;
            m.Tel = txtTelephone.Text;
            m.Specialite.NomSpecialite = cbSpecialite.ValueMember;
            m.Identifiant = txtIdentifiant.Text;
            db.SaveChanges();
            ResetForm();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
            var m = db.Medecins.Find(id);
            if (m != null)
            {
                txtAdresse.Text = m.Adresse;
                txtEmail.Text = m.Email;
                txtIdentifiant.Text = m.Identifiant;
                txtNumeroOrdre.Text = m.NumeroOrdre;
                cbSpecialite.ValueMember = m.Specialite.NomSpecialite;
                txtTelephone.Text = m.Tel;
                txtNomPrenom.Text = m.NomPrenom;
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
            var m = db.Medecins.Find(id);
            db.Medecins.Remove(m);
            db.SaveChanges();
            ResetForm();
        }

        private void frmMedecin_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private List<SelectListViewModel> LoadCbSpecialite()
        {
            var m = db.Specialite.ToList();
            List<SelectListViewModel> liste = new List<SelectListViewModel>();
            SelectListViewModel b = new SelectListViewModel();
            b.Text = "Selectionnez...";
            b.Value = "";
            liste.Add(b);
            foreach(var c in m)
            {
                SelectListViewModel a = new SelectListViewModel();
                a.Text = c.NomSpecialite;
                a.Value = c.IdSpecialite.ToString();
                liste.Add(a);
            }
            return liste;
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            frmAgenda a=new frmAgenda();
            a.idMedecin = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
            a.Show();
        }

        private void dgMedecin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbSpecialite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
