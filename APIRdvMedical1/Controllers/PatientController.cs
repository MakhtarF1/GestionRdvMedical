using APIRdvMedical1.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace APIRdvMedical1.Controllers
{
    public class PatientController : ApiController
    {
        private BdRvMedicalContext db = new BdRvMedicalContext();

        // GET: api/Patient
        public IEnumerable<Patient> Get()
        {
            return db.Personnes.OfType<Patient>().ToList();
        }

        // GET: api/Patient/5
        public IHttpActionResult Get(int id)
        {
            var patient = db.Personnes.OfType<Patient>().FirstOrDefault(p => p.IdU == id);
            if (patient == null)
                return NotFound();

            return Ok(patient);
        }

        // POST: api/Patient
        public IHttpActionResult Post([FromBody] Patient patient)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.Personnes.Add(patient); // Important : ajouter au DbSet<Personnes>
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = patient.IdU }, patient);
        }

        // PUT: api/Patient/5
        public IHttpActionResult Put(int id, [FromBody] Patient patient)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = db.Personnes.OfType<Patient>().FirstOrDefault(p => p.IdU == id);
            if (existing == null)
                return NotFound();

            // Mise à jour des champs
            existing.NomPrenom = patient.NomPrenom;
            existing.Adresse = patient.Adresse;
            existing.Email = patient.Email;
            existing.Tel = patient.Tel;
            existing.GroupeSanguin = patient.GroupeSanguin;
            existing.Poids = patient.Poids;
            existing.Taille = patient.Taille;
            existing.DateNaissance = patient.DateNaissance;

            db.SaveChanges();

            return Ok(existing);
        }

        // DELETE: api/Patient/5
        public IHttpActionResult Delete(int id)
        {
            var patient = db.Personnes.OfType<Patient>().FirstOrDefault(p => p.IdU == id);
            if (patient == null)
                return NotFound();

            db.Personnes.Remove(patient);
            db.SaveChanges();

            return Ok();
        }
    }
}
