using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePriceLookup.DataClasses
{
    public class Store
    {
        private string storeID;
        private string storeName;
        private bool isActive;
        private bool selected;

        public string StoreID { get => storeID; set => storeID = value; }
        public string StoreName { get => storeName; set => storeName = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        public bool Selected { get => selected; set => selected = value; }
    }
}
