using APIRdvMedical1.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace APIRdvMedical1.Controllers
{
    public class MedecinController : ApiController
    {
        private BdRvMedicalContext db = new BdRvMedicalContext();

        // GET: api/Medecin
        public IEnumerable<Medecin> Get()
        {
            return db.Medecins.Include("Specialite").ToList();
        }

        // GET: api/Medecin/5
        public IHttpActionResult Get(int id)
        {
            var medecin = db.Medecins.FirstOrDefault(m => m.IdU == id);
            if (medecin == null)
                return NotFound();

            return Ok(medecin);
        }

        // POST: api/Medecin
        public IHttpActionResult Post([FromBody] Medecin medecin)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.Medecins.Add(medecin);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = medecin.IdU }, medecin);
        }

        // PUT: api/Medecin/5
        public IHttpActionResult Put(int id, [FromBody] Medecin medecin)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = db.Medecins.FirstOrDefault(m => m.IdU == id);
            if (existing == null)
                return NotFound();

            // Mise à jour des champs hérités de Personne et Utilisateur
            existing.NomPrenom = medecin.NomPrenom;
            existing.Adresse = medecin.Adresse;
            existing.Email = medecin.Email;
            existing.Tel = medecin.Tel;
            existing.Identifiant = medecin.Identifiant;
            existing.MotDePasse = medecin.MotDePasse;
            existing.Statut = medecin.Statut;
            existing.IdRole = medecin.IdRole;

            // Champs propres à Medecin
            existing.NumeroOrdre = medecin.NumeroOrdre;
            existing.IdSpecialite = medecin.IdSpecialite;

            db.SaveChanges();

            return Ok(existing);
        }


        // DELETE: api/Medecin/5
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
