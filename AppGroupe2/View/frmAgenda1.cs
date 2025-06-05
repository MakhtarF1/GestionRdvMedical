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
using AppGroupe2.Helper;

namespace AppGroupe2.View
{
    public partial class frmAgenda : Form
    {
        public int idMedecin;
        Utils utils = new Utils();
        public frmAgenda()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        //BdRvMedicalContext db=new BdRvMedicalContext();
        ServiceMetier.Service1Client service = new ServiceMetier.Service1Client();
        private void frmAgenda_Load(object sender, EventArgs e)
        {
            var m = service.GetMedecinById(idMedecin); //db.Medecins.Find(idMedecin);
=======
        BdRvMedicalContext db=new BdRvMedicalContext();
        private void frmAgenda_Load(object sender, EventArgs e)
        {
            var m=db.Medecins.Find(idMedecin);
>>>>>>> 8f904f457910be6f53a33265328af12516297100
            lblMedecin.Text = string.Format("N Ordre: {0},Nom prenom: {1}", m.NumeroOrdre, m.NomPrenom);
            lblIdMedecin.Text=m.IdU.ToString();
            lblIdMedecin.Visible=false;
            ResetForrm();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
<<<<<<< HEAD
                ServiceMetier.Agenda a = new ServiceMetier.Agenda();
=======
                Agenda a = new Agenda();
>>>>>>> 8f904f457910be6f53a33265328af12516297100
                a.Creneau = int.Parse(txtCreneau.Text);
                a.HeureFin = txtHeureFin.Text;
                a.HeureDebut = txtHeureDebut.Text;
                a.IdMedecin = idMedecin;
                a.DatePlanifie = txtDateAgenda.Value;
                a.Statut = "Brouillon";
                a.Lieu = txtLieu.Text;
                a.Titre = txtTitre.Text;
<<<<<<< HEAD
                service.AddAgenda(a);


                var dernierAgenda = service.GetListeAgenda().OrderByDescending(b => b.IdAgenda).FirstOrDefault();
=======
                db.Agenda.Add(a);
                db.SaveChanges();


                var dernierAgenda = db.Agenda.OrderByDescending(b => b.IdAgenda).FirstOrDefault();
>>>>>>> 8f904f457910be6f53a33265328af12516297100
                if (dernierAgenda != null)
                {
                    MessageBox.Show($"Dernier agenda ajouté : {dernierAgenda.IdAgenda} - {dernierAgenda.Titre}");
                }
                else
                {
                    MessageBox.Show("Aucun agenda trouvé.");
                }

            }
            catch(Exception ex)
            {
                utils.WriteDataError("frmAgenda-btnAjouter_Click", ex.ToString());
            }
            finally
            {
                ResetForrm();
            }
           

        }
        private void  ResetForrm()
        {
<<<<<<< HEAD
            dgAgenda.DataSource = service.GetListeAgenda()
=======
            dgAgenda.DataSource = db.Agenda
>>>>>>> 8f904f457910be6f53a33265328af12516297100
            .Where(a => a.IdMedecin == idMedecin) // 🔥 Enlever le filtre sur la date
            .OrderByDescending(a => a.DatePlanifie) // 🔥 Trier du plus récent au plus ancien
            .ToList();

            txtCreneau.Text=string.Empty;
            txtDateAgenda.Value = DateTime.Now;
            txtHeureDebut.Text = string.Empty;
            txtHeureFin.Text = string.Empty;
            txtLieu.Text = string.Empty;
            txtTitre.Text = string.Empty;
            txtTitre.Focus();

        }

        private void btnRendezVous_Click(object sender, EventArgs e)
        {
            if (dgAgenda.CurrentRow != null)
            {
                // Récupérer l'ID de l'agenda en convertissant la valeur de la cellule
                int idAgenda = Convert.ToInt32(dgAgenda.CurrentRow.Cells["IdAgenda"].Value);

                // Ouvrir le formulaire frmRendezVous en passant l'ID de l'agenda
                frmRendezVous f = new frmRendezVous (idAgenda);
                f.Show();
                // Optionnel : désactiver le formulaire courant si besoin
                this.Enabled = false;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un agenda avant d'afficher ses rendez-vous.",
                                  "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
