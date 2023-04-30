using CarRentalSystem.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Application.Common
{

    public interface IRepository<Entity> where Entity : class
    {
        Entity Get(Guid Id);
        Entity GetByString(string Id);

        Entity GetFirstOrDefault(Expression<Func<Entity, bool>> filter);
        List<Entity> GetAll();

        void Add(Entity entity);

        void Delete(Entity entity);

    }
}
