using GameDeckDto;
using GameDeckWpf.Enum;
using GameDeckWpf.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static GameDeckBusiness.Util.ManagerUtil;


namespace GameDeckWpf.ViewModel
{
    public class GameDeckMasterDetailVM : BaseVM
    {
        #region [ Properties ]

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
                //MessageBox.Show(CurrentGame?.Id.ToString());
            }
        }

        private int _currentGenreId;
        public int CurrentGenreId
        {
            get => _currentGenreId;
            set
            {
                _currentGenreId = value;
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

        private bool _isListEnabled;
        public bool IsListEnabled
        {
            get => _isListEnabled;
            set
            {
                _isListEnabled = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region [ Collections ]

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
        #endregion

        #region [ Commands ]

        private RelayCommand _btnModifier_CMD;
        public RelayCommand BtnModifier_CMD
        {
            get => _btnModifier_CMD ?? (_btnModifier_CMD = new RelayCommand(c => BtnModifier()));
        }

        private RelayCommand _btnAjouter_CMD;
        public RelayCommand BtnAjouter_CMD => _btnAjouter_CMD ?? (_btnAjouter_CMD = new RelayCommand(c => BtnAjouter()));

        private RelayCommand _btnEnregistrer_CMD;
        public RelayCommand BtnEnregistrer_CMD => _btnEnregistrer_CMD ?? (_btnEnregistrer_CMD = new RelayCommand(c => BtnEnregistrer()));

        private RelayCommand _btnAnnuler_CMD;
        public RelayCommand BtnAnnuler_CMD => _btnAnnuler_CMD ?? (_btnAnnuler_CMD = new RelayCommand(c => BtnAnnuler()));

        private RelayCommand _cmb_CathegorieItemChangedCMD;
        public RelayCommand Cmb_CathegorieItemChangedCMD => _cmb_CathegorieItemChangedCMD ?? (_cmb_CathegorieItemChangedCMD = new RelayCommand(c => CmbCathegorieItemChanged(c)));
        #endregion

        private RelayCommand _testCommand;
        public RelayCommand TestCommand
        {
            get => _testCommand ?? (_testCommand = new RelayCommand(c => testCMD()));
        }
        private void testCMD() => MessageBox.Show("ça marche !");

        #region [ Construct ]

        public GameDeckMasterDetailVM() : this(ActionEnum.CONSULTER)
        {
        }

        public GameDeckMasterDetailVM(ActionEnum currentAction)
        {
            CurrentAction = currentAction;
            LoadGamesList();
            GenresList = new ObservableCollection<GenreVM>(GetManager().GetAllGenres().Select(g => g?.ToViewModel()));
            EditeursList = new ObservableCollection<EditeurVM>(GetManager().GetAllEditeurs().Select(g => g?.ToViewModel()));
            CurrentGame = GamesList?.FirstOrDefault();
        }
        #endregion

        #region [ Commands ]

        private void BtnModifier()
        {
            if (CurrentGame != null)
                CurrentAction = ActionEnum.MODIFIER;
        }

        private void BtnAjouter()
        {
            CurrentAction = ActionEnum.AJOUTER;
            CurrentGame = new JeuVM();
        }

        private void BtnEnregistrer()
        {
            int Id = CurrentGame?.Id ?? 0;

            if (CurrentAction == ActionEnum.MODIFIER)
                GetManager().UpdateJeu(CurrentGame?.ToDto());
            if (CurrentAction == ActionEnum.AJOUTER)
                CurrentGame.Id = GetManager().AddJeu(CurrentGame?.ToDto());

            CurrentAction = ActionEnum.CONSULTER;
            LoadGamesList();
            CurrentGame = GamesList.SingleOrDefault(g => g.Id == Id);
        }

        private void BtnAnnuler()
        {
            if (CurrentAction == ActionEnum.MODIFIER)
                CurrentGame = GamesList?.SingleOrDefault(g => g?.Id == CurrentGame.Id);
            else
                CurrentGame = GamesList?.FirstOrDefault();

            CurrentAction = ActionEnum.CONSULTER;
        }

        private void CmbCathegorieItemChanged(object selectedCategorie)
        {
            GenreVM genre = selectedCategorie as GenreVM;
            if (genre == null)
            {
                LoadGamesList();
                return;
            }

            GamesList = new ObservableCollection<JeuVM>(GetManager().GetAllJeux().Where(g => g.GenreId == genre?.Id).Select(j => j?.ToViewModel()));
        }
        #endregion

        private void LoadGamesList()
        {
            GamesList = new ObservableCollection<JeuVM>(GetManager().GetAllJeux().Select(j => j?.ToViewModel()));
        }
    }
}
