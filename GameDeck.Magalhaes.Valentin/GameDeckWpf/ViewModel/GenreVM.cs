using System.Collections.ObjectModel;

namespace GameDeckWpf.ViewModel
{
    /// <summary>
    /// Represente la VM de l'entite <see cref="Genre"/>.
    /// </summary>
    public class GenreVM : BaseVM
    {
        private int _id;
        /// <summary>
        /// Obtient ou definit l'identifiant du <see cref="GenreVM"/>.
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
        /// Obtient ou definit le nom du <see cref="GenreVM"/>.
        /// </summary>
        public string Nom
        {
            get => _nom;
            set
            {
                _nom = value; OnPropertyChanged();
            }
        }

        private ObservableCollection<JeuVM> _jeux;
        /// <summary>
        /// Obtient ou definit la liste de <see cref="JeuVM"/> du <see cref="GenreVM"/>.
        /// </summary>
        public ObservableCollection<JeuVM> Jeux
        {
            get => _jeux;
            set
            {
                _jeux = value; OnPropertyChanged();
            }
        }
    }
}
