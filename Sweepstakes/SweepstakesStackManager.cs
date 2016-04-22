using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        public Sweepstakes GetNextSweepstakesWinner()
        {
            Sweepstakes winner = new Sweepstakes("newSweeps");
            Random sweepWinner = new Random();
            sweepWinner.Next(0, 100);
            return winner;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            throw new NotImplementedException();
        }
    }
}
