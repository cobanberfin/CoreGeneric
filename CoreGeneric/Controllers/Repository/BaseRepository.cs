using CoreGeneric.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreGeneric.Controllers.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        private DataContext db;
        public BaseRepository(DataContext _db)
        {
            db = _db;
        }

        public T Bul(int id)
        {
            return Set().Find(id);

        }

        public void ekle(T entity)
        {
            Set().Add(entity);
        }

        public IQueryable<T> GenelListe()
        {
            return Set().AsQueryable();
        }

        public void Guncel()
        {
            db.SaveChanges();

        }

        public List<T> Listele()//tablon sette var ılgılı tabloyu lıstele
        {
            return Set().ToList();
        }

        public void Sil(T entity)
        {
            Set().Remove(entity);
        }

        public DbSet<T> Set()
        {
            return db.Set<T>();
        }
    }
}
