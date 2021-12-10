using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePriceLookup.DataClasses
{
    public class Game
    {
        private string gameID;
        private string steamAppID;
        private float cheapest;
        private string cheapestDealID;
        [JsonProperty("external")]
        private string title;
        [JsonProperty("thumb")]
        private string imageURL;
        private Bitmap image;
        

        public string GameID { get => gameID; set => gameID = value; }
        public string SteamAppID { get => steamAppID; set => steamAppID = value; }
        public float Cheapest { get => cheapest; set => cheapest = value; }
        public string CheapestDealID { get => cheapestDealID; set => cheapestDealID = value; }
        public string Title { get => title; set => title = value; }
        public string ImageURL { get => imageURL; set => imageURL = value; }
        public Bitmap Image { get => image; set => image = value; }
    }
}
