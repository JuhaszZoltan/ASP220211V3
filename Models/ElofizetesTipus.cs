using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP220211V3.Models
{
    [Table("ElofizetesTipusok")]
    public class ElofizetesTipus
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EloofizetesTipusId { get; set; }
        [Required, StringLength(10), Column(TypeName = "VARCHAR")]
        public string Nev { get; set; }
        public int Ar { get; set; }
        public int HonapokSzama { get; set; }
        public int TermekKedvezmeny { get; set; }
    }
}