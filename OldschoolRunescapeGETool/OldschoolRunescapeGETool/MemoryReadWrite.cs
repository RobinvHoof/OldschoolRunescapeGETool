using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OldschoolRunescapeGETool
{
    class MemoryReadWrite
    {
        JsonConverter jsonConverter = new JsonConverter();

        public List<string> LoadItemNameList()
        {
            string[] lines = File.ReadAllLines("ItemNameList.txt");
            List<string> itemList = new List<string>(lines);

            return itemList;
        }

        public List<SimpleItem> LoadItemIdList()
        {
            List<SimpleItem> itemList = new List<SimpleItem>();

            string text = File.ReadAllText("ItemNameId.txt");

            string[] lines = text.Split(',');
            List<string> linesList = new List<string>(lines);

            
            for(int i = 0; i < linesList.Count; i++)
            {
                linesList[i] += "," + linesList[i + 1];
                linesList.RemoveAt(i + 1);

                SimpleItem item = jsonConverter.JsonToSimpleItem(linesList[i]);
                itemList.Add(item);
            }

            return itemList;
        }



    }
}
