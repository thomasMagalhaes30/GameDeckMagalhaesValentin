using Modele;
using Modele.Entities;
using System.Data.Entity;
using System.Linq;

namespace GameDeckBusiness.Commands
{
    /// <summary>
    /// Represente la classe de base des commandes
    /// </summary>
    internal abstract class BaseCommand<T> where T : BaseEntity
    {
        protected readonly Context _context = null;

        public BaseCommand(Context context)
        {
            _context = context;
        }

        public DbSet<T> GetDbSet() => _context.Set<T>();

        #region public methods

        /// <summary>
        /// Obtient l'entite qui possède l'identifiant passé en paramètre
        /// </summary>
        /// <param name="id">Identifiant de l'entite</param>
        /// <returns>L'entite avec l'identifiant passé en paramètre</returns>
        protected T GetEntityById(int id)
        {
            return GetDbSet().Where(entite => entite.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// Ajouter l'entite <see cref="T"/> en base à partir du contexte
        /// </summary>
        /// <param name="T">Entite à ajouter</param>
        /// <returns>Identifiant de l'entite ajouté</returns>
        public int Add(T entite)
        {
            GetDbSet().Add(entite);
            _context.SaveChanges();
            return entite.Id; // oui oui c'est bien comme ça
        }

        /// <summary>
        /// Supprimer une entité en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="id">Identifiant de l'entite à supprimer</param>
        public void Delete(int id)
        {
            T delEntite = GetEntityById(id);
            if (delEntite == null)
                return;

            GetDbSet().Remove(delEntite);
            // on sauvegarde que si on retire l'entite
            _context.SaveChanges();
        }

        #endregion
    }
}
