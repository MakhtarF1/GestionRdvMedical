using AppGroupe2.Model;
using AppGroupe2.Helper;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using System.Security.Cryptography;
=======
>>>>>>> 8f904f457910be6f53a33265328af12516297100

namespace AppGroupe2
{
    public partial class frmConnexion : Form
    {
<<<<<<< HEAD
        BdRvMedicalContext db = new BdRvMedicalContext();
=======
>>>>>>> 8f904f457910be6f53a33265328af12516297100
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
            //Computer myComputer = new Computer();
            //this.Width = myComputer.Screen.Bounds.Width;
            //this.Height = myComputer.Screen.Bounds.Height;
            //this.Location = new Point(0, 0);
            Utils.WriteLogSystem("test", "Ceci est un test");
            GMailer.senMail("fsamba500@gmail.com", "test", "un test");
        }

        private void lblMotDePasse_Click(object sender, EventArgs e)
        {

        }

        private void lblNomUtilisateur_Click(object sender, EventArgs e)
        {

        }

        private void txtNomUtlisateur_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMotDePasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
           
=======
            
>>>>>>> 8f904f457910be6f53a33265328af12516297100
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomUtilisateur_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeConnecter_Click_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            var leUser = db.Utilisateurs.Where(a => a.Identifiant.ToLower() == txtNomUtilisateur.Text.ToLower()).FirstOrDefault();
            if ((leUser != null) && (CryptString.VerifyMd5Hash(txtMotDePasse.Text , leUser.MotDePasse)))
            {

                frmMDI f = new frmMDI();
                f.role =leUser.Role.Code;
                f.Show();
                this.Hide();
            }
            else
            {
                lblMessage.Text = "Identifiant ou Mot de passe incorrect";
            }

            
=======
            frmMDI f = new frmMDI();
            f.Show();
            this.Hide();
>>>>>>> 8f904f457910be6f53a33265328af12516297100


            //string username = txtNomUtilisateur.Text.Trim();
            //string password = txtMotDePasse.Text.Trim();
            //if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            //{
            //    MessageBox.Show("Veuillez entrer un nom d'utilisateur et un mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //using (var db = new BdRvMedicalContext())
            //{
            //    var user = db.Utilisateurs.FirstOrDefault(u => u.Identifiant == username && u.MotDePasse == password);

            //    if (user != null)
            //    {
            //        MessageBox.Show("Connexion réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        frmMDI f = new frmMDI();
            //        f.Show();
            //        this.Hide(); // Ca
            //    }
            //    else
            //    {
            //        MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
