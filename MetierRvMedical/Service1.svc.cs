using MetierRvMedical.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MetierRvMedical
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        BdRvMedicalContext db = new BdRvMedicalContext();

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        /// <summary>
        /// Retourne la liste des agendas
        /// </summary>
        /// <returns></returns>

        public List<Agenda> GetListeAgenda()
        {
            return db.Agenda.ToList();
        }

        public bool AddAgenda(Agenda agenda)
        {
            try
            {
                db.Agenda.Add(agenda);
                db.SaveChanges();
                return true;
            }
            catch
            {

            }
            return false;
        }
        /// <summary>
        /// Modifie l'agenda
        /// </summary>
        /// <param name="agenda"></param>
        /// <returns></returns>
        public bool UpdateAgenda(Agenda agenda)
        {
            try
            {
                db.Entry(agenda).State=EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {

            }
            return false;
        }
        /// <summary>
        /// Recuperer un Medecin par son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Medecin GetMedecinById(int id)
        {
            return db.Medecins.Find(id);
        }
    }
}
