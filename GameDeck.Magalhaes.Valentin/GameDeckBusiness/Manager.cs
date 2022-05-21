using GameDeckBusiness.Queries;
using Modele;
using Modele.Entities;
using System.Collections.Generic;

namespace GameDeckBusiness
{
    /// <summary>
    /// Represente un manager.
    /// </summary>
    /// <remarks>Attention c'est un singleton</remarks>
    public class Manager
    {
        private static Manager _instance = null;
        private Context _context;

        private Manager()
        {
            _context = new Context();
        }

        /// <summary>
        /// Obtient l'instance du <see cref="Manager"/>
        /// </summary>
        public static Manager GetInstance()
            => _instance ?? new Manager();

        #region methods

        /// <summary>
        /// Permet d'ajouter un <see cref="Jeu"/>
        /// </summary>
        public void AddJeu(Jeu jeu)
        {
            new JeuQuery(_context).Add(jeu);
        }

        /// <summary>
        /// Obtient la liste des <see cref="Jeu"/>
        /// </summary>
        /// <returns></returns>
        public List<Jeu> GetAllJeux()
        {
            return new JeuQuery(_context).GetAll();
        }

        #endregion
    }
}
