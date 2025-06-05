using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRdvMedical1.Model
{
    public class Patient:Personne
    {
        [Required, MaxLength(33)]
        public string GroupeSanguin { get; set; }
        [Required]
        public float Poids { get; set; }
        [Required]
        public float Taille { get; set; }
        public DateTime? DateNaissance { get; set; }
    }
}
