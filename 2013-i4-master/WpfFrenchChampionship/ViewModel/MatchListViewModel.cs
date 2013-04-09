using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using SoccerRankingLib;
using System.Windows.Input;

using System.Collections.ObjectModel;

namespace WpfFrenchChampionship.ViewModel
{
    class MatchListViewModel : ViewModel
    {
        private ObservableCollection<Match> _matches;
        //Pour attacher cette liste à la listeView de RankingView.

        public ObservableCollection<Match> Matches
        {
            get { return _matches; }            
        }

        public MatchListViewModel(Ranking ranking)
        {
            
        }

    }
}
