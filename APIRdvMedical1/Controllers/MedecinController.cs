using APIRdvMedical1.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace APIRdvMedical1.Controllers
{
    /// <summary>
    /// API pour la gestion des médecins.
    /// </summary>
    public class MedecinController : ApiController
    {
        private BdRvMedicalContext db = new BdRvMedicalContext();

        /// <summary>
        /// Récupère la liste complète des médecins.
        /// </summary>
        public IEnumerable<Medecin> Get()
        {
            // Retourne tous les médecins avec leur spécialité
            return db.Medecins.Include("Specialite").ToList();
        }

        /// <summary>
        /// Récupère un médecin par son ID.
        /// </summary>
        public IHttpActionResult Get(int id)
        {
            var medecin = db.Medecins.FirstOrDefault(m => m.IdU == id);
            if (medecin == null)
                return NotFound();

            return Ok(medecin);
        }

        /// <summary>
        /// Crée un nouveau médecin.
        /// </summary>
        public IHttpActionResult Post([FromBody] Medecin medecin)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.Medecins.Add(medecin);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = medecin.IdU }, medecin);
        }

        /// <summary>
        /// Met à jour un médecin existant.
        /// </summary>
        public IHttpActionResult Put(int id, [FromBody] Medecin medecin)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = db.Medecins.FirstOrDefault(m => m.IdU == id);
            if (existing == null)
                return NotFound();

            // Mise à jour des données de base
            existing.NomPrenom = medecin.NomPrenom;
            existing.Adresse = medecin.Adresse;
            existing.Email = medecin.Email;
            existing.Tel = medecin.Tel;
            existing.Identifiant = medecin.Identifiant;
            existing.MotDePasse = medecin.MotDePasse;
            existing.Statut = medecin.Statut;
            existing.IdRole = medecin.IdRole;

            // Mise à jour des données spécifiques au médecin
            existing.NumeroOrdre = medecin.NumeroOrdre;
            existing.IdSpecialite = medecin.IdSpecialite;

            db.SaveChanges();

            return Ok(existing);
        }

        /// <summary>
        /// Supprime un médecin existant.
        /// </summary>
        public IHttpActionResult Delete(int id)
        {
            var medecin = db.Medecins.FirstOrDefault(m => m.IdU == id);
            if (medecin == null)
                return NotFound();

            db.Medecins.Remove(medecin);
            db.SaveChanges();

            return Ok();
        }
    }
}
