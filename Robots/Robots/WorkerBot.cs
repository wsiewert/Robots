using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    abstract class WorkerBot : Robot
    {
        int workerLevel;

        public WorkerBot()
        {
            serialNumber = "W" + serialNumber;
            material = "Steel";
            workerLevel = 0;
            madeIn = "ROBOTIX Inc. Palo Alto, CA";
            isSelfAware = false;
        }

        public void IncrementWorkerLevel(int level)
        {
            workerLevel += level;
        }

        public void DisplayWorkerLevel()
        {
            Console.WriteLine("Worker Level: " + workerLevel);
        }
    }
}
