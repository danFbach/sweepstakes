using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Sweepstakes sweepstakes;
        public int contestantLimit;
        public Sweepstakes GetNextSweepstakesWinner()
        {
            Contestant contestant;
            sweepstakes = new Sweepstakes("sweepstakes1");
            Console.WriteLine("Please enter the number of contestants that can enter into this sweepstakes.\n\r(Stack)");
            bool check = int.TryParse(Console.ReadLine(), out contestantLimit);
            if (!check) { Console.WriteLine("Invalid entry."); }
            for (int i = 0; i < contestantLimit; i++)
            {
                contestant = new Contestant(i);
                sweepstakes.registerStackContestant(contestant);
            }
            return sweepstakes;
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Contestant winner = sweepstakes.pickStackWinner(contestantLimit);
            sweepstakes.printContestantInfo(winner);
        }
    }
}
