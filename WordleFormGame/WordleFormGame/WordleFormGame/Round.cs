using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleFormGame
{
    public class Round
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }

        public string CorrectWord { get; set; }
        public int AttemptsUsed { get; set; }
        public int Score { get; set; }
    }

}
