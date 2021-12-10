using GamePriceLookup.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePriceLookup
{
    public interface IGameDealGrabber
    {
        IEnumerable<Store> GetStores();

        IEnumerable<Game> GetGames(string title, bool exactMatch);

        IEnumerable<DealShort> GetDealsOfGame(string id);

        DealFull GetFullDealInfo(string dealID);
    }
}
