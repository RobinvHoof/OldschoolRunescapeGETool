using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldschoolRunescapeGETool
{
    class SimpleProcess
    {
        public SimpleProcess(string bProcessName, int bProcessingCost)
        {
            processName = bProcessName;
            processingCost = bProcessingCost;
        }

        public int processingCost;
        public string processName;
    }
}
