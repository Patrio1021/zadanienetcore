using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projekt.Models
{
    [Table("Producent")]
    public class Producent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [Required(ErrorMessage = "Wpisz to pole")]
        [StringLength(160)]
        public string Nazwa { get; set; }
        [Required(ErrorMessage = "Wpisz to pole")]
        [StringLength(160)]
        public string Kraj { get; set; }
        public ICollection<Gry> Gry { get; set; }
       
        public string NazwaKraj
        {
            get
            {
                return Nazwa + " " + Kraj;
            }
        }
    }
}
