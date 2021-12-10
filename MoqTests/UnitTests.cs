using System;
using System.Collections.Generic;
using System.Linq;
using GamePriceLookup;
using GamePriceLookup.DataClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MoqTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestRepository()
        {
            var provider = new Mock<IGameDealGrabber>(MockBehavior.Strict);
            provider.Setup(m => m.GetStores())
                .Returns(new List<Store>
                {
                    new Store {StoreID = "1", StoreName = "TestStore1", IsActive = true, Selected = false},
                    new Store {StoreID = "2", StoreName = "TestStore2", IsActive = true, Selected = false},
                    new Store {StoreID = "3", StoreName = "TestStore3", IsActive = false, Selected = false},
                    new Store {StoreID = "4", StoreName = "TestStore4", IsActive = true, Selected = false},
                    new Store {StoreID = null, StoreName = null, IsActive = true, Selected = false},
                    new Store {StoreID = "5", StoreName = "TestStore5", IsActive = true, Selected = false}
                });

            provider.Setup(m => m.GetGames("game12", false))
                .Returns(new List<Game>
                {
                    new Game {GameID = "1111", Title = "Game12", ImageURL = "sssss", Image = null, SteamAppID = It.IsAny<string>(), Cheapest = 10, CheapestDealID = "bbbb" },
                    new Game {GameID = "2222", Title = "Game123", ImageURL = "nnnnnn", Image = null, SteamAppID = It.IsAny<string>(), Cheapest = 20, CheapestDealID = "dddd" },
                    new Game {GameID = "3333", Title = "Game124", ImageURL = "dddddd", Image = null, SteamAppID = It.IsAny<string>(), Cheapest = 30, CheapestDealID = "1234" }
                 });
            provider.Setup(m => m.GetGames("game12", true))
                .Returns(new List<Game>
                {
                    new Game {GameID = "2222", Title = "Game12", ImageURL = "nnnnnn", Image = null, SteamAppID = It.IsAny<string>(), Cheapest = 20, CheapestDealID = "dddd" }
                });
            provider.Setup(m => m.GetDealsOfGame("1111"))
                .Returns(new List<DealShort>
                {
                    new DealShort{DealID = "121", StoreID = "1", StoreName = null, Price = 10, RetailPrice = 20, Savings = It.IsAny<float>() },
                    new DealShort{DealID = "122", StoreID = "2", StoreName = null, Price = 15, RetailPrice = 20, Savings = It.IsAny<float>() },
                    new DealShort{DealID = "123", StoreID = "4", StoreName = null, Price = 17, RetailPrice = 20, Savings = It.IsAny<float>() },
                    new DealShort{DealID = "124", StoreID = "5", StoreName = null, Price = 20, RetailPrice = 20, Savings = It.IsAny<float>() }
                });
            provider.Setup(m => m.GetDealsOfGame("2222"))
                .Returns(new List<DealShort>
                {
                    new DealShort{DealID = "1231", StoreID = "5", StoreName = null, Price = 20, RetailPrice = 40, Savings = It.IsAny<float>() },
                    new DealShort{DealID = "1232", StoreID = "2", StoreName = null, Price = 30, RetailPrice = 40, Savings = It.IsAny<float>() },
                    new DealShort{DealID = "1233", StoreID = "4", StoreName = null, Price = 35, RetailPrice = 40, Savings = It.IsAny<float>() }
                });
            provider.Setup(m => m.GetDealsOfGame("3333"))
                .Returns(new List<DealShort>
                {
                    new DealShort{DealID = "1241", StoreID = "1", StoreName = null, Price = 30, RetailPrice = 50, Savings = It.IsAny<float>() }
                });
            provider.Setup(m => m.GetFullDealInfo("1241"))
                .Returns(new DealFull
                {
                    GameInfo = new GameInfo() { StoreID = "1", GameID = "3333", Name = "Game124", SalePrice = 30,
                        RetailPrice = 50, SteamRatingText = It.IsAny<String>(),
                        SteamRatingPercent = It.IsAny<int>(), SteamRatingCount = It.IsAny<int>(),
                        MetacriticScore = It.IsAny<int>(), MetacriticLink = It.IsAny<string>(),
                        ReleaseDate = 1638309600, Publisher = It.IsAny<string>(),
                        ImageURL = It.IsAny<String>(), CheapestPrice = 20,
                        CheapestPriceDate = 1635717600, ConvertedReleaseDate = default(DateTime) ,
                        ConvertedCheapestPriceDate = default(DateTime)
                    },
                    CheaperDeals = new DealShort[0],
                    DealID = null,
                    DealLink = null
                });

            provider.Setup(m => m.GetFullDealInfo("1232"))
                .Returns(new DealFull
                {
                    GameInfo = new GameInfo() { StoreID = "2", GameID = "2222", Name = "Game123", SalePrice = 30,
                        RetailPrice = 40, SteamRatingText = It.IsAny<String>(),
                        SteamRatingPercent = It.IsAny<int>(), SteamRatingCount = It.IsAny<int>(),
                        MetacriticScore = It.IsAny<int>(), MetacriticLink = It.IsAny<string>(),
                        ReleaseDate = 1604181600, Publisher = It.IsAny<string>(),
                        ImageURL = It.IsAny<String>(), CheapestPrice = 20,
                        CheapestPriceDate = 1606773600, ConvertedReleaseDate = default(DateTime) ,
                        ConvertedCheapestPriceDate = default(DateTime)
                },
                    CheaperDeals = new DealShort[1] { new DealShort() { StoreID = "5", DealID = "1231", Price = 20, RetailPrice = 40, Savings = 0, StoreName = null } } ,
                    DealID = null,
                    DealLink = null
                });
            provider.Setup(m => m.GetFullDealInfo("124"))
                .Returns(new DealFull
                {
                    GameInfo = new GameInfo() { StoreID = "5", GameID = "1111", Name = "Game12", SalePrice = 20,
                        RetailPrice = 20, SteamRatingText = It.IsAny<String>(),
                        SteamRatingPercent = It.IsAny<int>(), SteamRatingCount = It.IsAny<int>(),
                        MetacriticScore = It.IsAny<int>(), MetacriticLink = It.IsAny<string>(),
                        ReleaseDate = 1575151200, Publisher = It.IsAny<string>(),
                        ImageURL = It.IsAny<String>(), CheapestPrice = 10,
                        CheapestPriceDate = 1572559200, ConvertedReleaseDate = default(DateTime) ,
                        ConvertedCheapestPriceDate = default(DateTime)
                },
                CheaperDeals = new DealShort[3] 
                    { 
                        new DealShort() { StoreID = "4", DealID = "123", Price = 17, RetailPrice = 20, Savings = 0, StoreName = null },
                        new DealShort() { StoreID = "2", DealID = "122", Price = 15, RetailPrice = 20, Savings = 0, StoreName = null },
                        new DealShort() { StoreID = "1", DealID = "121", Price = 10, RetailPrice = 20, Savings = 0, StoreName = null }
                    },
                DealID = null,
                DealLink = null
                });



            var repository = new GameDealRepository(provider.Object);

            List<Store> customStoreList = new List<Store>
            {
                    new Store { StoreID = "4", StoreName = "TestStore4", IsActive = true, Selected = true },
                    new Store { StoreID = "5", StoreName = "TestStore5", IsActive = true, Selected = true }
            };

            List<Store> customStoreList2 = new List<Store>
            {
                    new Store { StoreID = "1", StoreName = "TestStore1", IsActive = true, Selected = true }
            };

            List<Store> customStoreList3 = new List<Store>
            {
                    new Store {StoreID = "1", StoreName = "TestStore1", IsActive = true, Selected = false},
                    new Store {StoreID = "2", StoreName = "TestStore2", IsActive = true, Selected = false},
                    new Store {StoreID = "3", StoreName = "TestStore3", IsActive = false, Selected = false},
                    new Store {StoreID = "4", StoreName = "TestStore4", IsActive = true, Selected = false},
                    new Store {StoreID = null, StoreName = null, IsActive = true, Selected = false},
                    new Store {StoreID = "5", StoreName = "TestStore5", IsActive = true, Selected = false}
            };

            List<Game> customGameList = new List<Game>
            {
                new Game {GameID = "1111", Title = "Game12", ImageURL = "sssss", Image = null, SteamAppID = It.IsAny<string>(), Cheapest = 10, CheapestDealID = "bbbb" }
            };

            List<Game> customGameList2 = new List<Game>
            {
                    new Game {GameID = "1111", Title = "Game12", ImageURL = "sssss", Image = null, SteamAppID = It.IsAny<string>(), Cheapest = 10, CheapestDealID = "bbbb" },
                    new Game {GameID = "2222", Title = "Game123", ImageURL = "nnnnnn", Image = null, SteamAppID = It.IsAny<string>(), Cheapest = 20, CheapestDealID = "dddd" },
                    new Game {GameID = "3333", Title = "Game124", ImageURL = "dddddd", Image = null, SteamAppID = It.IsAny<string>(), Cheapest = 30, CheapestDealID = "1234" }
            };

            List<DealShort> customDealList = new List<DealShort>
            {
                    new DealShort{DealID = "122", StoreID = "2", StoreName = null, Price = 15, RetailPrice = 20, Savings = It.IsAny<float>() },
                    new DealShort{DealID = "123", StoreID = "4", StoreName = null, Price = 17, RetailPrice = 20, Savings = It.IsAny<float>() },
                    new DealShort{DealID = "124", StoreID = "5", StoreName = null, Price = 20, RetailPrice = 20, Savings = It.IsAny<float>() }
            };

            List<DealShort> customDealList2 = new List<DealShort>
            {
                    new DealShort{DealID = "1241", StoreID = "1", StoreName = null, Price = 30, RetailPrice = 50, Savings = It.IsAny<float>() }
            };



            //Tests for GetActiveStores method
            Assert.AreEqual(5, repository.GetActiveStores().Count());
            Assert.AreEqual(false, repository.GetActiveStores().Any(s => s.Selected == false));
            Assert.AreEqual("TestStore4", repository.GetActiveStores().ToList()[2].StoreName);

            //Test for GetGameListWithIcons method

            Assert.IsNotNull(repository.GetGameListWithIcons("game12", true).Select(g => g.Image));

            //Tests for GetDealsOfGameInStores method

            Assert.AreEqual(2, repository.GetDealsOfGameInStores("1111", customStoreList).Count());
            Assert.AreEqual(0, repository.GetDealsOfGameInStores("2222", customStoreList2).Count());

            //Tests for UpdateCheapestPrice method

            Assert.AreEqual(17, repository.UpdateCheapestPrice(customGameList[0], customStoreList).Cheapest);
            Assert.AreEqual(-1, repository.UpdateCheapestPrice(customGameList2[1], customStoreList2).Cheapest);

            //Test for GetStoreNameForDeals method

            Assert.AreEqual(false, repository.GetStoreNameForDeals(customDealList, customStoreList3).Any(d => d.StoreName == null));
            Assert.AreEqual("TestStore1", repository.GetStoreNameForDeals(customDealList2, customStoreList3).ToList()[0].StoreName);

            //Tests for GetFullDealInfoAllFields method

            Assert.AreEqual(new DateTime(2019, 12, 1, 0, 0, 0), repository.GetFullDealInfoAllFields("124", customStoreList3).GameInfo.ConvertedReleaseDate);
            Assert.AreEqual("1241", repository.GetFullDealInfoAllFields("1241", customStoreList3).DealID);
            Assert.AreEqual("TestStore5", repository.GetFullDealInfoAllFields("1232", customStoreList3).CheaperDeals[0].StoreName);
            Assert.AreEqual("https://www.cheapshark.com/redirect?dealID=124", repository.GetFullDealInfoAllFields("124", customStoreList3).DealLink);

        }
    }
}
