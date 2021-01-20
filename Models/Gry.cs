﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projekt.Models
{
    [Table("Gry")]
    public class Gry
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Wpisz to pole")]
        [StringLength(160)]
        public string Tytul { get; set; }
        [DataType(DataType.Date)]
        public DateTime RokProdukcji { get; set; }
        public int KategoriaId { get; set; }
        public int CenaId { get; set; }
        public bool Nowy { get; set; }

        public Kategoria Kategoria { get; set; }
        public Cena Cena { get; set; }
        
        public ICollection<Producent> Producent { get; set; }
        public string Tytull
        {
            get
            {
                return Tytul;
            }
        }
    }
}
