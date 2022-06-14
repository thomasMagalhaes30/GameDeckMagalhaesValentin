using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDeckWpf.ViewModel
{
    /// <summary>
    /// Represente le VM de l'entite <see cref="Experience"/>.
    /// </summary>
    public class ExperienceVM : BaseVM
    {
        private int _id;
        /// <summary>
        /// Obtient ou definit l'identifiant de l'<see cref="ExperienceVM"/>.
        /// </summary>
        public int Id
        {
            get => _id;
            set
            {
                _id = value; 
                OnPropertyChanged();
            }
        }

        private string _joueur;
        /// <summary>
        /// Obtient ou definit le joueur de l'<see cref="ExperienceVM"/>.
        /// </summary>
        public string Joueur
        {
            get => _joueur;
            set
            {
                _joueur = value; 
                OnPropertyChanged();
            }
        }

        private TimeSpan _tempsJeu;
        /// <summary>
        /// Obtient ou definit le temps de jeu de l'<see cref="ExperienceVM"/>.
        /// </summary>
        public TimeSpan TempsJeu
        {
            get => _tempsJeu;
            set
            {
                _tempsJeu = value; 
                OnPropertyChanged();
            }
        }

        private float _pourcentage;
        /// <summary>
        /// Obtient ou definit le pourcentage de l'<see cref="ExperienceVM"/>.
        /// </summary>
        public float Pourcentage
        {
            get => _pourcentage;
            set
            {
                _pourcentage = value; 
                OnPropertyChanged();
            }
        }

        private int _jeuId;
        /// <summary>
        /// Obtient ou definit l'identifiant du <see cref="JeuVM"/> de l'<see cref="ExperienceVM"/>.
        /// </summary>
        public int JeuId
        {
            get => _jeuId;
            set
            {
                _jeuId = value; 
                OnPropertyChanged();
            }
        }

        private JeuVM _jeuObj;
        /// <summary>
        /// Obtient ou definit le <see cref="JeuVM"/> du jeu de l'<see cref="ExperienceVM"/>.
        /// </summary>
        public JeuVM JeuObj
        {
            get => _jeuObj; 
            set
            {
                _jeuObj = value; 
                OnPropertyChanged();
            }
        }
    }
}
