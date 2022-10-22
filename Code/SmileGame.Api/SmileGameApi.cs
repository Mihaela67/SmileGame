using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SmileGame.Api
{
    public class SmileGameApi
    {
        private static HttpClient client = new HttpClient();      

        /// <summary>
        /// Gets the game data from the API in JSON format
        /// </summary>
        public static async Task<GameApiEntity> GetDataAsync()    
        {
            // initialize the http client so that it can accept JSON 
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // ask the remote API for a new game
            string result = await client.GetStringAsync("https://marcconrad.com/uob/smile/api.php");
            // deserialize the API response (used Newtonsoft Json to convert from a string to an object)
            GameApiEntity deserializedGameObject = JsonConvert.DeserializeObject<GameApiEntity>(result); 
            // save the image file from the deserialized JSON result
            await SaveImage(deserializedGameObject.Question);
            return deserializedGameObject;
        }

        /// <summary>
        /// Saves an online image located at <paramref name="url"/> on the disk
        /// </summary>
        /// <param name="url">The location of the image to be saved</param>
        private static async Task SaveImage(string url)
        {
            // get the image file from the web using the http client
            HttpResponseMessage response = await client.GetAsync(url);
            // open a file stream with the image name and save the downloaded image inside it
            using (FileStream fs = new FileStream(url.Substring(url.LastIndexOf("/") + 1), FileMode.CreateNew))
                await response.Content.CopyToAsync(fs);
        }
    }
}
