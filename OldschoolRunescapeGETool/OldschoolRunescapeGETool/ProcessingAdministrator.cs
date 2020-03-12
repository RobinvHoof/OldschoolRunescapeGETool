using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OldschoolRunescapeGETool
{
    class ProcessingAdministrator
    {
        APIGet Api = new APIGet("http://services.runescape.com/m=itemdb_oldschool");
        MemoryReadWrite Reader = new MemoryReadWrite();
        GEAdministrator GEAdmin = new GEAdministrator();

        List<ProcessAction> processList = new List<ProcessAction>();
        List<SimpleProcess> simpleProcessList = new List<SimpleProcess>();

        public ProcessingAdministrator()
        {
            simpleProcessList = Reader.LoadProcessNameList();
        }

        public int FindProcessingCost(string processName)
        {
            foreach(SimpleProcess i in simpleProcessList)
            {
                if(i.processName == processName)
                {
                    return i.processingCost;
                }
            }
            return 0;
        }

        public async Task<ProcessAction> GetProcess(int baseItemId, int targetItemId)
        {
            string baseItemName = GEAdmin.GetNameFromId(baseItemId);
            string targetItemName = GEAdmin.GetNameFromId(targetItemId);

            string processingNameString = baseItemName + " > " + targetItemName;

            int processingCost = FindProcessingCost(processingNameString);

            foreach(ProcessAction i in processList)
            {
                string test = i.ToString();
                if (i.ToString() == processingNameString)
                {
                    return i;
                }
            }

            Item baseItem = await GEAdmin.GetItemObj(baseItemId).ConfigureAwait(false);
            Item targetItem = await GEAdmin.GetItemObj(targetItemId).ConfigureAwait(false);

            ProcessAction bufferProcess = new ProcessAction(baseItem, targetItem, processingCost);
            processList.Add(bufferProcess);

            return bufferProcess;
        }

        public List<string> LookForNameMatch(string containsString)
        {
            List<string> returnList = new List<string>();

            foreach(SimpleProcess i in simpleProcessList)
            {
                bool contains = i.processName.ToLower().Contains(containsString.ToLower());
                if (contains)
                {
                    returnList.Add(i.processName);
                } 
            }
            return returnList;
        }

        public void ResetProcesses()
        {
            processList.Clear();
        }
    }
}
