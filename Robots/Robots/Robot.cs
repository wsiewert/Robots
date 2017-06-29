using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    abstract class Robot
    {
        protected string oilType;
        protected string material;
        protected string powerType;
        protected string color;
        protected string madeIn;
        protected string serialNumber;
        protected int powerLevel;
        protected bool powerOn;
        protected bool isSelfAware;

        public Robot()
        {
            this.color = "gray";
            this.powerLevel = 0;
            TurnPowerOn();
            Random newSerialNumber = new Random();
            serialNumber = newSerialNumber.Next(100000000, 999999999).ToString();
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
