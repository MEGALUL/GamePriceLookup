using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePriceLookup.DataClasses
{
    public class DealFull
    {
        private GameInfo gameInfo;
        [JsonProperty("cheaperStores")]
        private DealShort[] cheaperDeals;
        private string dealID;
        private string dealLink;

        public GameInfo GameInfo { get => gameInfo; set => gameInfo = value; }
        public DealShort[] CheaperDeals { get => cheaperDeals; set => cheaperDeals = value; }
        public string DealID { get => dealID; set => dealID = value; }
        public string DealLink { get => dealLink; set => dealLink = value; }
    }
}
