using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            SweepstakesQueueManager queueSweeps = new SweepstakesQueueManager();
            Sweepstakes sweeps1 = queueSweeps.GetNextSweepstakesWinner();
            queueSweeps.InsertSweepstakes(sweeps1);

            SweepstakesStackManager stackSweeps = new SweepstakesStackManager();
            Sweepstakes sweeps2 = stackSweeps.GetNextSweepstakesWinner();
            stackSweeps.InsertSweepstakes(sweeps2);
            Console.ReadKey();
        }
    }
}

//Using a Systems.Collections.Generic.Dictionary as an underlying structure, create a Sweepstakes class with the following functions(you will need to define a Contestant class containing appropriate fields for the purpose):
//    Sweepstakes(string name)
//    void RegisterContestant(Contestant contestant)
//    string PickWinner()
//    void PrintContestantInfo(Contestant contestant)
//Create a sweepstakes management system:
//    Write an ISweepstakesManager interface with the following custom functions:
//        void InsertSweepstakes(Sweepstakes sweepstakes)
//        Sweepstakes GetNextSweepstakesWinner()
//    Inherit from the ISweepstakesManager interface to implement the following subclasses:
//        SweepstakesStackManager(using System.Collections.Generic.Stack)
//        SweepstakesQueueManager(using System.Collections.Generic.Queue)