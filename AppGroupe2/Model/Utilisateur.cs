using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations.Schema;
=======
>>>>>>> 8f904f457910be6f53a33265328af12516297100
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGroupe2.Model
{
    public class Utilisateur :Personne
    {
        [MaxLength(20)]
        public string Identifiant { get; set; }
        [MaxLength(250)]
        public string MotDePasse {  get; set; }

        public bool Statut { get; set; }
<<<<<<< HEAD
        public int? IdRole { get; set; }
        [ForeignKey("IdRole")]
        public virtual Role Role { get; set; }
       
        
=======
>>>>>>> 8f904f457910be6f53a33265328af12516297100

    }
}
