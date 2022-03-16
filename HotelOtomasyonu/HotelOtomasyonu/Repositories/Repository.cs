using HotelOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelOtomasyonu.Repositories
{
    public class Repository<T> where T : class, new()
    {
        public List<T> GetAll()
        {
            return Baglanti.db.Set<T>().ToList();
        }
        public void TAdd(T p)
        {
            Baglanti.db.Set<T>().Add(p);
            Baglanti.db.SaveChanges();
        }
        public void TDelete(T p)
        {
            Baglanti.db.Set<T>().Remove(p);
            Baglanti.db.SaveChanges();
        }
        public T TGet(byte id)
        {
            return Baglanti.db.Set<T>().Find(id);
        }
        public void Update(T p)
        {
            Baglanti.db.SaveChanges();
        }
        public T Find(Expression<Func<T, bool>> where)
        {
            return Baglanti.db.Set<T>().FirstOrDefault(where);
        }

        public List<T> GetListByID(Expression<Func<T, bool>> filter)
        {
            return Baglanti.db.Set<T>().Where(filter).ToList();
        }
    }

}
