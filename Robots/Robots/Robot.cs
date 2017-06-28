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
        bool powerOn;
        bool isSelfAware;

        public Robot()
        {

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
    }
}
