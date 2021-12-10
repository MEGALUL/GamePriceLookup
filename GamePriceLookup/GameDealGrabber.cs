using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePriceLookup.DataClasses;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GamePriceLookup
{
    public class GameDealGrabber : IGameDealGrabber
    {

        private RestClient client;
        public GameDealGrabber()
        {
            client = new RestClient("https://www.cheapshark.com/api/1.0/");
            client.Timeout = -1;
        }

        public IEnumerable<Store> GetStores()
        {
            try
            {
                var request = new RestRequest("stores", Method.GET);
                request.AlwaysMultipartFormData = true;
                IRestResponse response = client.Execute(request);

                var results = JsonConvert.DeserializeObject<IEnumerable<Store>>(response.Content);

                return results;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Unable to get store data");
                return null;
            }

        }

        public IEnumerable<Game> GetGames(string title, bool exactMatch)
        {
            try
            {
                int matchInt = exactMatch ? 1 : 0;
                var request = new RestRequest($"games?title={title}&exact={matchInt}", Method.GET);
                request.AlwaysMultipartFormData = true;
                IRestResponse response = client.Execute(request);

                var results = JsonConvert.DeserializeObject<IEnumerable<Game>>(response.Content);

                return results;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Unable to get game data");
                return null;
            }
        }

        public IEnumerable<DealShort> GetDealsOfGame(string id)
        {
            try
            {
                var request = new RestRequest($"games?id={id}", Method.GET);
                request.AlwaysMultipartFormData = true;
                IRestResponse response = client.Execute(request);

                //var results = JsonConvert.DeserializeObject<IEnumerable<DealShort>>(response.Content);

                //var results = response.Content[0].
                var parsedJson = JObject.Parse(response.Content);
                //Console.WriteLine(root);
                var results = parsedJson["deals"].ToObject<IEnumerable<DealShort>>();

                return results;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Unable to get game data");
                return null;
            }
        }

        public DealFull GetFullDealInfo(string dealID)
        {
            try
            {
                var request = new RestRequest($"deals?id={dealID}", Method.GET);
                request.AlwaysMultipartFormData = true;
                IRestResponse response = client.Execute(request);

                var parsedJson = JObject.Parse(response.Content);
                Console.WriteLine(parsedJson["cheapestPrice"]["price"]);

                var results = JsonConvert.DeserializeObject<DealFull>(response.Content);
                if (parsedJson["cheapestPrice"]["price"] != null && parsedJson["cheapestPrice"]["date"] != null)
                {
                    results.GameInfo.CheapestPrice = (float)parsedJson["cheapestPrice"]["price"];
                    results.GameInfo.CheapestPriceDate = (long)parsedJson["cheapestPrice"]["date"];
                }
                
                return results;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Unable to get deal data");
                return null;
            }
        }
    }
}
