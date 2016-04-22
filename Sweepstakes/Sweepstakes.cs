using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        string sweepstakesName;
        List<Contestant> contestantList = new List<Contestant>();
        public Sweepstakes(string sweepstakesName)
        {
            this.sweepstakesName = sweepstakesName;
        }
        public void registerContestant(Contestant contestant)
        {
            contestantList.Add(contestant);
        }
        Contestant pickWinner()
        {
            return contestantList[2];
        }
        public void printContestantInfo()
        {
            foreach(Contestant person in contestantList)
            {
                Console.WriteLine(person);
            }
        }
        //    Sweepstakes(string name)
        //    void RegisterContestant(Contestant contestant)
        //    string PickWinner()
        //    void PrintContestantInfo(Contestant contestant)
    }
}