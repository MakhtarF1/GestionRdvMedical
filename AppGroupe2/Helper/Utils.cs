using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppGroupe2.Model;

namespace AppGroupe2.Helper
{
    public class Utils
    {
        BdRvMedicalContext db = new BdRvMedicalContext();
        /// <summary>
        /// Cette methode logg dans la base de donnees
        /// </summary>
        /// <param name="TitreErreur">Le titre du logg</param>
        /// <param name="erreur">Le messagge du log</param>
        public void WriteDataError(string TitreErreur, string erreur)
        {
            try
            {
                Td_Erreur log = new Td_Erreur();
                log.DateErreur = DateTime.Now;
                log.DescriptionErreur = erreur.Length > 2000 ? erreur.Substring(0, 2000) : erreur;
                log.TitreErreur = TitreErreur;
                db.td_Erreurs.Add(log);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                WriteLogSystem(ex.ToString(), "WriteDataError");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public static void WriteFileError(string message)
        {
            try
            {
                string path = System.Web.HttpContext.Current.Server.MapPath("~/Error/erreur.txt");
                System.IO.TextWriter writeFile = new StreamWriter(path, true);
                writeFile.WriteLine("" + DateTime.Now);
                writeFile.WriteLine(message);
                writeFile.WriteLine("---------------------------------------------------------------------------------------");
                writeFile.Flush();
                writeFile.Close();
                writeFile = null;
            }
            catch (IOException e)
            {
                WriteLogSystem(e.ToString(), "WriteFileError");
            }
        }


        /// <summary>
        /// Cette methode permett de logger dans le systeme
        /// </summary>
        /// <param name="erreur">Le message d'erreur</param>
        /// <param name="libelle">Le tire de l'erreur</param>


        public static void WriteLogSystem(string erreur, string libelle)
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "GestionRvMedical";
                eventLog.WriteEntry(string.Format("date: {0}, libelle: {1}, description {2}", DateTime.Now, libelle, erreur), EventLogEntryType.Information, 101, 1);
            }
        }
    }
}
