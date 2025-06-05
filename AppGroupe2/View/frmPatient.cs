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
    //todo: faire la gestion des erreurs
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
        }
        BdRvMedicalContext db= new BdRvMedicalContext();
        private void ResetForm()
        {
            txtAdresse.Text= string.Empty;
            txtEmail.Text= string.Empty;
            txtGroupeSanguin.Text= string.Empty;
            txtNomPrenom.Text= string.Empty;
            txtPoids.Text= string.Empty;
            txtTaille.Text= string.Empty;
            txtTelephone.Text= string.Empty;
            dtpDateNaissance.Value = DateTime.Now;
            dgPatient.DataSource = db.Patients.ToList();
            txtNomPrenom.Focus();

        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.NomPrenom= txtNomPrenom.Text;
            p.Adresse = txtAdresse.Text;
            p.Tel= txtTelephone.Text;
            p.Poids = float.Parse(txtPoids.Text);
            p.Email= txtEmail.Text;
            p.Taille = float.Parse(txtTaille.Text);
            p.GroupeSanguin= txtGroupeSanguin.Text;
            p.DateNaissance = DateTime.Parse(dtpDateNaissance.Text);
            db.Patients.Add(p);
            db.SaveChanges();
            ResetForm();
        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtNomPrenom.Text = dgPatient.CurrentRow.Cells[5].Value.ToString();
            txtAdresse.Text = dgPatient.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dgPatient.CurrentRow.Cells[7].Value.ToString();
            txtTelephone.Text = dgPatient.CurrentRow.Cells[8].Value.ToString();
            txtGroupeSanguin.Text = dgPatient.CurrentRow.Cells[0].Value.ToString();
            txtPoids.Text = dgPatient.CurrentRow.Cells[1].Value.ToString();
            txtTaille.Text = dgPatient.CurrentRow.Cells[2].Value.ToString();
            dtpDateNaissance.Value = !string.IsNullOrEmpty(dgPatient.CurrentRow.Cells[3].Value.ToString())?DateTime.Parse(dgPatient.CurrentRow.Cells[3].Value.ToString()):DateTime.Now;

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgPatient.CurrentRow.Cells[4].Value.ToString());
            if(id.HasValue )
            {
                var p = db.Patients.Find(id);
                p.NomPrenom = txtNomPrenom.Text;
                p.Adresse = txtAdresse.Text;
                p.Tel = txtTelephone.Text;
                p.Poids = float.Parse(txtPoids.Text);
                p.Email = txtEmail.Text;
                p.Taille = float.Parse(txtTaille.Text);
                p.GroupeSanguin = txtGroupeSanguin.Text;
                p.DateNaissance=dtpDateNaissance.MaxDate;
                db.SaveChanges();
                ResetForm();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgPatient.CurrentRow.Cells[4].Value.ToString());
            if (id.HasValue)
            {
                var p = db.Patients.Find(id);
                db.Patients.Remove(p);
                db.SaveChanges();
                ResetForm();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var liste = db.Patients.ToList();
            if(!string.IsNullOrEmpty(txtREmail.Text))
            {
                liste=liste.Where(a =>a.Email.ToUpper()==txtREmail.Text.ToUpper()).ToList();
            }
            if(!string.IsNullOrEmpty(txtRTel.Text))
            {
                liste = liste.Where(a => a.Tel.ToUpper() == txtRTel.Text.ToUpper()).ToList();
            }
            dgPatient.DataSource = liste.ToList();
        }

        private void btnRv_Click(object sender, EventArgs e)
        {
            if (dgPatient.CurrentRow != null)
            {
                // Récupérer le nom du patient sélectionné
                string nomPatient = dgPatient.CurrentRow.Cells["NomPrenom"].Value.ToString();

                // Ouvrir le formulaire frmDemandeRv en passant le nom du patient
                frmDemandeRv f = new frmDemandeRv(nomPatient);
                f.Show();
                this.Enabled = false; // Désactiver frmPatient pour éviter toute interaction
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un patient avant de prendre un rendez-vous.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void txtRTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRechercher_Click_1(object sender, EventArgs e)
        {
            var liste = db.Patients.ToList();
            if (!string.IsNullOrEmpty(txtREmail.Text))
            {
                liste = liste.Where(a => a.Email.ToUpper() == txtREmail.Text.ToUpper()).ToList();
            }
            if (!string.IsNullOrEmpty(txtRTel.Text))
            {
                liste = liste.Where(a => a.Tel.ToUpper() == txtRTel.Text.ToUpper()).ToList();
            }
            dgPatient.DataSource = liste.ToList();
        }

        private void btnRv_Click_1(object sender, EventArgs e)
        {

            if (dgPatient.CurrentRow != null)
            {
                // Récupérer le nom du patient sélectionné
                string nomPatient = dgPatient.CurrentRow.Cells["NomPrenom"].Value.ToString();

                // Ouvrir le formulaire frmDemandeRv en passant le nom du patient
                frmDemandeRv f = new frmDemandeRv(nomPatient);
                f.Show();
                this.Enabled = false; // Désactiver frmPatient pour éviter toute interaction
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un patient avant de prendre un rendez-vous.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            int? id = int.Parse(dgPatient.CurrentRow.Cells[4].Value.ToString());
            if (id.HasValue)
            {
                var p = db.Patients.Find(id);
                db.Patients.Remove(p);
                db.SaveChanges();
                ResetForm();
            }
        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.NomPrenom = txtNomPrenom.Text;
            p.Adresse = txtAdresse.Text;
            p.Tel = txtTelephone.Text;
            p.Poids = float.Parse(txtPoids.Text);
            p.Email = txtEmail.Text;
            p.Taille = float.Parse(txtTaille.Text);
            p.GroupeSanguin = txtGroupeSanguin.Text;
            p.DateNaissance = DateTime.Parse(dtpDateNaissance.Text);
            db.Patients.Add(p);
            db.SaveChanges();
            ResetForm();
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            int? id = int.Parse(dgPatient.CurrentRow.Cells[4].Value.ToString());
            if (id.HasValue)
            {
                var p = db.Patients.Find(id);
                p.NomPrenom = txtNomPrenom.Text;
                p.Adresse = txtAdresse.Text;
                p.Tel = txtTelephone.Text;
                p.Poids = float.Parse(txtPoids.Text);
                p.Email = txtEmail.Text;
                p.Taille = float.Parse(txtTaille.Text);
                p.GroupeSanguin = txtGroupeSanguin.Text;
                p.DateNaissance = dtpDateNaissance.MaxDate;
                db.SaveChanges();
                ResetForm();
            }
        }

        private void btnChoisir_Click_1(object sender, EventArgs e)
        {
            txtNomPrenom.Text = dgPatient.CurrentRow.Cells[5].Value.ToString();
            txtAdresse.Text = dgPatient.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dgPatient.CurrentRow.Cells[7].Value.ToString();
            txtTelephone.Text = dgPatient.CurrentRow.Cells[8].Value.ToString();
            txtGroupeSanguin.Text = dgPatient.CurrentRow.Cells[0].Value.ToString();
            txtPoids.Text = dgPatient.CurrentRow.Cells[1].Value.ToString();
            txtTaille.Text = dgPatient.CurrentRow.Cells[2].Value.ToString();
            dtpDateNaissance.Value = !string.IsNullOrEmpty(dgPatient.CurrentRow.Cells[3].Value.ToString()) ? DateTime.Parse(dgPatient.CurrentRow.Cells[3].Value.ToString()) : DateTime.Now;

        }
    }
}
