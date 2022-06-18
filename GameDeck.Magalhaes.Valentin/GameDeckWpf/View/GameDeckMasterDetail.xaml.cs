using GameDeckWpf.ViewModel;
using System.Windows.Controls;

namespace GameDeckWpf.View
{
    /// <summary>
    /// Logique d'interaction pour GameDeckMasterDetail.xaml
    /// </summary>
    public partial class GameDeckMasterDetail : UserControl
    {
        public GameDeckMasterDetail()
        {
            InitializeComponent();
            DataContext = new GameDeckMasterDetailVM();
        }
    }
}
