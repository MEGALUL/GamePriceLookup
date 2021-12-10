using GamePriceLookup.DataClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GamePriceLookup
{
    public class GameDealRepository
    {
        private readonly IGameDealGrabber grabber;
        public GameDealRepository(IGameDealGrabber dataProvider)
        {
            grabber = dataProvider;
        }

        public IEnumerable<Store> GetActiveStores()
        {
            IEnumerable<Store> storeList = grabber.GetStores().Where(s => s.IsActive == true).ToArray();
            foreach (Store s in storeList)
            {
                s.Selected = true;
            }
            return storeList;

        }

        public IEnumerable<Game> GetGameListWithIcons(string title, bool exactMatch)
        {
            IEnumerable<Game> gameList = grabber.GetGames(title, exactMatch);

            foreach (Game g in gameList)
            {
                g.Image = GetGameIcon(g.ImageURL);
            }

            return gameList;
        }

        public IEnumerable<DealShort> GetDealsOfGameInStores(string gameID, IEnumerable<Store> selectedStores)
        {
            IEnumerable<DealShort> dealList = grabber.GetDealsOfGame(gameID).Where(d => selectedStores.Any(s => s.StoreID == d.StoreID && s.Selected == true)).ToArray();

            foreach (DealShort d in dealList)
            {
                d.Savings = (float)Math.Round(d.Savings, 0);
            }

            return dealList;
        }

        public DealFull GetFullDealInfoAllFields(string dealID, IEnumerable<Store> storeList)
        {
            DealFull fullDealInfo = grabber.GetFullDealInfo(dealID);
            fullDealInfo.DealID = dealID;
            fullDealInfo = UpdateDates(fullDealInfo);
            fullDealInfo.CheaperDeals = GetStoreNameForDeals(fullDealInfo.CheaperDeals, storeList).ToArray();
            fullDealInfo.DealLink = BuildLink(dealID);

            return fullDealInfo;
        }


        public Game UpdateCheapestPrice(Game game, IEnumerable<Store> selectedStores)
        {
            IEnumerable<DealShort> deals = GetDealsOfGameInStores(game.GameID, selectedStores);
            if (deals.Count() > 0)
            {
                game.Cheapest = deals.Min(d => d.Price);
            }
            else
            {
                game.Cheapest = -1f;
            }

            return game;
        }


        public IEnumerable<DealShort> GetStoreNameForDeals(IEnumerable<DealShort> dealList, IEnumerable<Store> storeList)
        {
            foreach (DealShort deal in dealList)
            {
                deal.StoreName = storeList.Where(s => s.StoreID == deal.StoreID).Select(s => s.StoreName).FirstOrDefault();
            }

            return dealList;
        }

        public DateTime UnixTimeStampToDate(long unixTime)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTime).ToLocalTime();
            return dateTime;
        }

        public DealFull UpdateDates(DealFull dealFull)
        {
            dealFull.GameInfo.ConvertedReleaseDate = UnixTimeStampToDate(dealFull.GameInfo.ReleaseDate);
            dealFull.GameInfo.ConvertedCheapestPriceDate = UnixTimeStampToDate(dealFull.GameInfo.CheapestPriceDate);

            Console.WriteLine(dealFull.GameInfo.ReleaseDate);
            Console.WriteLine(dealFull.GameInfo.CheapestPriceDate);

            return dealFull;
        }

        public Bitmap GetGameIcon(string url)
        {
            Bitmap bmp = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                bmp = new Bitmap(response.GetResponseStream());
                response.Close();

                if (bmp.Width > 120)
                {
                    bmp = new Bitmap(bmp, new Size(120, 45));
                }
            }
            catch (Exception e)
            {
                bmp = new Bitmap("noImage.bmp");
                return bmp;
            }

            return bmp;
        }



        public string BuildLink(string dealID)
        {
            return $"https://www.cheapshark.com/redirect?dealID={dealID}";
        }

    }
}
