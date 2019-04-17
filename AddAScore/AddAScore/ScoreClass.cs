using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddAScore
{
    class ScoreClass
    {
        public ScoreClass(String date, String sport, String team, int score)
        {
            Date = date;
            Sport = sport;
            Team = team;
            Score = score;
        }

        public String Date { get; set; }
        public String Sport { get; set; }
        public String Team { get; set; }
        public int Score { get; set; }
    }
}
