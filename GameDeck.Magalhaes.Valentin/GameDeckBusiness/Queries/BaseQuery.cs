using Modele;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GameDeckBusiness.Queries
{
    /// <summary>
    /// Represente la classe de base des queries
    /// </summary>
    internal class BaseQuery<T> where T : class
    {
        private Context _context = null;

        public BaseQuery(Context context)
        {
            _context = context;
        }

        public DbSet<T> GetDbSet() => _context.Set<T>();

        // public List<T> GetAll() => GetDbSet().ToList();

        public List<T> GetAll()
        {
            var a = GetDbSet().ToList();
            return a;
        }

        protected void Add(T entity)
        {
            GetDbSet().Add(entity);
            _context.SaveChanges();
        }
    }
}
