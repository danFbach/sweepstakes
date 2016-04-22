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
            Contestant contestant;
            Sweepstakes sweepstakes = new Sweepstakes(null);
            int contestantLimit;
            Console.WriteLine("Please enter the number of contestants that can enter into this sweepstakes.");
            bool check = int.TryParse(Console.ReadLine(), out contestantLimit);
            if (!check) { Console.WriteLine("Invalid entry.");}
            for (int i = 0;i < contestantLimit; i++)
            {
                contestant = new Contestant(i);
                sweepstakes.registerContestant(contestant);
            }
            sweepstakes.printContestantInfo();
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