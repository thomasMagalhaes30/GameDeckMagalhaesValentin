using GameDeckDto;
using GameDeckWpf.Enum;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private ObservableCollection<JeuDto> _gamesList;
        public ObservableCollection<JeuDto> GamesList
        {
            get => _gamesList;
            set
            {
                _gamesList = value;
                OnPropertyChanged();
            }
        }

        public GameDeckMasterDetailVM() : this(ActionEnum.CONSULTER)
        {
        }

        public GameDeckMasterDetailVM(ActionEnum currentAction)
        {
            CurrentAction = currentAction;

        }
    }
}
