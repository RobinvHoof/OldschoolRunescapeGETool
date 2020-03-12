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
        public async Task<Item> JsonToItem(HttpResponseMessage response)
        {
            string json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            json = json.Remove(0, 8); // Removing {"item:" from start of json string as this is not needed
            json = json.Remove(json.Length - 1); // Removing } from the end of json string as this is not needed
            Item item = JsonConvert.DeserializeObject<Item>(json);
            return item;
        }

        public SimpleItem JsonToSimpleItem(string json)
        {
            SimpleItem item = JsonConvert.DeserializeObject<SimpleItem>(json);
            return item;
        }
    }
}
