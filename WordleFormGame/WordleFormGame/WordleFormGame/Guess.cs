using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleFormGame
{
    public class Guess
    {
        public int Id { get; set; }
        public int RoundId { get; set; }
        public Round Round { get; set; }

        public string Word { get; set; }
        public int AttemptNumber { get; set; }
    }

}
