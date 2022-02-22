using CoreGeneric.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreGeneric.Models
{
    public class FilmModel
    {
        public Film Film{ get; set; }
        public FilmTur  FilmTur{ get; set; }
        public List<FilmTur> ftlist { get; set; }
        public List<Film> flist { get; set; }
    }
}
