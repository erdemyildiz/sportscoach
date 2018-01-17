using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class BaseRepository<T> where T:class
    {
        public SportsCoachContext db = new SportsCoachContext();
        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T Find(Predicate<int> Condition)
        {
            return db.Set<T>().Find(Condition);

        }

        public void Insert(T newRecord)
        {
            db.Set<T>().Add(newRecord);
            db.SaveChanges();
        }

        public void Delete(T trash)
        {
            db.Set<T>().Remove(trash);
            db.SaveChanges();
        }

        public void Update(T oldRecord)
        {
            db.SaveChanges();
        }
    }
}
