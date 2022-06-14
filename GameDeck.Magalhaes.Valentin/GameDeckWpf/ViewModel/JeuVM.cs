using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GameDeckWpf.ViewModel
{
    public class JeuVM : BaseVM
    {
        private int _id;
        /// <summary>
        /// Obtient ou definit l'identifiant du <see cref="JeuVM"/>.
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

        private string _nom;
        /// <summary>
        /// Obtient ou definit le nom du <see cref="JeuVM"/>.
        /// </summary>
        public string Nom
        {
            get => _nom;
            set
            {
                _nom = value;
                OnPropertyChanged();
            }
        }

        private string _description;
        /// <summary>
        /// Obtient ou definit la descriptio du <see cref="JeuVM"/>.
        /// </summary>
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        private DateTime _dateSortie;
        /// <summary>
        /// Obtient ou definit la date de sortie du <see cref="JeuVM"/>.
        /// </summary>
        public DateTime DateSortie
        {
            get => _dateSortie;
            set
            {
                _dateSortie = value; OnPropertyChanged();
            }
        }

        private int _genreId;
        /// <summary>
        /// Obtient ou definit l'identifiant du <see cref=GenreVM"/> du <see cref="JeuVM"/>.
        /// </summary>
        public int GenreId
        {
            get => _genreId;
            set
            {
                _genreId = value;
                OnPropertyChanged();
            }
        }

        private int _editeurId;
        /// <summary>
        /// Obtient ou definit l'identifiant de l'<see cref="EditeurVM"/> du <see cref="JeuVM"/>.
        /// </summary>
        public int EditeurId
        {
            get => _editeurId;
            set
            {
                _editeurId = value; OnPropertyChanged();
            }
        }

        private EditeurVM _editeurObj;
        /// <summary>
        /// Obtient ou definit l'<see cref="EditeurVM"/> du <see cref="JeuVM"/>.
        /// </summary>
        public EditeurVM Editeur
        {
            get => _editeurObj; set
            {
                _editeurObj = value; OnPropertyChanged();
            }
        }

        private GenreVM _genre;
        /// <summary>
        /// Obtient ou definit le <see cref=GenreVM"/> du <see cref="JeuVM"/>.
        /// </summary>
        public GenreVM Genre
        {
            get => _genre;
            set
            {
                _genre = value; OnPropertyChanged();
            }
        }

        private ObservableCollection<EvaluationVM> _evaluations;
        /// <summary>
        /// Obtient ou definit la liste de <see cref="EvaluationVM"/> du <see cref="JeuVM"/>.
        /// </summary>
        public ObservableCollection<EvaluationVM> Evaluations
        {
            get => _evaluations ?? (_evaluations = new ObservableCollection<EvaluationVM>());
            set
            {
                _evaluations = value; OnPropertyChanged();
            }
        }

        private ObservableCollection<ExperienceVM> _experiences;
        /// <summary>
        /// Obtient ou definit la liste de <see cref="ExperienceVM"/> du <see cref="JeuVM"/>.
        /// </summary>
        public ObservableCollection<ExperienceVM> Experiences
        {
            get => _experiences;
            set
            {
                _experiences = value; OnPropertyChanged();
            }
        }
    }
}
