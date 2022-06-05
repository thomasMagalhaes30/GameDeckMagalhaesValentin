using Modele;
using Modele.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDeckBusiness.Commands
{
    /// <summary>
    /// Represente la classe de commande du <see cref="Experience"/>.
    /// </summary>
    internal class ExperienceCommand : BaseCommand<Experience>
    {
        public ExperienceCommand(Context context) : base(context) { }

        /// <summary>
        /// Met à jour un <see cref="Experience"/> déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="experience">Experience à modifier</param>
        public void Update(Experience experience)
        {
            Experience updateExperience = GetEntityById(experience.Id);
            if (updateExperience == null)
                return;

            updateExperience.Joueur = experience.Joueur;
            updateExperience.TempsJeu = experience.TempsJeu;
            updateExperience.Pourcentage = experience.Pourcentage;
            updateExperience.JeuId = experience.JeuId;

            _context.SaveChanges();
        }
    }
}
