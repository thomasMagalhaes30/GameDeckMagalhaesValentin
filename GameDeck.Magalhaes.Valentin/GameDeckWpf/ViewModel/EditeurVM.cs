using GameDeckDto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDeckWpf.ViewModel
{
    /// <summary>
    /// Represente le VM de l'entite <see cref="Editeur"/>.
    /// </summary>
    public class EditeurVM : BaseVM
    {
        private int _id;
        /// <summary>
        /// Obtient ou definit l'identifiant de l'<see cref="EditeurVM"/>.
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
        /// Obtient ou definit le nom de l'<see cref="EditeurVM"/>.
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


        private ObservableCollection<JeuVM> _jeux;
        /// <summary>
        /// Obtient ou definit la liste de <see cref="JeuVM"/> de l'<see cref="EditeurVM"/>.
        /// </summary>
        public ObservableCollection<JeuVM> Jeux
        {
            get => _jeux;
            set
            {
                _jeux = value;
                OnPropertyChanged();
            }
        }
    }
}
