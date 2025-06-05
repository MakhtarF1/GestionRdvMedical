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
using Microsoft.VisualBasic.Devices;

namespace AppGroupe2
{
    public partial class frmMDI : Form
    {
<<<<<<< HEAD
        public string role;
=======
>>>>>>> 8f904f457910be6f53a33265328af12516297100
        public frmMDI()
        {
            InitializeComponent();
        }

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnexion f = new frmConnexion();
            f.Show();
            this.Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fermer()
        {
            Form[] charr = this.MdiChildren;
            //For each child form set the window state to Maximized
            foreach (Form chform in charr)
            {
                chform.WindowState= FormWindowState.Maximized;
                chform.Close();
            }
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            //this.Width = myComputer.Screen.Bounds.Width;
            //this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0,0);
<<<<<<< HEAD
            if(role== "Admin")
            {
                btnPatient.Visible= false;
                btnMedecin.Visible= false;
                btnUtilisateur.Visible = true;
                btnPlanification.Visible= false;
                btnRv.Visible= false;
            } else
            {
                btnPatient.Visible = true;
                btnMedecin.Visible = true;
                btnUtilisateur.Visible = false;
                btnRv.Visible = true;
                btnActions.Visible = false;
            }

=======
>>>>>>> 8f904f457910be6f53a33265328af12516297100

        }

        private void rougeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmPatient f = new frmPatient();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void bleuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fermer();
            frmMedecin f = new frmMedecin();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void Pn_left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSeDeconnecter_Click(object sender, EventArgs e)
        {
            frmConnexion f = new frmConnexion();
            f.Show();
            this.Close();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            fermer();
            frmPatient f = new frmPatient();
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void btnMedecin_Click(object sender, EventArgs e)
        {

            fermer();
            frmMedecin f = new frmMedecin();
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }
<<<<<<< HEAD

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
=======
>>>>>>> 8f904f457910be6f53a33265328af12516297100
    }
}
