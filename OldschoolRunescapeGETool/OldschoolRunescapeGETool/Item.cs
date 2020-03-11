using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldschoolRunescapeGETool
{
    class Item
    {
        public string icon;
        public string icon_large;
        public int id;
        public string type;
        public string typeIcon;
        public string name;
        public string description;

        public struct current
        {
            string trend;
            string price;
        }
        public bool members;
        public struct day30
        {
            string trend;
            string change;
        }
        public struct day90
        {
            string trend;
            string change;
        }
        public struct day180
        {
            string trend;
            string change;
        }

        public Item(string json)
        {

        }
    }
}
