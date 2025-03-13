using Academy.Application.Repositories;
using Store.Domain.Entities;
using Store.Infrastructure.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Store.Infrastructure.Repositories
{
    public class EfCoreRepository<T> : IRepository<T> where T : Entity
    {
        private readonly AppDbContext _context;

        public EfCoreRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public T Get(Func<T, bool> predicate)
        {
          return  _context.Set<T>().FirstOrDefault(predicate);
        }

        public List<T> GetAll(Expression<Func<T, bool>>? predicate = null)
        {
            return _context.Set<T>().Where(predicate).ToList();
        }

        public void Remove(int id)
        {
           var existEntity= _context.Set<T>().Find(id);
            if (existEntity == null)
                throw new Exception("Not found");   

            _context.Set<T>().Remove(existEntity);
            _context.SaveChanges();


        }

        public void Update(int id, T entity)
        {
            var existEntity = _context.Set<T>().Find(id);
            if (existEntity == null)
                throw new Exception("Not found");
            existEntity = entity;
            existEntity.Id = id;
            _context.Set<T>().Update(existEntity);
        }
    }
}
