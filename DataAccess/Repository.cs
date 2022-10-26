using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        /* HastaneContext c = new HastaneContext();      ---Bu yöntem de gayet doğru aşağıda ki ile aynı!!---
        DbSet<T> _object;                     Tek fark bu yöntemle yaptıgımızda ırepositoryde methotlar int olmalı!         
        public Repository()
        {
            _object = c.Set<T>();
        }
        */
        public void Add(T entity)
        {   using (HastaneContext context = new HastaneContext())
            {
                var addedEntity=context.Add(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
                
            }
               
        }

        public void Delete(T entity)
        {
            using (HastaneContext context = new HastaneContext())
            {
                var deletedEntity = context.Remove(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }

        }

        public List<T> GetAll()
        {
            using(HastaneContext context=new HastaneContext())
            {
                return context.Set<T>().ToList();
            }
           
        }

        public void Update(T entity)
        {
            using (HastaneContext context = new HastaneContext())
            {
                var updatedEntity = context.Update(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }

        }
    }
}
