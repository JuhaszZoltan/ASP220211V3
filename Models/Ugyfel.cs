using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP220211V3.Models
{
    [Table("Ugyfelek")]
    public class Ugyfel
    {
        [Required, Key]
        public int Id { get; set; }

        [Required, StringLength(60), Column(TypeName = "VARCHAR")]
        public string Nev { get; set; }
        [Required, Column(TypeName = "DATE")]
        public DateTime Szul { get; set; }
        public bool Nagykoru => DateTime.Now.AddYears(-18) >= Szul;
        public bool HirleveletKap { get; set; }
        [Column(TypeName = "DATE")]
        public DateTime? ElofizetesKezdete { get; set; } = null;
        public ElofizetesTipus ElofizetesTipus { get; set; }
    }
}