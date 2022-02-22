using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreGeneric.Controllers.Repository
{
   public interface IBaseRepository<T> where T:class, new()
    {
        DbSet<T> Set();

        List<T> Listele();

        T Bul(int id);

        IQueryable<T> GenelListe();

        void ekle(T entity);
        void Sil(T entity);
        void Guncel();


    }
}
