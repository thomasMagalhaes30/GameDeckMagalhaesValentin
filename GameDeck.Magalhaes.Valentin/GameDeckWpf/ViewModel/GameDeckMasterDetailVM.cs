using GameDeckDto;
using GameDeckWpf.Enum;
using GameDeckWpf.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
                if (CurrentGame != null)
                    CurrentGame.PropertyChanged += CurrentGame_PropertyChanged;
            }
        }

        private int? _currentGenreId;
        public int? CurrentGenreId
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

        private RelayCommand _BtnSupprimer_CMD;
        public RelayCommand BtnSupprimer_CMD => _BtnSupprimer_CMD ?? (_BtnSupprimer_CMD = new RelayCommand(c => BtnSupprimer()));

        private RelayCommand _cmb_CategorieItemChangedCMD;
        public RelayCommand Cmb_CategorieItemChangedCMD => _cmb_CategorieItemChangedCMD ?? (_cmb_CategorieItemChangedCMD = new RelayCommand(c => CmbCategorieItemChanged(c)));

        private RelayCommand _dp_DateSortieLostFocusCMD;
        public RelayCommand Dp_DateSortieLostFocusCMD => _dp_DateSortieLostFocusCMD ?? (_dp_DateSortieLostFocusCMD = new RelayCommand(c => DpDateSortieLostFocus(c)));
        #endregion

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

        /// <summary>
        /// Action associée au bouton modifier:
        /// passe en mode d'édition.
        /// </summary>
        private void BtnModifier()
        {
            if (CurrentGame != null)
                CurrentAction = ActionEnum.MODIFIER;
        }

        /// <summary>
        /// Action associée au bouton ajouter:
        /// passe en mode création de jeu.
        /// </summary>
        private void BtnAjouter()
        {
            CurrentAction = ActionEnum.AJOUTER;
            CurrentGame = new JeuVM();
        }

        /// <summary>
        /// Action associée au bouton enregistrer:
        /// Enregistre le jeu en base (édition / creation),
        /// rafraichi l'affichage et repasse en consultation.
        /// </summary>
        private void BtnEnregistrer()
        {
            try
            {
                if (CurrentAction == ActionEnum.MODIFIER)
                    GetManager().UpdateJeu(CurrentGame?.ToDto());
                if (CurrentAction == ActionEnum.AJOUTER)
                    CurrentGame.Id = GetManager().AddJeu(CurrentGame?.ToDto());
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur lors de la sauvegarde : " + e.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            int Id = CurrentGame?.Id ?? 0;

            LoadGamesList();
            CurrentAction = ActionEnum.CONSULTER;
            CurrentGame = GamesList.SingleOrDefault(g => g.Id == Id);
        }

        /// <summary>
        /// Action associée au bouton annuler: 
        /// en modification reprend le jeu dans son état précédent (avant sauvegarde),
        /// en création, reprend le premier jeu de la liste comme jeu courrant,
        /// et repasse en consultation.
        /// </summary>
        private void BtnAnnuler()
        {
            // plus intéressant que de récupérer le jeu en base (multi-user / remettre propre) car liste peut avoir bougé aussi !
            LoadGamesList();

            if (CurrentAction == ActionEnum.MODIFIER && CurrentGame != null)
                CurrentGame = GamesList?.SingleOrDefault(g => g?.Id == CurrentGame.Id);
            else
                CurrentGame = GamesList?.FirstOrDefault();

            CurrentAction = ActionEnum.CONSULTER;
        }

        /// <summary>
        /// Action associée au bouton supprimer:
        /// supprime le jeu sélectionné.
        /// </summary>
        private void BtnSupprimer()
        {
            if (CurrentGame != null) // TODO CanExecute
            {
                GetManager().DeleteJeu(CurrentGame.Id);
                LoadGamesList();
                CurrentGame = GamesList?.FirstOrDefault();
            }
        }

        /// <summary>
        /// Action associée au changement de selection de la combobox catégorie :
        /// rafraichi la liste en fonction de la catégorie sélectionnée (null => tout afficher)
        /// </summary>
        private void CmbCategorieItemChanged(object selectedCategorie)
        {
            if (!(selectedCategorie is GenreVM genre))
            {
                LoadGamesList();
                return;
            }

            GamesList = new ObservableCollection<JeuVM>(GetManager().GetAllJeux().Where(g => g.GenreId == genre?.Id).Select(j => j?.ToViewModel()));

            CurrentGame = GamesList.FirstOrDefault();
        }

        /// <summary>
        /// Action associée au changement de selection du date picker de date de sortie :
        /// gère la valeur min et max
        /// </summary>
        private void DpDateSortieLostFocus(object stringDate)
        {
            DateTime minDate = new DateTime(1970, 1, 1);    // Date minimum en base de données 
            DateTime maxDate = new DateTime(2999, 12, 30);

            if (!(stringDate is string sdate))
            //if (!(stringDate is string sdate) || string.IsNullOrEmpty(sdate))
            {
                //LoadGamesList(); // TODO ça vire ?
                return;
            }

            try
            {
                List<int> d = sdate.Split('/').Select(v => int.Parse(v)).ToList();
                DateTime date = new DateTime(d[2], d[1], d[0]);

                if (date < minDate)
                    CurrentGame.DateSortie = minDate;

                if (date > maxDate)
                    CurrentGame.DateSortie = maxDate;
            }
            catch { }
        }
        #endregion

        private void LoadGamesList()
        {
            CurrentGenreId = null;
            GamesList = new ObservableCollection<JeuVM>(GetManager().GetAllJeux(true).Select(j => j?.ToViewModel()));
        }

        private void CurrentGame_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            DateTime minDate = new DateTime(1970, 1, 1);    // Date minimum en base de données 
            DateTime maxDate = new DateTime(2999, 12, 30);

            if (e.PropertyName == nameof(JeuVM.DateSortie) && CurrentGame.DateSortie != null) // && CurrentGame.DateSortie != minDate && CurrentGame.DateSortie != maxDate
            {
                if (CurrentGame.DateSortie < minDate)
                    CurrentGame.DateSortie = minDate;

                if (CurrentGame.DateSortie > maxDate)
                    CurrentGame.DateSortie = maxDate;
            }
        }
    }
}
