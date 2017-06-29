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
            fightingLevel = 0;
        }

        public void IncrementFightingLevel()
        {
            fightingLevel += 1;
        }
    }
}
