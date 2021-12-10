namespace GUI
{
    partial class mainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelInputNotification = new System.Windows.Forms.Label();
            this.exactMatchCheckBox = new System.Windows.Forms.CheckBox();
            this.gameSearchBar = new System.Windows.Forms.TextBox();
            this.gameListPanel = new System.Windows.Forms.Panel();
            this.selectGameOrStoreWarningLabel = new System.Windows.Forms.Label();
            this.storeListLabel = new System.Windows.Forms.Label();
            this.gameListLabel = new System.Windows.Forms.Label();
            this.storeDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonUpdateStores = new System.Windows.Forms.Button();
            this.gameDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonSelectGame = new System.Windows.Forms.Button();
            this.buttonGamePanelBack = new System.Windows.Forms.Button();
            this.buttonBackFromDealScreen = new System.Windows.Forms.Button();
            this.dealDataGridView = new System.Windows.Forms.DataGridView();
            this.dealInfoPanel = new System.Windows.Forms.Panel();
            this.metacriticLinkValueLabel = new System.Windows.Forms.LinkLabel();
            this.cheaperStoresValueLabel = new System.Windows.Forms.Label();
            this.cheaperStoresLabel = new System.Windows.Forms.Label();
            this.historicalPriceValueLabel = new System.Windows.Forms.Label();
            this.historicalPriceLabel = new System.Windows.Forms.Label();
            this.metacriticLinkLabel = new System.Windows.Forms.Label();
            this.metacriticValueLabel = new System.Windows.Forms.Label();
            this.metacriticLabel = new System.Windows.Forms.Label();
            this.steamScoreValueLabel = new System.Windows.Forms.Label();
            this.steamScoreLabel = new System.Windows.Forms.Label();
            this.releaseDateValueLabel = new System.Windows.Forms.Label();
            this.releaseDateLabel = new System.Windows.Forms.Label();
            this.publisherValueLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.originalPriceValueLabel = new System.Windows.Forms.Label();
            this.originalPriceLabel = new System.Windows.Forms.Label();
            this.salePriceValueLabel = new System.Windows.Forms.Label();
            this.salePriceLabel = new System.Windows.Forms.Label();
            this.nameValueLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.buttonGoToDeal = new System.Windows.Forms.Button();
            this.dealViewPanel = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.gameListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealDataGridView)).BeginInit();
            this.dealInfoPanel.SuspendLayout();
            this.dealViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.buttonSearch);
            this.mainPanel.Controls.Add(this.labelInputNotification);
            this.mainPanel.Controls.Add(this.exactMatchCheckBox);
            this.mainPanel.Controls.Add(this.gameSearchBar);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.MinimumSize = new System.Drawing.Size(200, 100);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 600);
            this.mainPanel.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearch.Location = new System.Drawing.Point(341, 291);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(120, 50);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelInputNotification
            // 
            this.labelInputNotification.AutoSize = true;
            this.labelInputNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputNotification.Location = new System.Drawing.Point(134, 388);
            this.labelInputNotification.Name = "labelInputNotification";
            this.labelInputNotification.Size = new System.Drawing.Size(511, 31);
            this.labelInputNotification.TabIndex = 3;
            this.labelInputNotification.Text = "Please input something to start searching";
            this.labelInputNotification.Visible = false;
            // 
            // exactMatchCheckBox
            // 
            this.exactMatchCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exactMatchCheckBox.AutoSize = true;
            this.exactMatchCheckBox.Location = new System.Drawing.Point(355, 258);
            this.exactMatchCheckBox.Name = "exactMatchCheckBox";
            this.exactMatchCheckBox.Size = new System.Drawing.Size(85, 17);
            this.exactMatchCheckBox.TabIndex = 2;
            this.exactMatchCheckBox.Text = "Exact match";
            this.exactMatchCheckBox.UseVisualStyleBackColor = true;
            // 
            // gameSearchBar
            // 
            this.gameSearchBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameSearchBar.Location = new System.Drawing.Point(195, 232);
            this.gameSearchBar.Name = "gameSearchBar";
            this.gameSearchBar.Size = new System.Drawing.Size(420, 20);
            this.gameSearchBar.TabIndex = 0;
            // 
            // gameListPanel
            // 
            this.gameListPanel.Controls.Add(this.selectGameOrStoreWarningLabel);
            this.gameListPanel.Controls.Add(this.storeListLabel);
            this.gameListPanel.Controls.Add(this.gameListLabel);
            this.gameListPanel.Controls.Add(this.storeDataGridView);
            this.gameListPanel.Controls.Add(this.buttonUpdateStores);
            this.gameListPanel.Controls.Add(this.gameDataGridView);
            this.gameListPanel.Controls.Add(this.buttonSelectGame);
            this.gameListPanel.Controls.Add(this.buttonGamePanelBack);
            this.gameListPanel.Location = new System.Drawing.Point(0, 0);
            this.gameListPanel.MinimumSize = new System.Drawing.Size(200, 100);
            this.gameListPanel.Name = "gameListPanel";
            this.gameListPanel.Size = new System.Drawing.Size(800, 600);
            this.gameListPanel.TabIndex = 5;
            this.gameListPanel.Visible = false;
            // 
            // selectGameOrStoreWarningLabel
            // 
            this.selectGameOrStoreWarningLabel.AutoSize = true;
            this.selectGameOrStoreWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectGameOrStoreWarningLabel.Location = new System.Drawing.Point(65, 522);
            this.selectGameOrStoreWarningLabel.Name = "selectGameOrStoreWarningLabel";
            this.selectGameOrStoreWarningLabel.Size = new System.Drawing.Size(655, 31);
            this.selectGameOrStoreWarningLabel.TabIndex = 11;
            this.selectGameOrStoreWarningLabel.Text = "To continue please select a game and at least 1 store";
            this.selectGameOrStoreWarningLabel.Visible = false;
            // 
            // storeListLabel
            // 
            this.storeListLabel.AutoSize = true;
            this.storeListLabel.Location = new System.Drawing.Point(600, 15);
            this.storeListLabel.Name = "storeListLabel";
            this.storeListLabel.Size = new System.Drawing.Size(47, 13);
            this.storeListLabel.TabIndex = 10;
            this.storeListLabel.Text = "Store list";
            // 
            // gameListLabel
            // 
            this.gameListLabel.AutoSize = true;
            this.gameListLabel.Location = new System.Drawing.Point(221, 15);
            this.gameListLabel.Name = "gameListLabel";
            this.gameListLabel.Size = new System.Drawing.Size(50, 13);
            this.gameListLabel.TabIndex = 9;
            this.gameListLabel.Text = "Game list";
            // 
            // storeDataGridView
            // 
            this.storeDataGridView.AllowUserToAddRows = false;
            this.storeDataGridView.AllowUserToDeleteRows = false;
            this.storeDataGridView.AllowUserToResizeColumns = false;
            this.storeDataGridView.AllowUserToResizeRows = false;
            this.storeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeDataGridView.Location = new System.Drawing.Point(497, 31);
            this.storeDataGridView.MultiSelect = false;
            this.storeDataGridView.Name = "storeDataGridView";
            this.storeDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.storeDataGridView.RowTemplate.Height = 45;
            this.storeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.storeDataGridView.Size = new System.Drawing.Size(263, 318);
            this.storeDataGridView.TabIndex = 8;
            // 
            // buttonUpdateStores
            // 
            this.buttonUpdateStores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdateStores.Location = new System.Drawing.Point(575, 366);
            this.buttonUpdateStores.Name = "buttonUpdateStores";
            this.buttonUpdateStores.Size = new System.Drawing.Size(120, 50);
            this.buttonUpdateStores.TabIndex = 7;
            this.buttonUpdateStores.Text = "Update Price";
            this.buttonUpdateStores.UseVisualStyleBackColor = true;
            this.buttonUpdateStores.Click += new System.EventHandler(this.buttonSelectStores_Click);
            // 
            // gameDataGridView
            // 
            this.gameDataGridView.AllowUserToAddRows = false;
            this.gameDataGridView.AllowUserToDeleteRows = false;
            this.gameDataGridView.AllowUserToResizeColumns = false;
            this.gameDataGridView.AllowUserToResizeRows = false;
            this.gameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameDataGridView.Location = new System.Drawing.Point(13, 31);
            this.gameDataGridView.MultiSelect = false;
            this.gameDataGridView.Name = "gameDataGridView";
            this.gameDataGridView.ReadOnly = true;
            this.gameDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gameDataGridView.RowTemplate.Height = 45;
            this.gameDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gameDataGridView.Size = new System.Drawing.Size(453, 318);
            this.gameDataGridView.TabIndex = 6;
            // 
            // buttonSelectGame
            // 
            this.buttonSelectGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSelectGame.Location = new System.Drawing.Point(416, 442);
            this.buttonSelectGame.Name = "buttonSelectGame";
            this.buttonSelectGame.Size = new System.Drawing.Size(120, 50);
            this.buttonSelectGame.TabIndex = 5;
            this.buttonSelectGame.Text = "Select";
            this.buttonSelectGame.UseVisualStyleBackColor = true;
            this.buttonSelectGame.Click += new System.EventHandler(this.buttonSelectGame_Click);
            // 
            // buttonGamePanelBack
            // 
            this.buttonGamePanelBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGamePanelBack.Location = new System.Drawing.Point(244, 442);
            this.buttonGamePanelBack.Name = "buttonGamePanelBack";
            this.buttonGamePanelBack.Size = new System.Drawing.Size(120, 50);
            this.buttonGamePanelBack.TabIndex = 4;
            this.buttonGamePanelBack.Text = "Back";
            this.buttonGamePanelBack.UseVisualStyleBackColor = true;
            this.buttonGamePanelBack.Click += new System.EventHandler(this.buttonGamePanelBack_Click);
            // 
            // buttonBackFromDealScreen
            // 
            this.buttonBackFromDealScreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBackFromDealScreen.Location = new System.Drawing.Point(326, 532);
            this.buttonBackFromDealScreen.Name = "buttonBackFromDealScreen";
            this.buttonBackFromDealScreen.Size = new System.Drawing.Size(120, 50);
            this.buttonBackFromDealScreen.TabIndex = 4;
            this.buttonBackFromDealScreen.Text = "Back";
            this.buttonBackFromDealScreen.UseVisualStyleBackColor = true;
            this.buttonBackFromDealScreen.Click += new System.EventHandler(this.buttonBackFromDealScreen_Click);
            // 
            // dealDataGridView
            // 
            this.dealDataGridView.AllowUserToAddRows = false;
            this.dealDataGridView.AllowUserToDeleteRows = false;
            this.dealDataGridView.AllowUserToResizeColumns = false;
            this.dealDataGridView.AllowUserToResizeRows = false;
            this.dealDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dealDataGridView.Location = new System.Drawing.Point(194, 33);
            this.dealDataGridView.MultiSelect = false;
            this.dealDataGridView.Name = "dealDataGridView";
            this.dealDataGridView.ReadOnly = true;
            this.dealDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dealDataGridView.RowTemplate.Height = 45;
            this.dealDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dealDataGridView.Size = new System.Drawing.Size(445, 200);
            this.dealDataGridView.TabIndex = 6;
            this.dealDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dealDataGridView_CellClick);
            // 
            // dealInfoPanel
            // 
            this.dealInfoPanel.Controls.Add(this.metacriticLinkValueLabel);
            this.dealInfoPanel.Controls.Add(this.cheaperStoresValueLabel);
            this.dealInfoPanel.Controls.Add(this.cheaperStoresLabel);
            this.dealInfoPanel.Controls.Add(this.historicalPriceValueLabel);
            this.dealInfoPanel.Controls.Add(this.historicalPriceLabel);
            this.dealInfoPanel.Controls.Add(this.metacriticLinkLabel);
            this.dealInfoPanel.Controls.Add(this.metacriticValueLabel);
            this.dealInfoPanel.Controls.Add(this.metacriticLabel);
            this.dealInfoPanel.Controls.Add(this.steamScoreValueLabel);
            this.dealInfoPanel.Controls.Add(this.steamScoreLabel);
            this.dealInfoPanel.Controls.Add(this.releaseDateValueLabel);
            this.dealInfoPanel.Controls.Add(this.releaseDateLabel);
            this.dealInfoPanel.Controls.Add(this.publisherValueLabel);
            this.dealInfoPanel.Controls.Add(this.publisherLabel);
            this.dealInfoPanel.Controls.Add(this.originalPriceValueLabel);
            this.dealInfoPanel.Controls.Add(this.originalPriceLabel);
            this.dealInfoPanel.Controls.Add(this.salePriceValueLabel);
            this.dealInfoPanel.Controls.Add(this.salePriceLabel);
            this.dealInfoPanel.Controls.Add(this.nameValueLabel);
            this.dealInfoPanel.Controls.Add(this.nameLabel);
            this.dealInfoPanel.Controls.Add(this.buttonGoToDeal);
            this.dealInfoPanel.Location = new System.Drawing.Point(20, 254);
            this.dealInfoPanel.Name = "dealInfoPanel";
            this.dealInfoPanel.Size = new System.Drawing.Size(754, 263);
            this.dealInfoPanel.TabIndex = 7;
            this.dealInfoPanel.Visible = false;
            // 
            // metacriticLinkValueLabel
            // 
            this.metacriticLinkValueLabel.AutoSize = true;
            this.metacriticLinkValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metacriticLinkValueLabel.Location = new System.Drawing.Point(120, 163);
            this.metacriticLinkValueLabel.MaximumSize = new System.Drawing.Size(300, 50);
            this.metacriticLinkValueLabel.Name = "metacriticLinkValueLabel";
            this.metacriticLinkValueLabel.Size = new System.Drawing.Size(69, 16);
            this.metacriticLinkValueLabel.TabIndex = 25;
            this.metacriticLinkValueLabel.TabStop = true;
            this.metacriticLinkValueLabel.Text = "linkLabel1";
            this.metacriticLinkValueLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.metacriticLinkValueLabel_LinkClicked);
            // 
            // cheaperStoresValueLabel
            // 
            this.cheaperStoresValueLabel.AutoSize = true;
            this.cheaperStoresValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheaperStoresValueLabel.Location = new System.Drawing.Point(469, 119);
            this.cheaperStoresValueLabel.MaximumSize = new System.Drawing.Size(250, 100);
            this.cheaperStoresValueLabel.Name = "cheaperStoresValueLabel";
            this.cheaperStoresValueLabel.Size = new System.Drawing.Size(37, 16);
            this.cheaperStoresValueLabel.TabIndex = 24;
            this.cheaperStoresValueLabel.Text = "Title:";
            this.cheaperStoresValueLabel.Visible = false;
            // 
            // cheaperStoresLabel
            // 
            this.cheaperStoresLabel.AutoSize = true;
            this.cheaperStoresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheaperStoresLabel.Location = new System.Drawing.Point(469, 92);
            this.cheaperStoresLabel.Name = "cheaperStoresLabel";
            this.cheaperStoresLabel.Size = new System.Drawing.Size(206, 16);
            this.cheaperStoresLabel.TabIndex = 23;
            this.cheaperStoresLabel.Text = "Currently cheaper at these stores:";
            this.cheaperStoresLabel.Visible = false;
            // 
            // historicalPriceValueLabel
            // 
            this.historicalPriceValueLabel.AutoSize = true;
            this.historicalPriceValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historicalPriceValueLabel.Location = new System.Drawing.Point(612, 66);
            this.historicalPriceValueLabel.Name = "historicalPriceValueLabel";
            this.historicalPriceValueLabel.Size = new System.Drawing.Size(37, 16);
            this.historicalPriceValueLabel.TabIndex = 22;
            this.historicalPriceValueLabel.Text = "Title:";
            // 
            // historicalPriceLabel
            // 
            this.historicalPriceLabel.AutoSize = true;
            this.historicalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historicalPriceLabel.Location = new System.Drawing.Point(469, 66);
            this.historicalPriceLabel.Name = "historicalPriceLabel";
            this.historicalPriceLabel.Size = new System.Drawing.Size(141, 16);
            this.historicalPriceLabel.TabIndex = 21;
            this.historicalPriceLabel.Text = "Historical lowest price:";
            // 
            // metacriticLinkLabel
            // 
            this.metacriticLinkLabel.AutoSize = true;
            this.metacriticLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metacriticLinkLabel.Location = new System.Drawing.Point(14, 163);
            this.metacriticLinkLabel.Name = "metacriticLinkLabel";
            this.metacriticLinkLabel.Size = new System.Drawing.Size(91, 16);
            this.metacriticLinkLabel.TabIndex = 19;
            this.metacriticLinkLabel.Text = "Metacritic link:";
            // 
            // metacriticValueLabel
            // 
            this.metacriticValueLabel.AutoSize = true;
            this.metacriticValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metacriticValueLabel.Location = new System.Drawing.Point(120, 134);
            this.metacriticValueLabel.Name = "metacriticValueLabel";
            this.metacriticValueLabel.Size = new System.Drawing.Size(37, 16);
            this.metacriticValueLabel.TabIndex = 18;
            this.metacriticValueLabel.Text = "Title:";
            // 
            // metacriticLabel
            // 
            this.metacriticLabel.AutoSize = true;
            this.metacriticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metacriticLabel.Location = new System.Drawing.Point(14, 134);
            this.metacriticLabel.Name = "metacriticLabel";
            this.metacriticLabel.Size = new System.Drawing.Size(105, 16);
            this.metacriticLabel.TabIndex = 17;
            this.metacriticLabel.Text = "Metacritic score:";
            // 
            // steamScoreValueLabel
            // 
            this.steamScoreValueLabel.AutoSize = true;
            this.steamScoreValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steamScoreValueLabel.Location = new System.Drawing.Point(120, 92);
            this.steamScoreValueLabel.MaximumSize = new System.Drawing.Size(350, 50);
            this.steamScoreValueLabel.Name = "steamScoreValueLabel";
            this.steamScoreValueLabel.Size = new System.Drawing.Size(37, 16);
            this.steamScoreValueLabel.TabIndex = 16;
            this.steamScoreValueLabel.Text = "Title:";
            // 
            // steamScoreLabel
            // 
            this.steamScoreLabel.AutoSize = true;
            this.steamScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steamScoreLabel.Location = new System.Drawing.Point(14, 92);
            this.steamScoreLabel.Name = "steamScoreLabel";
            this.steamScoreLabel.Size = new System.Drawing.Size(110, 16);
            this.steamScoreLabel.TabIndex = 15;
            this.steamScoreLabel.Text = "Rating on Steam:";
            // 
            // releaseDateValueLabel
            // 
            this.releaseDateValueLabel.AutoSize = true;
            this.releaseDateValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseDateValueLabel.Location = new System.Drawing.Point(120, 66);
            this.releaseDateValueLabel.Name = "releaseDateValueLabel";
            this.releaseDateValueLabel.Size = new System.Drawing.Size(37, 16);
            this.releaseDateValueLabel.TabIndex = 14;
            this.releaseDateValueLabel.Text = "Title:";
            // 
            // releaseDateLabel
            // 
            this.releaseDateLabel.AutoSize = true;
            this.releaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseDateLabel.Location = new System.Drawing.Point(14, 66);
            this.releaseDateLabel.Name = "releaseDateLabel";
            this.releaseDateLabel.Size = new System.Drawing.Size(93, 16);
            this.releaseDateLabel.TabIndex = 13;
            this.releaseDateLabel.Text = "Release date:";
            // 
            // publisherValueLabel
            // 
            this.publisherValueLabel.AutoSize = true;
            this.publisherValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherValueLabel.Location = new System.Drawing.Point(120, 40);
            this.publisherValueLabel.Name = "publisherValueLabel";
            this.publisherValueLabel.Size = new System.Drawing.Size(37, 16);
            this.publisherValueLabel.TabIndex = 12;
            this.publisherValueLabel.Text = "Title:";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherLabel.Location = new System.Drawing.Point(14, 40);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(67, 16);
            this.publisherLabel.TabIndex = 11;
            this.publisherLabel.Text = "Publisher:";
            // 
            // originalPriceValueLabel
            // 
            this.originalPriceValueLabel.AutoSize = true;
            this.originalPriceValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalPriceValueLabel.Location = new System.Drawing.Point(612, 40);
            this.originalPriceValueLabel.Name = "originalPriceValueLabel";
            this.originalPriceValueLabel.Size = new System.Drawing.Size(37, 16);
            this.originalPriceValueLabel.TabIndex = 10;
            this.originalPriceValueLabel.Text = "Title:";
            // 
            // originalPriceLabel
            // 
            this.originalPriceLabel.AutoSize = true;
            this.originalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalPriceLabel.Location = new System.Drawing.Point(469, 40);
            this.originalPriceLabel.Name = "originalPriceLabel";
            this.originalPriceLabel.Size = new System.Drawing.Size(90, 16);
            this.originalPriceLabel.TabIndex = 9;
            this.originalPriceLabel.Text = "Original price:";
            // 
            // salePriceValueLabel
            // 
            this.salePriceValueLabel.AutoSize = true;
            this.salePriceValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salePriceValueLabel.Location = new System.Drawing.Point(612, 14);
            this.salePriceValueLabel.Name = "salePriceValueLabel";
            this.salePriceValueLabel.Size = new System.Drawing.Size(37, 16);
            this.salePriceValueLabel.TabIndex = 8;
            this.salePriceValueLabel.Text = "Title:";
            // 
            // salePriceLabel
            // 
            this.salePriceLabel.AutoSize = true;
            this.salePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salePriceLabel.Location = new System.Drawing.Point(469, 14);
            this.salePriceLabel.Name = "salePriceLabel";
            this.salePriceLabel.Size = new System.Drawing.Size(72, 16);
            this.salePriceLabel.TabIndex = 7;
            this.salePriceLabel.Text = "Sale price:";
            // 
            // nameValueLabel
            // 
            this.nameValueLabel.AutoSize = true;
            this.nameValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameValueLabel.Location = new System.Drawing.Point(120, 14);
            this.nameValueLabel.Name = "nameValueLabel";
            this.nameValueLabel.Size = new System.Drawing.Size(37, 16);
            this.nameValueLabel.TabIndex = 6;
            this.nameValueLabel.Text = "Title:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(14, 14);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(37, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Title:";
            // 
            // buttonGoToDeal
            // 
            this.buttonGoToDeal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGoToDeal.Location = new System.Drawing.Point(306, 198);
            this.buttonGoToDeal.Name = "buttonGoToDeal";
            this.buttonGoToDeal.Size = new System.Drawing.Size(120, 50);
            this.buttonGoToDeal.TabIndex = 5;
            this.buttonGoToDeal.Text = "Open store";
            this.buttonGoToDeal.UseVisualStyleBackColor = true;
            this.buttonGoToDeal.Click += new System.EventHandler(this.buttonGoToDeal_Click);
            // 
            // dealViewPanel
            // 
            this.dealViewPanel.Controls.Add(this.dealInfoPanel);
            this.dealViewPanel.Controls.Add(this.dealDataGridView);
            this.dealViewPanel.Controls.Add(this.buttonBackFromDealScreen);
            this.dealViewPanel.Location = new System.Drawing.Point(0, 0);
            this.dealViewPanel.MinimumSize = new System.Drawing.Size(200, 100);
            this.dealViewPanel.Name = "dealViewPanel";
            this.dealViewPanel.Size = new System.Drawing.Size(800, 600);
            this.dealViewPanel.TabIndex = 12;
            this.dealViewPanel.Visible = false;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 593);
            this.Controls.Add(this.dealViewPanel);
            this.Controls.Add(this.gameListPanel);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(200, 100);
            this.Name = "mainWindow";
            this.Text = "Game Price Lookup";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.gameListPanel.ResumeLayout(false);
            this.gameListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealDataGridView)).EndInit();
            this.dealInfoPanel.ResumeLayout(false);
            this.dealInfoPanel.PerformLayout();
            this.dealViewPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox gameSearchBar;
        private System.Windows.Forms.CheckBox exactMatchCheckBox;
        private System.Windows.Forms.Label labelInputNotification;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel gameListPanel;
        private System.Windows.Forms.DataGridView gameDataGridView;
        private System.Windows.Forms.Button buttonSelectGame;
        private System.Windows.Forms.Button buttonGamePanelBack;
        private System.Windows.Forms.Button buttonUpdateStores;
        private System.Windows.Forms.Label storeListLabel;
        private System.Windows.Forms.Label gameListLabel;
        private System.Windows.Forms.DataGridView storeDataGridView;
        private System.Windows.Forms.Label selectGameOrStoreWarningLabel;
        private System.Windows.Forms.Button buttonBackFromDealScreen;
        private System.Windows.Forms.DataGridView dealDataGridView;
        private System.Windows.Forms.Panel dealInfoPanel;
        private System.Windows.Forms.LinkLabel metacriticLinkValueLabel;
        private System.Windows.Forms.Label cheaperStoresValueLabel;
        private System.Windows.Forms.Label cheaperStoresLabel;
        private System.Windows.Forms.Label historicalPriceValueLabel;
        private System.Windows.Forms.Label historicalPriceLabel;
        private System.Windows.Forms.Label metacriticLinkLabel;
        private System.Windows.Forms.Label metacriticValueLabel;
        private System.Windows.Forms.Label metacriticLabel;
        private System.Windows.Forms.Label steamScoreValueLabel;
        private System.Windows.Forms.Label steamScoreLabel;
        private System.Windows.Forms.Label releaseDateValueLabel;
        private System.Windows.Forms.Label releaseDateLabel;
        private System.Windows.Forms.Label publisherValueLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label originalPriceValueLabel;
        private System.Windows.Forms.Label originalPriceLabel;
        private System.Windows.Forms.Label salePriceValueLabel;
        private System.Windows.Forms.Label salePriceLabel;
        private System.Windows.Forms.Label nameValueLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button buttonGoToDeal;
        private System.Windows.Forms.Panel dealViewPanel;
    }
}

