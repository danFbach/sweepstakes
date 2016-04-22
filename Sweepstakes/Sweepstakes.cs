using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sweepstakes
{
    class Sweepstakes
    {
        string sweepstakesName;
        Queue<Contestant> contestantQueue = new Queue<Contestant>();
        Stack<Contestant> contestantStack = new Stack<Contestant>();
        public Sweepstakes(string sweepstakesName)
        {
            this.sweepstakesName = sweepstakesName;
        }
        public void registeQueuerContestant(Contestant contestant)
        {
            contestantQueue.Enqueue(contestant);
        }
        public void registerStackContestant(Contestant contestant)
        {
            contestantStack.Push(contestant);
        }
        public Contestant pickQueueWinner(int totalContestants)
        {
            Contestant queueWinner = null;
            Random pickContestant = new Random();
            int contestantChoice = pickContestant.Next(0, totalContestants);
            Console.WriteLine("And the lottery winner is...Number {0}, out of {1} contestants.", contestantChoice, totalContestants);
            foreach(Contestant personStuff in contestantQueue)
            {
                if (personStuff.lotteryNumber.Equals(contestantChoice))
                {
                    queueWinner = personStuff;
                }
            }
            return queueWinner;
        } 
        public Contestant pickStackWinner(int totalContestants)
        {
            Contestant stackWinner = null;
            Random pickContestant = new Random();
            int contestantChoice = pickContestant.Next(0, totalContestants);
            Console.WriteLine("And the lottery winner is...Number {0}, out of {1} contestants.", contestantChoice, totalContestants);
            foreach (Contestant person in contestantStack)
            {
                if (person.lotteryNumber.Equals(contestantChoice))
                {
                    stackWinner = person;
                }
            }
            return stackWinner;
        }
        public void printContestantInfo(Contestant contestant)
        {
            for(int i = 0;i < 70; i++)
            {
                Console.Write("*");
                Thread.Sleep(25);
            }
            Console.WriteLine("\n\r" + contestant);
        }
    }
}