using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    abstract class WorkerBot : Robot
    {
        string isHelpful;
        int workerLevel;

        public WorkerBot()
        {
            workerLevel = 0;
        }

        public void IncrementWorkerLevel(int level)
        {
            workerLevel += level;
        }
    }
}
