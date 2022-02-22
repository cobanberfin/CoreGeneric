using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreGeneric.Models.Entity
{
    public class FilmTur
    {
        public int FilmTurID { get; set; }
        public string TurAd { get; set; }
        public ICollection<Film> Filmler { get; set; }

    }
}
