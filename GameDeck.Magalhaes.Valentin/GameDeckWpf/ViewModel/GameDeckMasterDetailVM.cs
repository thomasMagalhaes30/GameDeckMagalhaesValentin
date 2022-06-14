using GameDeckDto;
using GameDeckWpf.Enum;
using GameDeckWpf.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GameDeckBusiness.Util.ManagerUtil;


namespace GameDeckWpf.ViewModel
{
    public class GameDeckMasterDetailVM : BaseVM
    {
        private ActionEnum _actionEnum;
        public ActionEnum CurrentAction 
        {
            get => _actionEnum;
            set
            {
                _actionEnum = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<JeuVM> _gamesList;
        public ObservableCollection<JeuVM> GamesList
        {
            get => _gamesList;
            set
            {
                _gamesList = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<GenreVM> _genresList;
        public ObservableCollection<GenreVM> GenresList
        {
            get => _genresList;
            set
            {
                _genresList = value;
                OnPropertyChanged();
            }
        }
        
        public GameDeckMasterDetailVM() : this(ActionEnum.CONSULTER)
        {
            GamesList = new ObservableCollection<JeuVM>(GetManager().GetAllJeux().Select(j => j?.ToViewModel()));
            GenresList = new ObservableCollection<GenreVM>(GetManager().GetAllGenres().Select(g => g?.ToViewModel()));
        }

        public GameDeckMasterDetailVM(ActionEnum currentAction)
        {
            CurrentAction = currentAction;
        }
    }
}
