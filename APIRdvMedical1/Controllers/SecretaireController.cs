using APIRdvMedical1.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace APIRdvMedical1.Controllers
{
    public class SecretaireController : ApiController
    {
        private BdRvMedicalContext db = new BdRvMedicalContext();

        public IEnumerable<Secretaire> Get()
        {
            return db.Personnes.OfType<Secretaire>().ToList();
        }

        public IHttpActionResult Get(int id)
        {
            var sec = db.Personnes.OfType<Secretaire>().FirstOrDefault(s => s.IdU == id);
            if (sec == null) return NotFound();

            return Ok(sec);
        }

        public IHttpActionResult Post([FromBody] Secretaire secretaire)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            db.Personnes.Add(secretaire);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = secretaire.IdU }, secretaire);
        }

        public IHttpActionResult Put(int id, [FromBody] Secretaire secretaire)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var existing = db.Personnes.OfType<Secretaire>().FirstOrDefault(s => s.IdU == id);
            if (existing == null) return NotFound();

            existing.NomPrenom = secretaire.NomPrenom;
            existing.Adresse = secretaire.Adresse;
            existing.Email = secretaire.Email;
            existing.Tel = secretaire.Tel;
            existing.Identifiant = secretaire.Identifiant;
            existing.MotDePasse = secretaire.MotDePasse;
            existing.Statut = secretaire.Statut;
            existing.IdRole = secretaire.IdRole;
            existing.TelephoneFixe = secretaire.TelephoneFixe;

            db.SaveChanges();
            return Ok(existing);
        }

        public IHttpActionResult Delete(int id)
        {
            var sec = db.Personnes.OfType<Secretaire>().FirstOrDefault(s => s.IdU == id);
            if (sec == null) return NotFound();

            db.Personnes.Remove(sec);
            db.SaveChanges();

            return Ok();
        }
    }
}
