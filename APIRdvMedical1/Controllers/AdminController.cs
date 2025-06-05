using APIRdvMedical1.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace APIRdvMedical1.Controllers
{
    public class AdminController : ApiController
    {
        private BdRvMedicalContext db = new BdRvMedicalContext();

        public IEnumerable<Admin> Get()
        {
            return db.Personnes.OfType<Admin>().ToList();
        }

        public IHttpActionResult Get(int id)
        {
            var admin = db.Personnes.OfType<Admin>().FirstOrDefault(a => a.IdU == id);
            if (admin == null) return NotFound();

            return Ok(admin);
        }

        public IHttpActionResult Post([FromBody] Admin admin)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            db.Personnes.Add(admin);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = admin.IdU }, admin);
        }

        public IHttpActionResult Put(int id, [FromBody] Admin admin)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var existing = db.Personnes.OfType<Admin>().FirstOrDefault(a => a.IdU == id);
            if (existing == null) return NotFound();

            existing.NomPrenom = admin.NomPrenom;
            existing.Adresse = admin.Adresse;
            existing.Email = admin.Email;
            existing.Tel = admin.Tel;
            existing.Identifiant = admin.Identifiant;
            existing.MotDePasse = admin.MotDePasse;
            existing.Statut = admin.Statut;
            existing.IdRole = admin.IdRole;

            db.SaveChanges();
            return Ok(existing);
        }

        public IHttpActionResult Delete(int id)
        {
            var admin = db.Personnes.OfType<Admin>().FirstOrDefault(a => a.IdU == id);
            if (admin == null) return NotFound();

            db.Personnes.Remove(admin);
            db.SaveChanges();

            return Ok();
        }
    }
}
