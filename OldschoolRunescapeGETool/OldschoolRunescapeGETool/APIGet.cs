using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;


namespace OldschoolRunescapeGETool
{
    class APIGet
    {
        static HttpClient client = new HttpClient();
        JsonConverter jsonConverter = new JsonConverter();

        private string baseUrl;

        public APIGet(string bufferBaseUrl)
        {
            baseUrl = bufferBaseUrl;
        }

        public async Task<Item> getItemInfo(int itemId)
        {
            Item item = null;
            HttpResponseMessage response = await client.GetAsync(baseUrl + "/api/catalogue/detail.json?item=" + Convert.ToString(itemId));
            if (response.IsSuccessStatusCode)
            {
                 item = await jsonConverter.JsonToItem(response);
            }
            Console.WriteLine(item.ToString());
            return item;
        }
        
    }
}
