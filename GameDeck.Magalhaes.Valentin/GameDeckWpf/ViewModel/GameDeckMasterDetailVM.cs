using GameDeckDto;
using GameDeckWpf.Enum;
using GameDeckWpf.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static GameDeckBusiness.Util.ManagerUtil;


namespace GameDeckWpf.ViewModel
{
    public class GameDeckMasterDetailVM : BaseVM
    {
        private ActionEnum _currentAction;
        public ActionEnum CurrentAction
        {
            get => _currentAction;
            set
            {
                _currentAction = value;
                IsReadOnly = _currentAction == ActionEnum.CONSULTER;
                OnPropertyChanged();
            }
        }
        
        private JeuVM _CurrentGame;
        public JeuVM CurrentGame
        {
            get => _CurrentGame;
            set
            {
                _CurrentGame = value;
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

        private ObservableCollection<EditeurVM> _editeursList;
        public ObservableCollection<EditeurVM> EditeursList
        {
            get => _editeursList;
            set
            {
                _editeursList = value;
                OnPropertyChanged();
            }
        }

        private bool _isReadOnly;
        public bool IsReadOnly
        {
            get => _isReadOnly;
            set
            {
                _isReadOnly = value;
                OnPropertyChanged();
            }
        }

        private RelayCommand _btnModifier_CMD;
        public RelayCommand BtnModifier_CMD
        {
            get => _btnModifier_CMD ?? (_btnModifier_CMD = new RelayCommand(c => BtnModifier()));
        }

        //public ICommand BtnModifier_CMD { get;  }
        private void BtnModifier()
        {
            CurrentAction = ActionEnum.MODIFIER;
        }

        public GameDeckMasterDetailVM() : this(ActionEnum.CONSULTER)
        {
        }

        public GameDeckMasterDetailVM(ActionEnum currentAction)
        {
            CurrentAction = currentAction;
            GamesList = new ObservableCollection<JeuVM>(GetManager().GetAllJeux().Select(j => j?.ToViewModel()));
            GenresList = new ObservableCollection<GenreVM>(GetManager().GetAllGenres().Select(g => g?.ToViewModel()));
            EditeursList = new ObservableCollection<EditeurVM>(GetManager().GetAllEditeurs().Select(g => g?.ToViewModel()));
            CurrentGame = GamesList?.FirstOrDefault();
        }
    }
}
