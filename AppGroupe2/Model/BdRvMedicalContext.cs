using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MySql.Data.EntityFramework;
using System.Runtime.InteropServices.ComTypes;

namespace AppGroupe2.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BdRvMedicalContext:DbContext
    {
        public BdRvMedicalContext() :base("bdRvMedicalContext") 
        { }

        public DbSet<Personne> Personnees { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Medecin>  Medecins { get; set; }
        public DbSet<Secretaire> Secretaires { get; set; }
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<RendezVous> RendezVous { get; set; }
        public DbSet<GroupeSanguin> GroupeSanguins { get; set; }
        public DbSet<Specialite> Specialite { get; set; }
        public DbSet<Soin> Soin { get; set; }
        public DbSet<Td_Erreur> td_Erreurs { get; set; }
<<<<<<< HEAD
        public DbSet<Admin> admins { get; set; }
        public DbSet<Role> roles { get; set; }
=======

>>>>>>> 8f904f457910be6f53a33265328af12516297100

    }
}
