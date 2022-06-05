using Modele;
using Modele.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GameDeckBusiness.Queries
{
    /// <summary>
    /// Represente la classe de base des requêtes
    /// </summary>
    internal abstract class BaseQuery<T> where T : BaseEntity
    {
        protected readonly Context _context = null;

        public BaseQuery(Context context)
        {
            _context = context;
        }

        public DbSet<T> GetDbSet() => _context.Set<T>();

        public List<T> GetAll() => GetDbSet().ToList();

        protected T Add(T entity)
        {
            T obj = GetDbSet().Add(entity);
            _context.SaveChanges();
            return obj;
        }
    }
}
