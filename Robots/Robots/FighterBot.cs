using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    abstract class FighterBot : Robot
    {
        int fightingLevel;
        int killCount;

        public FighterBot()
        {
            serialNumber = "F" + serialNumber;
            material = "Vibratium";
            fightingLevel = 0;
            killCount = 0;
            madeIn = "Skynet - Toranto Canada";
            isSelfAware = false;
        }

        public void IncrementFightingLevel()
        {
            fightingLevel += 1;
        }

        public void DisplayFighterLevel()
        {
            Console.WriteLine("Fighting Level: " + fightingLevel);
        }

        public void DisplayKillCount()
        {
            Console.WriteLine("Kill Count: " + killCount);
        }

        public void IncrementKillCount()
        {
            killCount++;
        }

        public void Terminate()
        {
            IncrementKillCount();
        }
    }
}
