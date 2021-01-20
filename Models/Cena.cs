using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projekt.Models
{
    [Table("Cena")]
    public class Cena
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
     
        public string Cena1 { get; set; }
        public ICollection<Gry> Gry { get; set; }
    }
}
