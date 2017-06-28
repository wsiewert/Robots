using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    abstract class Robot
    {
        string oilType;
        string material;
        string powerType;
        string color;
        int powerLevel;
        bool powerOn;
        bool isSelfAware;

        public Robot()
        {
            this.color = "gray";
            this.powerLevel = 0;
        }

        public void TurnPowerOn()
        {
            powerOn = true;
        }

        public void TurnPowerOff()
        {
            powerOn = false;
        }

        public void ChangeColor(string color)
        {
            this.color = color;
        }

        public void getPower()
        {
            powerLevel = 100;
        }
    }
}
