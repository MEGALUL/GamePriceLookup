using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePriceLookup.DataClasses
{
    public class DealShort
    {
        private string storeID;
        private string dealID;
        [JsonProperty("salePrice")]
        private float price;
        private float retailPrice;
        private float savings;
        private string storeName;

        public string StoreID { get => storeID; set => storeID = value; }
        public string DealID { get => dealID; set => dealID = value; }
        public float Price { get => price; set => price = value; }
        public float RetailPrice { get => retailPrice; set => retailPrice = value; }
        public float Savings { get => savings; set => savings = value; }
        public string StoreName { get => storeName; set => storeName = value; }
    }
}
