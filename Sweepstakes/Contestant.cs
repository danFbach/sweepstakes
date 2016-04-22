using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sweepstakes
{
    class Contestant
    {
        string contestantName;
        int lotteryNumber;
        Random pickName = new Random();
        public Contestant(int lotteryNumber)
        {
            this.lotteryNumber = lotteryNumber;
            int nameInt = pickName.Next(1, 11);
            Thread.Sleep(5);
            switch (nameInt)
            {
                case (1):
                    this.contestantName = "Dan";
                    break;
                case (2):
                    this.contestantName = "Charles";
                    break;
                case (3):
                    this.contestantName = "Adam";
                    break;
                case (4):
                    this.contestantName = "Mike";
                    break;
                case (5):
                    this.contestantName = "Noah";
                    break;
                case (6):
                    this.contestantName = "Tyler";
                    break;
                case (7):
                    this.contestantName = "Dave";
                    break;
                case (8):
                    this.contestantName = "Lindsay";
                    break;
                case (9):
                    this.contestantName = "Vicki";
                    break;
                case (10):
                    this.contestantName = "Paul";
                    break;
            }
        }
        public override string ToString()
        {
            return String.Format("Contestant {0}, sweepstakes ID number {1}", contestantName,lotteryNumber);
        }
    }
}

































