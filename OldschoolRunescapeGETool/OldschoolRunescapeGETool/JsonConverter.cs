using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;



namespace OldschoolRunescapeGETool
{
    class JsonConverter
    {
        //public async Task<Item> JsonToItem(HttpResponseMessage response)
        //{
        //    Item item = await response.Content.ReadAsAsync<Item>();
        //    return item;
        //}

        public async Task<Item> JsonToItem(HttpResponseMessage response)
        {
            string json = await response.Content.ReadAsStringAsync();
            Item item = JsonConvert.DeserializeObject<Item>(json);




            return item;
        }
    }
}
