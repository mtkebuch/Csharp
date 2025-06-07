using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleFormGame
{
    public class Player
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int GamesPlayed { get; set; }
        public int WinPercentage { get; set; }
        public int MaxWinStreak { get; set; }
        public int CurrentWinStreak { get; set; }
    }

}
