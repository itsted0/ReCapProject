using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (RecapProjectCarContext context = new RecapProjectCarContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (RecapProjectCarContext context = new RecapProjectCarContext())
            {
                var deledtedEnttiy = context.Entry(entity);
                deledtedEnttiy.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (RecapProjectCarContext context = new RecapProjectCarContext())
            {
                // return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (RecapProjectCarContext context = new RecapProjectCarContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public void Update(Color entity)
        {
            using (RecapProjectCarContext context = new RecapProjectCarContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
