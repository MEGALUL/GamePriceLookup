using GamePriceLookup;
using GamePriceLookup.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class mainWindow : Form
    {
        private IEnumerable<Game> gameList;
        private IEnumerable<Store> storeList;
        private IEnumerable<DealShort> dealList;
        private List<DealFull> fullDealList;
        private GameDealGrabber grabber;
        private GameDealRepository dataProvider;
        private string dealURL;

        public mainWindow()
        {
            grabber = new GameDealGrabber();
            dataProvider = new GameDealRepository(grabber);

            storeList = dataProvider.GetActiveStores();

            InitializeComponent();
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            HandleGameSearch();
        }

        private void buttonSelectStores_Click(object sender, EventArgs e)
        {
            HandleLowestPriceUpdate();
        }

        private void buttonSelectGame_Click(object sender, EventArgs e)
        {
            HandleGameSelect();
        }

        private void buttonGoToDeal_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(dealURL);
        }

        private void dealDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dealDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dealDataGridView.Rows[rowIndex];
            string dealID = Convert.ToString(selectedRow.Cells["dealID"].Value);
            DisplayDealInfo(dealID);
        }


        private void buttonGamePanelBack_Click(object sender, EventArgs e)
        {
            gameListPanel.Visible = false;
            dealViewPanel.Visible = false;
            mainPanel.Visible = true;
        }


        private void buttonBackFromDealScreen_Click(object sender, EventArgs e)
        {
            dealInfoPanel.Visible = false;
            mainPanel.Visible = false;
            gameListPanel.Visible = true;
        }

        private void metacriticLinkValueLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"http://www.metacritic.com{metacriticLinkValueLabel.Text}");
        }

        private void HandleGameSearch()
        {
            if (!string.IsNullOrEmpty(gameSearchBar.Text))
            {
                DisableControls();
                gameList = dataProvider.GetGameListWithIcons(gameSearchBar.Text, exactMatchCheckBox.Checked);
                EnableControls();

                if (gameList == null || !gameList.Any())
                {
                    labelInputNotification.Text = "Nothing was found. Please try a different query";
                    labelInputNotification.Visible = true;
                }
                else
                {
                    gameListPanel.Visible = true;
                    mainPanel.Visible = false;
                    labelInputNotification.Visible = false;
                    PopulateDataGridView(gameDataGridView, gameList);
                    PopulateDataGridView(storeDataGridView, storeList);
                    FormatGameView();
                    FormatStoreView();
                    labelInputNotification.Visible = false;
                }

            }
            else
            {
                labelInputNotification.Text = "Please input something to start searching";
                labelInputNotification.Visible = true;
            }
        }

        private void HandleLowestPriceUpdate()
        {
            if(!storeList.Any(s => s.Selected == true))
            {
                selectGameOrStoreWarningLabel.Visible = true;
                selectGameOrStoreWarningLabel.Text = "Please select at least 1 store";
            }
            else
            {
                DisableControls();
                foreach (Game g in gameList)
                {
                    dataProvider.UpdateCheapestPrice(g, storeList);
                    Thread.Sleep(1000);
                }
                
                selectGameOrStoreWarningLabel.Visible = false;
                EnableControls();
            }
        }

        private void HandleGameSelect()
        {
            int rowIndex = gameDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = gameDataGridView.Rows[rowIndex];
            string gameID = Convert.ToString(selectedRow.Cells["gameID"].Value);

            if (string.IsNullOrEmpty(gameID) || !storeList.Any(s => s.Selected))
            {
                selectGameOrStoreWarningLabel.Visible = true;
                selectGameOrStoreWarningLabel.Text = "Please select a game and at least one store";
            }
            else
            {
                dealList = dataProvider.GetDealsOfGameInStores(gameID, storeList);

                if (dealList.Count() == 0)
                {
                    selectGameOrStoreWarningLabel.Visible = true;
                    selectGameOrStoreWarningLabel.Text = "No deals were found for this game in selected stores";
                }
                else
                {
                    gameListPanel.Visible = false;
                    dealViewPanel.Visible = true;
                    dealList = dataProvider.GetStoreNameForDeals(dealList, storeList);
                    fullDealList = new List<DealFull>();
                    foreach (DealShort d in dealList)
                    {
                        DealFull fullDeal = dataProvider.GetFullDealInfoAllFields(d.DealID, storeList);
                        fullDealList.Add(fullDeal);
                    }
                    PopulateDataGridView(dealDataGridView, dealList);
                    FormatDealView();
                }
            }
        }

        private void DisplayDealInfo(string dealID)
        {
            dealInfoPanel.Visible = true;

            foreach (DealFull deal in fullDealList)
            {
                if (deal.DealID == dealID)
                {
                    nameValueLabel.Text = deal.GameInfo.Name;
                    publisherValueLabel.Text = deal.GameInfo.Publisher;
                    releaseDateValueLabel.Text = (deal.GameInfo.ReleaseDate != 0 ? deal.GameInfo.ConvertedReleaseDate.ToShortDateString() : "N/A");
                    steamScoreValueLabel.Text = $"{deal.GameInfo.SteamRatingText} ({deal.GameInfo.SteamRatingPercent}%) rating across {deal.GameInfo.SteamRatingCount} reviews";
                    metacriticValueLabel.Text = $"{deal.GameInfo.MetacriticScore}%";
                    metacriticLinkValueLabel.Text = deal.GameInfo.MetacriticLink;
                    salePriceValueLabel.Text = $"${deal.GameInfo.SalePrice}";
                    originalPriceValueLabel.Text = $"${deal.GameInfo.RetailPrice}";
                    historicalPriceValueLabel.Text = (deal.GameInfo.CheapestPriceDate != 0 ? $"${deal.GameInfo.CheapestPrice} on {deal.GameInfo.ConvertedCheapestPriceDate.ToShortDateString()}" : "N/A");
                    dealURL = deal.DealLink;

                    if (deal.CheaperDeals.Count() > 0)
                    {
                        cheaperStoresLabel.Visible = true;
                        cheaperStoresValueLabel.Visible = true;
                    }
                    else
                    {
                        cheaperStoresLabel.Visible = false;
                        cheaperStoresValueLabel.Visible = false;
                    }

                    string cheaperStoreNames = "";

                    foreach (DealShort d in deal.CheaperDeals)
                    {
                        cheaperStoreNames += $" {d.StoreName}";
                    }

                    cheaperStoresValueLabel.Text = cheaperStoreNames;
                }
            }
        }


        private void PopulateDataGridView(DataGridView dataGridView, IEnumerable<object> dataSource)
        {
            dataGridView.DataSource = dataSource;
        }

        private void FormatGameView()
        {
            gameDataGridView.Columns["GameID"].Visible = false;
            gameDataGridView.Columns["steamAppID"].Visible = false;
            gameDataGridView.Columns["cheapestDealID"].Visible = false;
            gameDataGridView.Columns["imageURL"].Visible = false;

            gameDataGridView.Columns["title"].DisplayIndex = 0;
            gameDataGridView.Columns["cheapest"].DisplayIndex = 1;

            gameDataGridView.Columns["cheapest"].HeaderText = "Lowest Price ($)";

            this.gameDataGridView.Columns["title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.gameDataGridView.Columns["cheapest"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.gameDataGridView.Columns["image"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void FormatStoreView()
        {
            storeDataGridView.Columns["storeID"].Visible = false;
            storeDataGridView.Columns["isActive"].Visible = false;

            storeDataGridView.Columns["storeName"].HeaderText = "Store Name";

            AddCheckBox();

            storeDataGridView.Columns["storeName"].ReadOnly = true;

        }

        private void FormatDealView()
        {
            dealDataGridView.Columns["storeID"].Visible = false;
            dealDataGridView.Columns["dealID"].Visible = false;

            dealDataGridView.Columns["price"].HeaderText = "Current price";
            dealDataGridView.Columns["retailPrice"].HeaderText = "Full price";
            dealDataGridView.Columns["savings"].HeaderText = "% saved";

            dealDataGridView.Columns["storeName"].DisplayIndex = 0;
        }

        private void AddCheckBox()
        {
            Rectangle rect = storeDataGridView.GetCellDisplayRectangle(3, -1, true);
            rect.Y = 2;
            rect.X = rect.Location.X + 80;
            CheckBox checkboxHeader = new CheckBox();
            checkboxHeader.Checked = true;
            checkboxHeader.Name = "checkboxHeader";
            checkboxHeader.Size = new Size(16, 16);
            checkboxHeader.Location = rect.Location;
            checkboxHeader.CheckedChanged += new EventHandler(checkboxHeader_CheckedChanged);
            storeDataGridView.Controls.Add(checkboxHeader);
        }

        private void checkboxHeader_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox headerBox = ((CheckBox)storeDataGridView.Controls.Find("checkboxHeader", true)[0]);
            for (int i = 0; i < storeDataGridView.RowCount; i++)
            {
                storeDataGridView.Rows[i].Cells["Selected"].Value = headerBox.Checked;
            }

            storeDataGridView.EndEdit();
            storeDataGridView.Update();
        }

        private void DisableControls()
        {
            buttonSearch.Enabled = false;
            buttonGamePanelBack.Enabled = false;
            buttonUpdateStores.Enabled = false;
            buttonSelectGame.Enabled = false;
            buttonBackFromDealScreen.Enabled = false;
            buttonGoToDeal.Enabled = false;
        }

        private void EnableControls()
        {
            buttonSearch.Enabled = true;
            buttonGamePanelBack.Enabled = true;
            buttonUpdateStores.Enabled = true;
            buttonSelectGame.Enabled = true;
            buttonBackFromDealScreen.Enabled = true;
            buttonGoToDeal.Enabled = true;

        }
    }
}
