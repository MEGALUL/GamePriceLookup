using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePriceLookup.DataClasses
{
    public class GameInfo
    {
        private string storeID;
        private string gameID;
        private string name;
        private float salePrice;
        private float retailPrice;
        private string steamRatingText;
        private int steamRatingPercent;
        private int steamRatingCount;
        private int metacriticScore;
        private string metacriticLink;
        private long releaseDate;
        private string publisher;
        [JsonProperty("thumb")]
        private string imageURL;
        private float cheapestPrice;
        private long cheapestPriceDate;
        private DateTime convertedReleaseDate;
        private DateTime convertedCheapestPriceDate;

        public string StoreID { get => storeID; set => storeID = value; }
        public string GameID { get => gameID; set => gameID = value; }
        public string Name { get => name; set => name = value; }
        public float SalePrice { get => salePrice; set => salePrice = value; }
        public float RetailPrice { get => retailPrice; set => retailPrice = value; }
        public string SteamRatingText { get => steamRatingText; set => steamRatingText = value; }
        public int SteamRatingPercent { get => steamRatingPercent; set => steamRatingPercent = value; }
        public int SteamRatingCount { get => steamRatingCount; set => steamRatingCount = value; }
        public int MetacriticScore { get => metacriticScore; set => metacriticScore = value; }
        public string MetacriticLink { get => metacriticLink; set => metacriticLink = value; }
        public long ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string ImageURL { get => imageURL; set => imageURL = value; }
        public float CheapestPrice { get => cheapestPrice; set => cheapestPrice = value; }
        public long CheapestPriceDate { get => cheapestPriceDate; set => cheapestPriceDate = value; }
        public DateTime ConvertedReleaseDate { get => convertedReleaseDate; set => convertedReleaseDate = value; }
        public DateTime ConvertedCheapestPriceDate { get => convertedCheapestPriceDate; set => convertedCheapestPriceDate = value; }
    }
}
