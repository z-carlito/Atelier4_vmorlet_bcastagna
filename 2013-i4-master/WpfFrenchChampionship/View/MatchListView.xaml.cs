using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfFrenchChampionship
{
    /// <summary>
    /// Logique d'interaction pour MatchListView.xaml
    /// </summary>
    public partial class MatchListView : UserControl
    {
        private ListView _listView;

        public MatchListView()
        {
            InitializeComponent();
        }

        public ListView ListView
        {
            get { return _listView; }
            set { _listView = value; }
        }
    }
}
