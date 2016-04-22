using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Contestant> sweeps = new Queue<Contestant>();
        Sweepstakes sweepstakes;
        public Sweepstakes GetNextSweepstakesWinner()
        {
            sweepstakes = new Sweepstakes("hizzlefasizzle");
            Random pickWinner = new Random();
            pickWinner.Next();
            return sweepstakes;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            throw new NotImplementedException();
        }
    }
}
