using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        string contestantName;
        int lotteryNumber;
        public Contestant(string contestantName, int lotteryNumber)
        {
            this.contestantName = contestantName;
            this.lotteryNumber = lotteryNumber;
        }
    }
}
