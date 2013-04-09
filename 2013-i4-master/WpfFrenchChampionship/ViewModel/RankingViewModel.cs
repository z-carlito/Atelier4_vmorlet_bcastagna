﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoccerRankingLib;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace WpfFrenchChampionship.ViewModel
{
    public class RankingViewModel : ViewModel//, INotifyCollectionChanged
    {

        public struct RankedClub
        {
            public int Rank { get; set; }
            public Club Club { get; set; }
            public string Total { get; set; }
        }

        private Ranking _ranking;

        public Ranking Ranking
        {
            get { return _ranking; }
            set { _ranking = value; }
            
        }
              
        public RankingViewModel(Ranking ranking)
        {
            this._ranking = ranking;
            
        }

 

        public IEnumerable<RankedClub> RankedClubs
        {
            get
            { 
               
                for(int i=0; i<this._ranking.Size; i++)
                    yield return new RankedClub()
                    {
                        Rank = i + 1,
                        Club = this._ranking.GetClub(i),
                        Total = this._ranking.GetPoints(i).ToString(), 

                    };
                this._ranking.NewMatchRegistered += RankingOnNewMatchRegistered;
            }   
   
        }

        private void RankingOnNewMatchRegistered(object sender, Ranking.MatchRegistrationEventArgs matchRegistrationEventArgs)
        {
            RaisePropertyChanged("");
        }
    }
}
