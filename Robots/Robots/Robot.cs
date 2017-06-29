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
        protected string name;
        protected int powerLevel;
        protected bool powerOn;
        protected bool isSelfAware;

        public Robot()
        {
            color = "gray";
            powerLevel = 0;
            Random newSerialNumber = new Random();
            serialNumber = newSerialNumber.Next(100000000, 999999999).ToString();
            TurnPowerOn();
            DisplayStartUpMessage();
            CreateName();
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

        public void GetPower()
        {
            powerLevel = 100;
        }
        public void DisplayStartUpMessage()
        {
            Console.WriteLine("Welcome to your new Robot!");
            Console.WriteLine("Give it a minute to boot up.");
            Console.WriteLine("While you wait, Enter a name:");
        }

        public void CreateName()
        {
            name = Console.ReadLine();
        }

        public void GetRobotInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(serialNumber);
            Console.WriteLine(madeIn);
            Console.WriteLine(material);
            Console.WriteLine(powerType);
            Console.WriteLine(color); 
        }
    }
}
