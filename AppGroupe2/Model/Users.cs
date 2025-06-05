using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGroupe2.Model
{
    public class Users
    {

        [Key]
        public int IdUser { get; set; }
        [MaxLength(20)]
        public string Identifiant { get; set; }
        [MaxLength(250)]
        public string MotDePasse { get; set; }

        public bool Statut { get; set; }

    }
}
