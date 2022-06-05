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

        #region public methods

        /// <summary>
        /// Obtient tous les entites <see cref="T"/>
        /// </summary>
        /// <returns>IQueryable de <see cref="T"/></returns>
        public IQueryable<T> GetAll() => GetDbSet();

        /// <summary>
        /// Obtient l'entite  <see cref="T"/> par son Id
        /// </summary>
        /// <param name="id">Identifiant de l'entite <see cref="T"/> à récupérer</param>
        /// <returns>IQueryable de <see cref="T"/></returns>
        public IQueryable<T> GetById(int id) => GetDbSet().Where(entite => entite.Id == id);

        #endregion
    }
}
