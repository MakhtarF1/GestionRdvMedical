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

namespace AppGroupe2.View
{
    public partial class frmRendezVous : Form
    {
        private int _agendaId;
        BdRvMedicalContext db = new BdRvMedicalContext();
        public frmRendezVous()
        {
            InitializeComponent();
        }
        public frmRendezVous(int agendaId)
        {
            InitializeComponent();
            _agendaId = agendaId;
            MessageBox.Show($"ID Agenda reçu : {_agendaId}");

        }
        private void frmRendezVous_Load(object sender, EventArgs e)
        {
            LoadRendezVous();
        }

        public void LoadRendezVous()
        {
            dgRendezVous.DataSource = db.RendezVous
                .Where(rv => rv.IdAgenda == _agendaId) // 🔥 Filtrer par agenda
                .Select(rv => new
                {
                    rv.IdRv,
                    rv.DateRv,
                    rv.HeureRv,
                    NomMedecin = rv.Medecin.NomPrenom, // Assurez-vous que Medecin est bien lié
                    NomPatient = rv.Patient.NomPrenom, // Assurez-vous que Patient est bien lié
                    rv.Statut
                })
                .ToList();
            var rendezVousList = db.RendezVous.Where(rv => rv.IdAgenda == _agendaId).ToList();
            MessageBox.Show($"Nombre de rendez-vous trouvés : {rendezVousList.Count}");

        }





        private void dgRendezVous_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmRendezVous_Load_1(object sender, EventArgs e)
        {

        }
    }
}
