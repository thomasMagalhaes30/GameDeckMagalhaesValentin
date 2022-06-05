﻿using Modele;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GameDeckBusiness.Queries
{
    /// <summary>
    /// Represente la classe de base des requêtes
    /// </summary>
    internal class BaseQuery<T> where T : class
    {
        private Context _context = null;

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
