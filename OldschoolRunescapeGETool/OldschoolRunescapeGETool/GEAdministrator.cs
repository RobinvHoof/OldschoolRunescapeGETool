using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;


namespace OldschoolRunescapeGETool
{
    class GEAdministrator
    {
        private MemoryReadWrite Reader = new MemoryReadWrite();
        APIGet Api = new APIGet("http://services.runescape.com/m=itemdb_oldschool");

        private List<string> itemNameList;
        private List<SimpleItem> itemIdList = new List<SimpleItem>();

        public GEAdministrator()
        {
            itemNameList = Reader.LoadItemNameList();
            itemIdList = Reader.LoadItemIdList();
        }

        protected async Task<Item> GetItemObj(int itemId)
        {
            Item item = await Api.GetItemInfo(itemId);
            return item;
        }

        public List<string> LookForNameMatch(string containsString)
        {
            List<string> returnList = new List<string>();

            foreach (string i in itemNameList)
            {
                bool contains = i.ToLower().Contains(containsString.ToLower());
                if (contains)
                {
                    returnList.Add(i);
                } 
            }
            return returnList;
        }

        public int GetIdFromName(string itemName)
        {
            foreach(SimpleItem i in itemIdList)
            {
                if (i.name == itemName)
                {
                    return i.id;
                }
            }
            return -1;
        }

        public Bitmap GetItemIcon(int itemId)
        {
            Bitmap image = Api.GetItemIcon(GetItemObj(itemId).Result);
            return image;
        }


        
    }
}
