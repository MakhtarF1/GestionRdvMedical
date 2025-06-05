using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.EntityFramework; // pour MySQL
using APIRdvMedical1.Model;       // ✅ pour les entités

namespace APIRdvMedical1.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BdRvMedicalContext : DbContext
    {
        public BdRvMedicalContext() : base("BdRvMedicalContext") { }

        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Medecin> Medecins { get; set; }
        public DbSet<Secretaire> Secretaires { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<RendezVous> RendezVous { get; set; }
        public DbSet<GroupeSanguin> GroupesSanguins { get; set; }
        public DbSet<Specialite> Specialites { get; set; }
        public DbSet<Soin> Soins { get; set; }
        public DbSet<Td_Erreur> Td_Erreurs { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
