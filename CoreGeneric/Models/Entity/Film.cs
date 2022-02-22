using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreGeneric.Models.Entity
{
    public class Film
    {
        public int FilmID { get; set; }
        public string Ad { get; set; }
        public string Açıklama { get; set; }
        public string Resim { get; set; }
        [ForeignKey("FilmTur")]
        public int FilmTurID { get; set; }
        public  FilmTur FilmTur { get; set; }
    }
}
