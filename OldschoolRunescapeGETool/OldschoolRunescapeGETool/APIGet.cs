using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Drawing;
using System.IO;


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

        public async Task<Item> GetItemInfo(int itemId)
        {
            Item item;
            string url = baseUrl + "/api/catalogue/detail.json?item=" + Convert.ToString(itemId);
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                 item = await jsonConverter.JsonToItem(response);
            } else { return null; }
            return item;
        }

        public Bitmap GetItemIcon(Item item)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(item.icon_large);
            Bitmap image = new Bitmap(stream);
            return image;
        }

        

    }
}
