using CoreGeneric.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreGeneric.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }
        DbSet<Film> Filmler { get; set; }
        DbSet<FilmTur> FilmTurleri { get; set; } 

    }
}
