namespace Cars_dealer_V1._0_beta.Pages
{
    partial class StocksPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StocksPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.inputSearchBy = new Bunifu.Framework.UI.BunifuDropdown();
            this.grid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.colImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.colKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransmission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWarranty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChassis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeller = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colInternet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsEnterprise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExportPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIndividualPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateStickersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.btnPrint = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnReload = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCSV = new Bunifu.Framework.UI.BunifuImageButton();
            this.inputFilter = new Bunifu.Framework.UI.BunifuDropdown();
            this.logo = new System.Windows.Forms.PictureBox();
            this.SaveSCVDLG = new System.Windows.Forms.SaveFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.printer = new KimToo.EasyHTMLReports(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.AnimationSpeed = 220;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearch.BorderRadius = 1;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconRight")));
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(643, 31);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "Search Stock...";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(360, 35);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginLeft = 5;
            this.txtSearch.TextMarginTop = 0;
            this.txtSearch.TextPlaceholder = "Search Stock...";
            this.bunifuToolTip1.SetToolTip(this.txtSearch, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtSearch, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtSearch, "");
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.BtnSearch_TextChanged);
            // 
            // inputSearchBy
            // 
            this.inputSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.inputSearchBy.BorderRadius = 3;
            this.inputSearchBy.DisabledColor = System.Drawing.Color.Gray;
            this.inputSearchBy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSearchBy.ForeColor = System.Drawing.Color.White;
            this.inputSearchBy.items = new string[] {
        "Model",
        "Type",
        "Version",
        "Transmission",
        "Year",
        "CC",
        "Color",
        "Warranty",
        "Chasssis",
        "Seller",
        "Internet",
        "VAT"};
            this.inputSearchBy.Location = new System.Drawing.Point(422, 31);
            this.inputSearchBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputSearchBy.Name = "inputSearchBy";
            this.inputSearchBy.NomalColor = System.Drawing.Color.Purple;
            this.inputSearchBy.onHoverColor = System.Drawing.Color.SteelBlue;
            this.inputSearchBy.selectedIndex = 0;
            this.inputSearchBy.Size = new System.Drawing.Size(214, 35);
            this.inputSearchBy.TabIndex = 3;
            this.bunifuToolTip1.SetToolTip(this.inputSearchBy, "");
            this.bunifuToolTip1.SetToolTipIcon(this.inputSearchBy, null);
            this.bunifuToolTip1.SetToolTipTitle(this.inputSearchBy, "");
            this.inputSearchBy.onItemSelected += new System.EventHandler(this.InputSearchBy_onItemSelected);
            // 
            // grid
            // 
            this.grid.AllowCustomTheming = false;
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.ColumnHeadersHeight = 40;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colImg,
            this.colKey,
            this.colType,
            this.colModel,
            this.colBrand,
            this.colVersion,
            this.colTransmission,
            this.colYear,
            this.colCC,
            this.colColor,
            this.colWarranty,
            this.colChassis,
            this.colSeller,
            this.colInternet,
            this.colVAT,
            this.colIsEnterprise,
            this.colBuyingPrice,
            this.colExportPrice,
            this.colIndividualPrice});
            this.grid.ContextMenuStrip = this.contextMenuStrip1;
            this.grid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.grid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grid.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.grid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.grid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.grid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.grid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid.CurrentTheme.Name = null;
            this.grid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.grid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.grid.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.grid.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.grid.HeaderForeColor = System.Drawing.Color.White;
            this.grid.Location = new System.Drawing.Point(15, 86);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 40;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(988, 620);
            this.grid.TabIndex = 4;
            this.grid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bunifuToolTip1.SetToolTip(this.grid, "");
            this.bunifuToolTip1.SetToolTipIcon(this.grid, null);
            this.bunifuToolTip1.SetToolTipTitle(this.grid, "");
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellContentClick);
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            // 
            // colImg
            // 
            this.colImg.FillWeight = 30F;
            this.colImg.HeaderText = "";
            this.colImg.Name = "colImg";
            this.colImg.ReadOnly = true;
            // 
            // colKey
            // 
            this.colKey.HeaderText = "Key";
            this.colKey.Name = "colKey";
            this.colKey.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colModel
            // 
            this.colModel.HeaderText = "Model";
            this.colModel.Name = "colModel";
            this.colModel.ReadOnly = true;
            // 
            // colBrand
            // 
            this.colBrand.HeaderText = "Brand";
            this.colBrand.Name = "colBrand";
            this.colBrand.ReadOnly = true;
            // 
            // colVersion
            // 
            this.colVersion.HeaderText = "Version";
            this.colVersion.Name = "colVersion";
            this.colVersion.ReadOnly = true;
            // 
            // colTransmission
            // 
            this.colTransmission.HeaderText = "Transmission";
            this.colTransmission.Name = "colTransmission";
            this.colTransmission.ReadOnly = true;
            // 
            // colYear
            // 
            this.colYear.HeaderText = "Year";
            this.colYear.Name = "colYear";
            this.colYear.ReadOnly = true;
            // 
            // colCC
            // 
            this.colCC.HeaderText = "CC";
            this.colCC.Name = "colCC";
            this.colCC.ReadOnly = true;
            // 
            // colColor
            // 
            this.colColor.HeaderText = "Color";
            this.colColor.Name = "colColor";
            this.colColor.ReadOnly = true;
            // 
            // colWarranty
            // 
            this.colWarranty.HeaderText = "Warraty";
            this.colWarranty.Name = "colWarranty";
            this.colWarranty.ReadOnly = true;
            // 
            // colChassis
            // 
            this.colChassis.HeaderText = "Chassis";
            this.colChassis.Name = "colChassis";
            this.colChassis.ReadOnly = true;
            // 
            // colSeller
            // 
            this.colSeller.HeaderText = "Seller";
            this.colSeller.Name = "colSeller";
            this.colSeller.ReadOnly = true;
            this.colSeller.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSeller.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colInternet
            // 
            this.colInternet.HeaderText = "Internet";
            this.colInternet.Name = "colInternet";
            this.colInternet.ReadOnly = true;
            this.colInternet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colVAT
            // 
            this.colVAT.HeaderText = "VAT";
            this.colVAT.Name = "colVAT";
            this.colVAT.ReadOnly = true;
            this.colVAT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colIsEnterprise
            // 
            this.colIsEnterprise.HeaderText = "ForEnterprise";
            this.colIsEnterprise.Name = "colIsEnterprise";
            this.colIsEnterprise.ReadOnly = true;
            // 
            // colBuyingPrice
            // 
            dataGridViewCellStyle3.Format = "N2";
            this.colBuyingPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.colBuyingPrice.HeaderText = "BuyingPrice";
            this.colBuyingPrice.Name = "colBuyingPrice";
            this.colBuyingPrice.ReadOnly = true;
            // 
            // colExportPrice
            // 
            dataGridViewCellStyle4.Format = "N2";
            this.colExportPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.colExportPrice.HeaderText = "ExportPrice";
            this.colExportPrice.Name = "colExportPrice";
            this.colExportPrice.ReadOnly = true;
            // 
            // colIndividualPrice
            // 
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.colIndividualPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.colIndividualPrice.HeaderText = "SellingPrice";
            this.colIndividualPrice.Name = "colIndividualPrice";
            this.colIndividualPrice.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printListToolStripMenuItem,
            this.generateStickersToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 48);
            this.bunifuToolTip1.SetToolTip(this.contextMenuStrip1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.contextMenuStrip1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.contextMenuStrip1, "");
            // 
            // printListToolStripMenuItem
            // 
            this.printListToolStripMenuItem.Name = "printListToolStripMenuItem";
            this.printListToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.printListToolStripMenuItem.Text = "Print List";
            this.printListToolStripMenuItem.Click += new System.EventHandler(this.PrintListToolStripMenuItem_Click);
            // 
            // generateStickersToolStripMenuItem
            // 
            this.generateStickersToolStripMenuItem.Name = "generateStickersToolStripMenuItem";
            this.generateStickersToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.generateStickersToolStripMenuItem.Text = "Generate Stickers";
            this.generateStickersToolStripMenuItem.Click += new System.EventHandler(this.GenerateStickersToolStripMenuItem_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(63, 32);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(38, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton1, "Add Stock");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton1, "");
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageActive = null;
            this.btnPrint.Location = new System.Drawing.Point(151, 32);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(38, 35);
            this.btnPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrint.TabIndex = 6;
            this.btnPrint.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnPrint, "Print List");
            this.bunifuToolTip1.SetToolTipIcon(this.btnPrint, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnPrint, "");
            this.btnPrint.Zoom = 10;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnReload
            // 
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageActive = null;
            this.btnReload.Location = new System.Drawing.Point(17, 32);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(38, 35);
            this.btnReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReload.TabIndex = 7;
            this.btnReload.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnReload, "Refresh");
            this.bunifuToolTip1.SetToolTipIcon(this.btnReload, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnReload, "");
            this.btnReload.Zoom = 10;
            this.btnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // btnCSV
            // 
            this.btnCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCSV.Image = ((System.Drawing.Image)(resources.GetObject("btnCSV.Image")));
            this.btnCSV.ImageActive = null;
            this.btnCSV.Location = new System.Drawing.Point(110, 34);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(32, 32);
            this.btnCSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCSV.TabIndex = 8;
            this.btnCSV.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnCSV, "Download CSV");
            this.bunifuToolTip1.SetToolTipIcon(this.btnCSV, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnCSV, "");
            this.btnCSV.Zoom = 10;
            this.btnCSV.Click += new System.EventHandler(this.BtnCSV_Click);
            // 
            // inputFilter
            // 
            this.inputFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFilter.BackColor = System.Drawing.Color.Transparent;
            this.inputFilter.BorderRadius = 3;
            this.inputFilter.DisabledColor = System.Drawing.Color.Gray;
            this.inputFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFilter.ForeColor = System.Drawing.Color.White;
            this.inputFilter.items = new string[] {
        "All Vehicles",
        "Available",
        "Reserved"};
            this.inputFilter.Location = new System.Drawing.Point(250, 31);
            this.inputFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputFilter.Name = "inputFilter";
            this.inputFilter.NomalColor = System.Drawing.Color.Purple;
            this.inputFilter.onHoverColor = System.Drawing.Color.SteelBlue;
            this.inputFilter.selectedIndex = 0;
            this.inputFilter.Size = new System.Drawing.Size(164, 35);
            this.inputFilter.TabIndex = 9;
            this.bunifuToolTip1.SetToolTip(this.inputFilter, "");
            this.bunifuToolTip1.SetToolTipIcon(this.inputFilter, null);
            this.bunifuToolTip1.SetToolTipTitle(this.inputFilter, "");
            this.inputFilter.onItemSelected += new System.EventHandler(this.InputFilter_onItemSelected);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(453, 335);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(100, 50);
            this.logo.TabIndex = 113;
            this.logo.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.logo, "");
            this.bunifuToolTip1.SetToolTipIcon(this.logo, null);
            this.bunifuToolTip1.SetToolTipTitle(this.logo, "");
            this.logo.Visible = false;
            // 
            // SaveSCVDLG
            // 
            this.SaveSCVDLG.Filter = "Excel CSV|*.csv";
            this.SaveSCVDLG.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveSCVDLG_FileOk);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "360_degrees_48px.png");
            this.imageList1.Images.SetKeyName(1, "360_degreess_48px.png");
            this.imageList1.Images.SetKeyName(2, "360_desgrees_48px.png");
            // 
            // printer
            // 
            this.printer.AlternativeRowBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.printer.AlternativeRowGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.printer.HeaderBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.printer.HeaderFontColor = System.Drawing.Color.White;
            this.printer.HeaderGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.printer.RowDefaultBackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.printer.RowDefaultFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.printer.RowDefaultGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            // 
            // StocksPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.logo);
            this.Controls.Add(this.inputFilter);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.inputSearchBy);
            this.Controls.Add(this.txtSearch);
            this.DoubleBuffered = true;
            this.Name = "StocksPage";
            this.Size = new System.Drawing.Size(1006, 720);
            this.bunifuToolTip1.SetToolTip(this, "");
            this.bunifuToolTip1.SetToolTipIcon(this, null);
            this.bunifuToolTip1.SetToolTipTitle(this, "");
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtSearch;
        private Bunifu.Framework.UI.BunifuDropdown inputSearchBy;
        private Bunifu.UI.WinForms.BunifuDataGridView grid;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton btnPrint;
        private Bunifu.Framework.UI.BunifuImageButton btnReload;
        private Bunifu.Framework.UI.BunifuImageButton btnCSV;
        private System.Windows.Forms.SaveFileDialog SaveSCVDLG;
        private Bunifu.Framework.UI.BunifuDropdown inputFilter;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateStickersToolStripMenuItem;
        private System.Windows.Forms.DataGridViewImageColumn colImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransmission;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWarranty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChassis;
        private System.Windows.Forms.DataGridViewLinkColumn colSeller;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInternet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsEnterprise;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExportPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndividualPrice;
        private KimToo.EasyHTMLReports printer;
        private System.Windows.Forms.PictureBox logo;
    }
}
