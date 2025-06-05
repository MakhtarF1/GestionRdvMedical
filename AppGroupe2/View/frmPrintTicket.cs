using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Notice.Warning.Types;
using AppGroupe2.Model;
using AppGroupe2.Report;

namespace AppGroupe2.View
{
    public partial class frmPrintTicket : Form
    {
        public frmPrintTicket()
        {
            InitializeComponent();
        }
        BdRvMedicalContext db= new BdRvMedicalContext();

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
             rptTickerRv objRpt = new rptTickerRv();
            objRpt.SetDataSource(GetTableTicket(0));
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
        }
        private void frmPrintTicket_Load(object sender, EventArgs e)
        {
          
        }
        public DataTable GetTableTicket (int? idRv =0)
        {
            DataTable table = new DataTable();
            table.Columns.Add("NomPrenom",typeof(string));
            table.Columns.Add("DateNaissance", typeof(string));
            table.Columns.Add("DateRv", typeof(DateTime));
            table.Columns.Add("Medecin", typeof(string));
            table.Columns.Add("HeureRv", typeof(string));
            table.Columns.Add("DataQr", typeof(byte));
            var lerv =db.RendezVous.Where(a=> a.IdRv== idRv).FirstOrDefault();

            if (lerv != null)
            {
                table.Rows.Add(lerv.Patient.NomPrenom, lerv.Patient.DateNaissance,
                lerv.DateRv, lerv.Medecin.NomPrenom, new byte[0]);
            }
            else
            {
                table.Rows.Add("NomPrenom", DateTime.Now, 
                    DateTime.Now, "NomPrenom", new byte[0]);
            }

            return table;
        }
    }
}
