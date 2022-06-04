using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDeckWpf.ViewModel
{
    public class GameDeckDetailVM : BaseVM
    {
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

        public GameDeckDetailVM()
        {
            IsReadOnly = true;
        }
    }
}
