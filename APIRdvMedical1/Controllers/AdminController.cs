using APIRdvMedical1.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace APIRdvMedical1.Controllers
{
    /// <summary>
    /// Contrôleur API pour la gestion des administrateurs.
    /// </summary>
    public class AdminController : ApiController
    {
        private BdRvMedicalContext db = new BdRvMedicalContext();

        /// <summary>
        /// Récupère la liste de tous les administrateurs.
        /// </summary>
        public IEnumerable<Admin> Get()
        {
            // Retourne tous les admins
            return db.Personnes.OfType<Admin>().ToList();
        }

        /// <summary>
        /// Récupère un administrateur par son identifiant.
        /// </summary>
        public IHttpActionResult Get(int id)
        {
            // Recherche par ID
            var admin = db.Personnes.OfType<Admin>().FirstOrDefault(a => a.IdU == id);
            if (admin == null) return NotFound();

            return Ok(admin);
        }

        /// <summary>
        /// Crée un nouvel administrateur.
        /// </summary>
        public IHttpActionResult Post([FromBody] Admin admin)
        {
            // Validation du modèle
            if (!ModelState.IsValid) return BadRequest(ModelState);

            db.Personnes.Add(admin);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = admin.IdU }, admin);
        }

        /// <summary>
        /// Met à jour les informations d’un administrateur existant.
        /// </summary>
        public IHttpActionResult Put(int id, [FromBody] Admin admin)
        {
            // Validation
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var existing = db.Personnes.OfType<Admin>().FirstOrDefault(a => a.IdU == id);
            if (existing == null) return NotFound();

            // Mise à jour des champs
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

        /// <summary>
        /// Supprime un administrateur par son identifiant.
        /// </summary>
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
