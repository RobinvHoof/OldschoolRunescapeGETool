using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldschoolRunescapeGETool
{
    public class Item
    {
        public struct StrCurrent
        {
            public string trend;
            public string price;
        }
        public struct StrToday
        {
            public string trend;
            public string price;
        }
        public struct StrDay30
        {
            public string trend;
            public string change;
        }
        public struct StrDay90
        {
            public string trend;
            public string change;
        }
        public struct StrDay180
        {
            public string trend;
            public string change;
        }


        public string icon { get; set; }
        public string icon_large { get; set; }
        public int id { get; set; }
        public string type { get; set; }
        public string typeIcon { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public StrCurrent current { get; set; }   
        public StrToday today { get; set; }     
        public bool members { get; set; }
        public StrDay30 day30 { get; set; }    
        public StrDay90 day90 { get; set; }
        public StrDay180 day180 { get; set; }
    }
}
