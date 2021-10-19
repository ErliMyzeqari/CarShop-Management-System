namespace Cars_dealer_V1._0_beta.Forms
{
    partial class frmClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pages = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.optEnterprise = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.optIndividul = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputNotes = new System.Windows.Forms.RichTextBox();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlEnterprise = new System.Windows.Forms.GroupBox();
            this.lblIndividual = new System.Windows.Forms.Label();
            this.inputFAX = new Cars_dealer_V1._0_beta.Helper.CustomTextbox();
            this.lblExportPrise = new System.Windows.Forms.Label();
            this.inputVAT = new Cars_dealer_V1._0_beta.Helper.CustomTextbox();
            this.label21 = new System.Windows.Forms.Label();
            this.inputEnterprise = new Cars_dealer_V1._0_beta.Helper.CustomTextbox();
            this.c = new System.Windows.Forms.Label();
            this.chkContactByEmail = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chkContactByPhone = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.inputEmail = new Cars_dealer_V1._0_beta.Helper.CustomTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.inputPhone = new Cars_dealer_V1._0_beta.Helper.CustomTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.inputAddress = new Cars_dealer_V1._0_beta.Helper.CustomTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.inputLastName = new Cars_dealer_V1._0_beta.Helper.CustomTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputFirstName = new Cars_dealer_V1._0_beta.Helper.CustomTextbox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnReload = new Bunifu.Framework.UI.BunifuImageButton();
            this.indicator = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnVehicle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReservations = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pages.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlEnterprise.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 56);
            this.panel2.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(949, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 42);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(16, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Client Details";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "lock_26px.png");
            // 
            // pages
            // 
            this.pages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pages.Controls.Add(this.tabPage1);
            this.pages.Controls.Add(this.tabPage2);
            this.pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pages.Location = new System.Drawing.Point(0, 120);
            this.pages.Multiline = true;
            this.pages.Name = "pages";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(997, 562);
            this.pages.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.optEnterprise);
            this.tabPage1.Controls.Add(this.optIndividul);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.pnlEnterprise);
            this.tabPage1.Controls.Add(this.c);
            this.tabPage1.Controls.Add(this.chkContactByEmail);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.chkContactByPhone);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.inputEmail);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.inputPhone);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.inputAddress);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.inputLastName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.inputFirstName);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(989, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "vehicle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(514, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 79;
            this.label6.Text = "Enterprise";
            // 
            // optEnterprise
            // 
            this.optEnterprise.Checked = false;
            this.optEnterprise.Location = new System.Drawing.Point(486, 55);
            this.optEnterprise.Name = "optEnterprise";
            this.optEnterprise.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.optEnterprise.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.optEnterprise.Size = new System.Drawing.Size(25, 25);
            this.optEnterprise.TabIndex = 76;
            this.optEnterprise.Text = null;
            this.optEnterprise.Click += new System.EventHandler(this.OptEnterprise_Click);
            // 
            // optIndividul
            // 
            this.optIndividul.Checked = true;
            this.optIndividul.Location = new System.Drawing.Point(351, 54);
            this.optIndividul.Name = "optIndividul";
            this.optIndividul.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.optIndividul.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.optIndividul.Size = new System.Drawing.Size(25, 25);
            this.optIndividul.TabIndex = 78;
            this.optIndividul.Text = null;
            this.optIndividul.Click += new System.EventHandler(this.OptIndividul_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(380, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 77;
            this.label7.Text = "Individual";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputNotes);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Purple;
            this.groupBox1.Location = new System.Drawing.Point(672, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 355);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remarks / Notes (Optional)";
            // 
            // inputNotes
            // 
            this.inputNotes.BackColor = System.Drawing.Color.White;
            this.inputNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputNotes.Location = new System.Drawing.Point(3, 21);
            this.inputNotes.Name = "inputNotes";
            this.inputNotes.Size = new System.Drawing.Size(284, 331);
            this.inputNotes.TabIndex = 80;
            this.inputNotes.Text = "";
            // 
            // btnReset
            // 
            this.btnReset.Active = false;
            this.btnReset.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.Gray;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderRadius = 0;
            this.btnReset.ButtonText = "Reset";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledColor = System.Drawing.Color.Gray;
            this.btnReset.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReset.Iconimage = null;
            this.btnReset.Iconimage_right = null;
            this.btnReset.Iconimage_right_Selected = null;
            this.btnReset.Iconimage_Selected = null;
            this.btnReset.IconMarginLeft = 0;
            this.btnReset.IconMarginRight = 0;
            this.btnReset.IconRightVisible = false;
            this.btnReset.IconRightZoom = 0D;
            this.btnReset.IconVisible = false;
            this.btnReset.IconZoom = 55D;
            this.btnReset.IsTab = false;
            this.btnReset.Location = new System.Drawing.Point(861, 477);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.Gray;
            this.btnReset.OnHovercolor = System.Drawing.Color.DarkGray;
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(101, 37);
            this.btnReset.TabIndex = 75;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Active = false;
            this.btnSave.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Purple;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = null;
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = false;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = false;
            this.btnSave.IconZoom = 55D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(754, 477);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.SeaGreen;
            this.btnSave.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(101, 37);
            this.btnSave.TabIndex = 74;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // pnlEnterprise
            // 
            this.pnlEnterprise.Controls.Add(this.lblIndividual);
            this.pnlEnterprise.Controls.Add(this.inputFAX);
            this.pnlEnterprise.Controls.Add(this.lblExportPrise);
            this.pnlEnterprise.Controls.Add(this.inputVAT);
            this.pnlEnterprise.Controls.Add(this.label21);
            this.pnlEnterprise.Controls.Add(this.inputEnterprise);
            this.pnlEnterprise.Enabled = false;
            this.pnlEnterprise.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.pnlEnterprise.ForeColor = System.Drawing.Color.Purple;
            this.pnlEnterprise.Location = new System.Drawing.Point(349, 107);
            this.pnlEnterprise.Name = "pnlEnterprise";
            this.pnlEnterprise.Size = new System.Drawing.Size(281, 286);
            this.pnlEnterprise.TabIndex = 72;
            this.pnlEnterprise.TabStop = false;
            this.pnlEnterprise.Text = "Enterprise";
            // 
            // lblIndividual
            // 
            this.lblIndividual.AutoSize = true;
            this.lblIndividual.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblIndividual.Location = new System.Drawing.Point(13, 201);
            this.lblIndividual.Name = "lblIndividual";
            this.lblIndividual.Size = new System.Drawing.Size(31, 17);
            this.lblIndividual.TabIndex = 29;
            this.lblIndividual.Text = "FAX";
            // 
            // inputFAX
            // 
            this.inputFAX.AcceptsReturn = false;
            this.inputFAX.AcceptsTab = false;
            this.inputFAX.AnimationSpeed = 220;
            this.inputFAX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.inputFAX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.inputFAX.BackColor = System.Drawing.Color.Transparent;
            this.inputFAX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inputFAX.BackgroundImage")));
            this.inputFAX.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.inputFAX.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.inputFAX.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.inputFAX.BorderColorIdle = System.Drawing.Color.Silver;
            this.inputFAX.BorderRadius = 1;
            this.inputFAX.BorderThickness = 1;
            this.inputFAX.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.inputFAX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputFAX.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.inputFAX.DefaultText = "";
            this.inputFAX.FillColor = System.Drawing.Color.White;
            this.inputFAX.HideSelection = true;
            this.inputFAX.IconLeft = null;
            this.inputFAX.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.inputFAX.IconPadding = 10;
            this.inputFAX.IconRight = ((System.Drawing.Image)(resources.GetObject("inputFAX.IconRight")));
            this.inputFAX.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.inputFAX.Lines = new string[0];
            this.inputFAX.Location = new System.Drawing.Point(16, 221);
            this.inputFAX.MaxLength = 32767;
            this.inputFAX.MinimumSize = new System.Drawing.Size(100, 35);
            this.inputFAX.Modified = false;
            this.inputFAX.Multiline = false;
            this.inputFAX.Name = "inputFAX";
            this.inputFAX.PasswordChar = '\0';
            this.inputFAX.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.inputFAX.PlaceholderText = "";
            this.inputFAX.ReadOnly = false;
            this.inputFAX.RegEx = "^(?!\\s*$).+";
            this.inputFAX.SelectedText = "";
            this.inputFAX.SelectionLength = 0;
            this.inputFAX.SelectionStart = 0;
            this.inputFAX.ShortcutsEnabled = true;
            this.inputFAX.Size = new System.Drawing.Size(250, 35);
            this.inputFAX.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.inputFAX.TabIndex = 28;
            this.inputFAX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputFAX.TextMarginLeft = 5;
            this.inputFAX.TextMarginTop = 0;
            this.inputFAX.TextPlaceholder = "";
            this.inputFAX.UseSystemPasswordChar = false;
            this.inputFAX.ValidatioErrorBorderColor = System.Drawing.Color.Tomato;
            this.inputFAX.ValidationFormat = Cars_dealer_V1._0_beta.Helper.CustomTextbox.ValidationType.NotEmpty;
            this.inputFAX.ValidatioSuccessBorderColor = System.Drawing.Color.SeaGreen;
            // 
            // lblExportPrise
            // 
            this.lblExportPrise.AutoSize = true;
            this.lblExportPrise.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblExportPrise.Location = new System.Drawing.Point(13, 118);
            this.lblExportPrise.Name = "lblExportPrise";
            this.lblExportPrise.Size = new System.Drawing.Size(30, 17);
            this.lblExportPrise.TabIndex = 27;
            this.lblExportPrise.Text = "VAT";
            // 
            // inputVAT
            // 
            this.inputVAT.AcceptsReturn = false;
            this.inputVAT.AcceptsTab = false;
            this.inputVAT.AnimationSpeed = 220;
            this.inputVAT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.inputVAT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.inputVAT.BackColor = System.Drawing.Color.Transparent;
            this.inputVAT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inputVAT.BackgroundImage")));
            this.inputVAT.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.inputVAT.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.inputVAT.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.inputVAT.BorderColorIdle = System.Drawing.Color.Silver;
            this.inputVAT.BorderRadius = 1;
            this.inputVAT.BorderThickness = 1;
            this.inputVAT.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.inputVAT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputVAT.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.inputVAT.DefaultText = "";
            this.inputVAT.FillColor = System.Drawing.Color.White;
            this.inputVAT.HideSelection = true;
            this.inputVAT.IconLeft = null;
            this.inputVAT.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.inputVAT.IconPadding = 10;
            this.inputVAT.IconRight = ((System.Drawing.Image)(resources.GetObject("inputVAT.IconRight")));
            this.inputVAT.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.inputVAT.Lines = new string[0];
            this.inputVAT.Location = new System.Drawing.Point(16, 138);
            this.inputVAT.MaxLength = 32767;
            this.inputVAT.MinimumSize = new System.Drawing.Size(100, 35);
            this.inputVAT.Modified = false;
            this.inputVAT.Multiline = false;
            this.inputVAT.Name = "inputVAT";
            this.inputVAT.PasswordChar = '\0';
            this.inputVAT.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.inputVAT.PlaceholderText = "";
            this.inputVAT.ReadOnly = false;
            this.inputVAT.RegEx = "^(?!\\s*$).+";
            this.inputVAT.SelectedText = "";
            this.inputVAT.SelectionLength = 0;
            this.inputVAT.SelectionStart = 0;
            this.inputVAT.ShortcutsEnabled = true;
            this.inputVAT.Size = new System.Drawing.Size(250, 35);
            this.inputVAT.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.inputVAT.TabIndex = 26;
            this.inputVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputVAT.TextMarginLeft = 5;
            this.inputVAT.TextMarginTop = 0;
            this.inputVAT.TextPlaceholder = "";
            this.inputVAT.UseSystemPasswordChar = false;
            this.inputVAT.ValidatioErrorBorderColor = System.Drawing.Color.Tomato;
            this.inputVAT.ValidationFormat = Cars_dealer_V1._0_beta.Helper.CustomTextbox.ValidationType.NotEmpty;
            this.inputVAT.ValidatioSuccessBorderColor = System.Drawing.Color.SeaGreen;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(13, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 17);
            this.label21.TabIndex = 25;
            this.label21.Text = "Enterpris Name";
            // 
            // inputEnterprise
            // 
            this.inputEnterprise.AcceptsReturn = false;
            this.inputEnterprise.AcceptsTab = false;
            this.inputEnterprise.AnimationSpeed = 220;
            this.inputEnterprise.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.inputEnterprise.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.inputEnterprise.BackColor = System.Drawing.Color.Transparent;
            this.inputEnterprise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inputEnterprise.BackgroundImage")));
            this.inputEnterprise.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.inputEnterprise.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.inputEnterprise.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.inputEnterprise.BorderColorIdle = System.Drawing.Color.Silver;
            this.inputEnterprise.BorderRadius = 1;
            this.inputEnterprise.BorderThickness = 1;
            this.inputEnterprise.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.inputEnterprise.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputEnterprise.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.inputEnterprise.DefaultText = "";
            this.inputEnterprise.FillColor = System.Drawing.Color.White;
            this.inputEnterprise.HideSelection = true;
            this.inputEnterprise.IconLeft = null;
            this.inputEnterprise.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.inputEnterprise.IconPadding = 10;
            this.inputEnterprise.IconRight = ((System.Drawing.Image)(resources.GetObject("inputEnterprise.IconRight")));
            this.inputEnterprise.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.inputEnterprise.Lines = new string[0];
            this.inputEnterprise.Location = new System.Drawing.Point(16, 56);
            this.inputEnterprise.MaxLength = 32767;
            this.inputEnterprise.MinimumSize = new System.Drawing.Size(100, 35);
            this.inputEnterprise.Modified = false;
            this.inputEnterprise.Multiline = false;
            this.inputEnterprise.Name = "inputEnterprise";
            this.inputEnterprise.PasswordChar = '\0';
            this.inputEnterprise.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.inputEnterprise.PlaceholderText = "";
            this.inputEnterprise.ReadOnly = false;
            this.inputEnterprise.RegEx = "^(?!\\s*$).+";
            this.inputEnterprise.SelectedText = "";
            this.inputEnterprise.SelectionLength = 0;
            this.inputEnterprise.SelectionStart = 0;
            this.inputEnterprise.ShortcutsEnabled = true;
            this.inputEnterprise.Size = new System.Drawing.Size(250, 35);
            this.inputEnterprise.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.inputEnterprise.TabIndex = 24;
            this.inputEnterprise.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputEnterprise.TextMarginLeft = 5;
            this.inputEnterprise.TextMarginTop = 0;
            this.inputEnterprise.TextPlaceholder = "";
            this.inputEnterprise.UseSystemPasswordChar = false;
            this.inputEnterprise.ValidatioErrorBorderColor = System.Drawing.Color.Tomato;
            this.inputEnterprise.ValidationFormat = Cars_dealer_V1._0_beta.Helper.CustomTextbox.ValidationType.NotEmpty;
            this.inputEnterprise.ValidatioSuccessBorderColor = System.Drawing.Color.SeaGreen;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.ForeColor = System.Drawing.Color.Purple;
            this.c.Location = new System.Drawing.Point(229, 437);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(110, 17);
            this.c.TabIndex = 71;
            this.c.Text = "Contact By Email";
            // 
            // chkContactByEmail
            // 
            this.chkContactByEmail.AllowBindingControlAnimation = true;
            this.chkContactByEmail.AllowBindingControlColorChanges = false;
            this.chkContactByEmail.AllowBindingControlLocation = true;
            this.chkContactByEmail.AllowCheckBoxAnimation = false;
            this.chkContactByEmail.AllowCheckmarkAnimation = true;
            this.chkContactByEmail.AllowOnHoverStates = true;
            this.chkContactByEmail.AutoCheck = true;
            this.chkContactByEmail.BackColor = System.Drawing.Color.Transparent;
            this.chkContactByEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkContactByEmail.BackgroundImage")));
            this.chkContactByEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkContactByEmail.BindingControl = null;
            this.chkContactByEmail.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.chkContactByEmail.Checked = true;
            this.chkContactByEmail.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.chkContactByEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkContactByEmail.CustomCheckmarkImage = null;
            this.chkContactByEmail.Location = new System.Drawing.Point(202, 435);
            this.chkContactByEmail.MinimumSize = new System.Drawing.Size(17, 17);
            this.chkContactByEmail.Name = "chkContactByEmail";
            this.chkContactByEmail.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.chkContactByEmail.OnCheck.BorderRadius = 2;
            this.chkContactByEmail.OnCheck.BorderThickness = 2;
            this.chkContactByEmail.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.chkContactByEmail.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.chkContactByEmail.OnCheck.CheckmarkThickness = 2;
            this.chkContactByEmail.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.chkContactByEmail.OnDisable.BorderRadius = 2;
            this.chkContactByEmail.OnDisable.BorderThickness = 2;
            this.chkContactByEmail.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkContactByEmail.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.chkContactByEmail.OnDisable.CheckmarkThickness = 2;
            this.chkContactByEmail.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.chkContactByEmail.OnHoverChecked.BorderRadius = 2;
            this.chkContactByEmail.OnHoverChecked.BorderThickness = 2;
            this.chkContactByEmail.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.chkContactByEmail.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.chkContactByEmail.OnHoverChecked.CheckmarkThickness = 2;
            this.chkContactByEmail.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.chkContactByEmail.OnHoverUnchecked.BorderRadius = 2;
            this.chkContactByEmail.OnHoverUnchecked.BorderThickness = 2;
            this.chkContactByEmail.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkContactByEmail.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.chkContactByEmail.OnUncheck.BorderRadius = 2;
            this.chkContactByEmail.OnUncheck.BorderThickness = 2;
            this.chkContactByEmail.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkContactByEmail.Size = new System.Drawing.Size(21, 21);
            this.chkContactByEmail.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.chkContactByEmail.TabIndex = 70;
            this.chkContactByEmail.ThreeState = false;
            this.chkContactByEmail.ToolTipText = null;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Purple;
            this.label17.Location = new System.Drawing.Point(59, 437);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 17);
            this.label17.TabIndex = 69;
            this.label17.Text = "Contact By Phone";
            // 
            // chkContactByPhone
            // 
            this.chkContactByPhone.AllowBindingControlAnimation = true;
            this.chkContactByPhone.AllowBindingControlColorChanges = false;
            this.chkContactByPhone.AllowBindingControlLocation = true;
            this.chkContactByPhone.AllowCheckBoxAnimation = false;
            this.chkContactByPhone.AllowCheckmarkAnimation = true;
            this.chkContactByPhone.AllowOnHoverStates = true;
            this.chkContactByPhone.AutoCheck = true;
            this.chkContactByPhone.BackColor = System.Drawing.Color.Transparent;
            this.chkContactByPhone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkContactByPhone.BackgroundImage")));
            this.chkContactByPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkContactByPhone.BindingControl = null;
            this.chkContactByPhone.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.chkContactByPhone.Checked = true;
            this.chkContactByPhone.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.chkContactByPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkContactByPhone.CustomCheckmarkImage = null;
            this.chkContactByPhone.Location = new System.Drawing.Point(32, 434);
            this.chkContactByPhone.MinimumSize = new System.Drawing.Size(17, 17);
            this.chkContactByPhone.Name = "chkContactByPhone";
            this.chkContactByPhone.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.chkContactByPhone.OnCheck.BorderRadius = 2;
            this.chkContactByPhone.OnCheck.BorderThickness = 2;
            this.chkContactByPhone.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.chkContactByPhone.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.chkContactByPhone.OnCheck.CheckmarkThickness = 2;
            this.chkContactByPhone.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.chkContactByPhone.OnDisable.BorderRadius = 2;
            this.chkContactByPhone.OnDisable.BorderThickness = 2;
            this.chkContactByPhone.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkContactByPhone.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.chkContactByPhone.OnDisable.CheckmarkThickness = 2;
            this.chkContactByPhone.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.chkContactByPhone.OnHoverChecked.BorderRadius = 2;
            this.chkContactByPhone.OnHoverChecked.BorderThickness = 2;
            this.chkContactByPhone.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.chkContactByPhone.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.chkContactByPhone.OnHoverChecked.CheckmarkThickness = 2;
            this.chkContactByPhone.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.chkContactByPhone.OnHoverUnchecked.BorderRadius = 2;
            this.chkContactByPhone.OnHoverUnchecked.BorderThickness = 2;
            this.chkContactByPhone.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkContactByPhone.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.chkContactByPhone.OnUncheck.BorderRadius = 2;
            this.chkContactByPhone.OnUncheck.BorderThickness = 2;
            this.chkContactByPhone.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkContactByPhone.Size = new System.Drawing.Size(21, 21);
            this.chkContactByPhone.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.chkContactByPhone.TabIndex = 68;
            this.chkContactByPhone.ThreeState = false;
            this.chkContactByPhone.ToolTipText = null;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Purple;
            this.label16.Location = new System.Drawing.Point(25, 341);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 17);
            this.label16.TabIndex = 63;
            this.label16.Text = "Email";
            // 
            // inputEmail
            // 
            this.inputEmail.AcceptsReturn = false;
            this.inputEmail.AcceptsTab = false;
            this.inputEmail.AnimationSpeed = 220;
            this.inputEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.inputEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.inputEmail.BackColor = System.Drawing.Color.Transparent;
            this.inputEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inputEmail.BackgroundImage")));
            this.inputEmail.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.inputEmail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.inputEmail.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.inputEmail.BorderColorIdle = System.Drawing.Color.Silver;
            this.inputEmail.BorderRadius = 1;
            this.inputEmail.BorderThickness = 1;
            this.inputEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.inputEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputEmail.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.inputEmail.DefaultText = "";
            this.inputEmail.FillColor = System.Drawing.Color.White;
            this.inputEmail.HideSelection = true;
            this.inputEmail.IconLeft = null;
            this.inputEmail.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.inputEmail.IconPadding = 10;
            this.inputEmail.IconRight = ((System.Drawing.Image)(resources.GetObject("inputEmail.IconRight")));
            this.inputEmail.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.inputEmail.Lines = new string[0];
            this.inputEmail.Location = new System.Drawing.Point(28, 361);
            this.inputEmail.MaxLength = 32767;
            this.inputEmail.MinimumSize = new System.Drawing.Size(100, 35);
            this.inputEmail.Modified = false;
            this.inputEmail.Multiline = false;
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.PasswordChar = '\0';
            this.inputEmail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.inputEmail.PlaceholderText = "";
            this.inputEmail.ReadOnly = false;
            this.inputEmail.RegEx = resources.GetString("inputEmail.RegEx");
            this.inputEmail.SelectedText = "";
            this.inputEmail.SelectionLength = 0;
            this.inputEmail.SelectionStart = 0;
            this.inputEmail.ShortcutsEnabled = true;
            this.inputEmail.Size = new System.Drawing.Size(281, 35);
            this.inputEmail.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.inputEmail.TabIndex = 62;
            this.inputEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputEmail.TextMarginLeft = 5;
            this.inputEmail.TextMarginTop = 0;
            this.inputEmail.TextPlaceholder = "";
            this.inputEmail.UseSystemPasswordChar = false;
            this.inputEmail.ValidatioErrorBorderColor = System.Drawing.Color.Tomato;
            this.inputEmail.ValidationFormat = Cars_dealer_V1._0_beta.Helper.CustomTextbox.ValidationType.Email;
            this.inputEmail.ValidatioSuccessBorderColor = System.Drawing.Color.SeaGreen;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Purple;
            this.label11.Location = new System.Drawing.Point(25, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 17);
            this.label11.TabIndex = 61;
            this.label11.Text = "Phone Number";
            // 
            // inputPhone
            // 
            this.inputPhone.AcceptsReturn = false;
            this.inputPhone.AcceptsTab = false;
            this.inputPhone.AnimationSpeed = 220;
            this.inputPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.inputPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.inputPhone.BackColor = System.Drawing.Color.Transparent;
            this.inputPhone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inputPhone.BackgroundImage")));
            this.inputPhone.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.inputPhone.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.inputPhone.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.inputPhone.BorderColorIdle = System.Drawing.Color.Silver;
            this.inputPhone.BorderRadius = 1;
            this.inputPhone.BorderThickness = 1;
            this.inputPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.inputPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputPhone.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.inputPhone.DefaultText = "";
            this.inputPhone.FillColor = System.Drawing.Color.White;
            this.inputPhone.HideSelection = true;
            this.inputPhone.IconLeft = null;
            this.inputPhone.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.inputPhone.IconPadding = 10;
            this.inputPhone.IconRight = ((System.Drawing.Image)(resources.GetObject("inputPhone.IconRight")));
            this.inputPhone.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.inputPhone.Lines = new string[0];
            this.inputPhone.Location = new System.Drawing.Point(28, 284);
            this.inputPhone.MaxLength = 32767;
            this.inputPhone.MinimumSize = new System.Drawing.Size(100, 35);
            this.inputPhone.Modified = false;
            this.inputPhone.Multiline = false;
            this.inputPhone.Name = "inputPhone";
            this.inputPhone.PasswordChar = '\0';
            this.inputPhone.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.inputPhone.PlaceholderText = "";
            this.inputPhone.ReadOnly = false;
            this.inputPhone.RegEx = "^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\\s\\./0-9]*$";
            this.inputPhone.SelectedText = "";
            this.inputPhone.SelectionLength = 0;
            this.inputPhone.SelectionStart = 0;
            this.inputPhone.ShortcutsEnabled = true;
            this.inputPhone.Size = new System.Drawing.Size(281, 35);
            this.inputPhone.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.inputPhone.TabIndex = 60;
            this.inputPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputPhone.TextMarginLeft = 5;
            this.inputPhone.TextMarginTop = 0;
            this.inputPhone.TextPlaceholder = "";
            this.inputPhone.UseSystemPasswordChar = false;
            this.inputPhone.ValidatioErrorBorderColor = System.Drawing.Color.Tomato;
            this.inputPhone.ValidationFormat = Cars_dealer_V1._0_beta.Helper.CustomTextbox.ValidationType.Phone;
            this.inputPhone.ValidatioSuccessBorderColor = System.Drawing.Color.SeaGreen;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(25, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 59;
            this.label10.Text = "Address";
            // 
            // inputAddress
            // 
            this.inputAddress.AcceptsReturn = false;
            this.inputAddress.AcceptsTab = false;
            this.inputAddress.AnimationSpeed = 220;
            this.inputAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.inputAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.inputAddress.BackColor = System.Drawing.Color.Transparent;
            this.inputAddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inputAddress.BackgroundImage")));
            this.inputAddress.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.inputAddress.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.inputAddress.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.inputAddress.BorderColorIdle = System.Drawing.Color.Silver;
            this.inputAddress.BorderRadius = 1;
            this.inputAddress.BorderThickness = 1;
            this.inputAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.inputAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputAddress.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.inputAddress.DefaultText = "";
            this.inputAddress.FillColor = System.Drawing.Color.White;
            this.inputAddress.HideSelection = true;
            this.inputAddress.IconLeft = null;
            this.inputAddress.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.inputAddress.IconPadding = 10;
            this.inputAddress.IconRight = ((System.Drawing.Image)(resources.GetObject("inputAddress.IconRight")));
            this.inputAddress.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.inputAddress.Lines = new string[0];
            this.inputAddress.Location = new System.Drawing.Point(28, 205);
            this.inputAddress.MaxLength = 32767;
            this.inputAddress.MinimumSize = new System.Drawing.Size(100, 35);
            this.inputAddress.Modified = false;
            this.inputAddress.Multiline = false;
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.PasswordChar = '\0';
            this.inputAddress.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.inputAddress.PlaceholderText = "";
            this.inputAddress.ReadOnly = false;
            this.inputAddress.RegEx = "^(?!\\s*$).+";
            this.inputAddress.SelectedText = "";
            this.inputAddress.SelectionLength = 0;
            this.inputAddress.SelectionStart = 0;
            this.inputAddress.ShortcutsEnabled = true;
            this.inputAddress.Size = new System.Drawing.Size(281, 35);
            this.inputAddress.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.inputAddress.TabIndex = 58;
            this.inputAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputAddress.TextMarginLeft = 5;
            this.inputAddress.TextMarginTop = 0;
            this.inputAddress.TextPlaceholder = "";
            this.inputAddress.UseSystemPasswordChar = false;
            this.inputAddress.ValidatioErrorBorderColor = System.Drawing.Color.Tomato;
            this.inputAddress.ValidationFormat = Cars_dealer_V1._0_beta.Helper.CustomTextbox.ValidationType.NotEmpty;
            this.inputAddress.ValidatioSuccessBorderColor = System.Drawing.Color.SeaGreen;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(25, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 57;
            this.label9.Text = "Last Name";
            // 
            // inputLastName
            // 
            this.inputLastName.AcceptsReturn = false;
            this.inputLastName.AcceptsTab = false;
            this.inputLastName.AnimationSpeed = 220;
            this.inputLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.inputLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.inputLastName.BackColor = System.Drawing.Color.Transparent;
            this.inputLastName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inputLastName.BackgroundImage")));
            this.inputLastName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.inputLastName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.inputLastName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.inputLastName.BorderColorIdle = System.Drawing.Color.Silver;
            this.inputLastName.BorderRadius = 1;
            this.inputLastName.BorderThickness = 1;
            this.inputLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.inputLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputLastName.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.inputLastName.DefaultText = "";
            this.inputLastName.FillColor = System.Drawing.Color.White;
            this.inputLastName.HideSelection = true;
            this.inputLastName.IconLeft = null;
            this.inputLastName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.inputLastName.IconPadding = 10;
            this.inputLastName.IconRight = ((System.Drawing.Image)(resources.GetObject("inputLastName.IconRight")));
            this.inputLastName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.inputLastName.Lines = new string[0];
            this.inputLastName.Location = new System.Drawing.Point(28, 127);
            this.inputLastName.MaxLength = 32767;
            this.inputLastName.MinimumSize = new System.Drawing.Size(100, 35);
            this.inputLastName.Modified = false;
            this.inputLastName.Multiline = false;
            this.inputLastName.Name = "inputLastName";
            this.inputLastName.PasswordChar = '\0';
            this.inputLastName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.inputLastName.PlaceholderText = "";
            this.inputLastName.ReadOnly = false;
            this.inputLastName.RegEx = "^(?!\\s*$).+";
            this.inputLastName.SelectedText = "";
            this.inputLastName.SelectionLength = 0;
            this.inputLastName.SelectionStart = 0;
            this.inputLastName.ShortcutsEnabled = true;
            this.inputLastName.Size = new System.Drawing.Size(281, 35);
            this.inputLastName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.inputLastName.TabIndex = 56;
            this.inputLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputLastName.TextMarginLeft = 5;
            this.inputLastName.TextMarginTop = 0;
            this.inputLastName.TextPlaceholder = "";
            this.inputLastName.UseSystemPasswordChar = false;
            this.inputLastName.ValidatioErrorBorderColor = System.Drawing.Color.Tomato;
            this.inputLastName.ValidationFormat = Cars_dealer_V1._0_beta.Helper.CustomTextbox.ValidationType.NotEmpty;
            this.inputLastName.ValidatioSuccessBorderColor = System.Drawing.Color.SeaGreen;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(25, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "First Name";
            // 
            // inputFirstName
            // 
            this.inputFirstName.AcceptsReturn = false;
            this.inputFirstName.AcceptsTab = false;
            this.inputFirstName.AnimationSpeed = 220;
            this.inputFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.inputFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.inputFirstName.BackColor = System.Drawing.Color.Transparent;
            this.inputFirstName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inputFirstName.BackgroundImage")));
            this.inputFirstName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.inputFirstName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.inputFirstName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.inputFirstName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.inputFirstName.BorderRadius = 1;
            this.inputFirstName.BorderThickness = 1;
            this.inputFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.inputFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputFirstName.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.inputFirstName.DefaultText = "";
            this.inputFirstName.FillColor = System.Drawing.Color.White;
            this.inputFirstName.HideSelection = true;
            this.inputFirstName.IconLeft = null;
            this.inputFirstName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.inputFirstName.IconPadding = 10;
            this.inputFirstName.IconRight = ((System.Drawing.Image)(resources.GetObject("inputFirstName.IconRight")));
            this.inputFirstName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.inputFirstName.Lines = new string[0];
            this.inputFirstName.Location = new System.Drawing.Point(28, 50);
            this.inputFirstName.MaxLength = 32767;
            this.inputFirstName.MinimumSize = new System.Drawing.Size(100, 35);
            this.inputFirstName.Modified = false;
            this.inputFirstName.Multiline = false;
            this.inputFirstName.Name = "inputFirstName";
            this.inputFirstName.PasswordChar = '\0';
            this.inputFirstName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.inputFirstName.PlaceholderText = "";
            this.inputFirstName.ReadOnly = false;
            this.inputFirstName.RegEx = "^(?!\\s*$).+";
            this.inputFirstName.SelectedText = "";
            this.inputFirstName.SelectionLength = 0;
            this.inputFirstName.SelectionStart = 0;
            this.inputFirstName.ShortcutsEnabled = true;
            this.inputFirstName.Size = new System.Drawing.Size(281, 35);
            this.inputFirstName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.inputFirstName.TabIndex = 51;
            this.inputFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputFirstName.TextMarginLeft = 5;
            this.inputFirstName.TextMarginTop = 0;
            this.inputFirstName.TextPlaceholder = "";
            this.inputFirstName.UseSystemPasswordChar = false;
            this.inputFirstName.ValidatioErrorBorderColor = System.Drawing.Color.Tomato;
            this.inputFirstName.ValidationFormat = Cars_dealer_V1._0_beta.Helper.CustomTextbox.ValidationType.NotEmpty;
            this.inputFirstName.ValidatioSuccessBorderColor = System.Drawing.Color.SeaGreen;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(989, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "reservation";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.indicator);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.btnVehicle);
            this.panel1.Controls.Add(this.btnReservations);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 64);
            this.panel1.TabIndex = 6;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageActive = null;
            this.btnDel.Location = new System.Drawing.Point(915, 20);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(30, 30);
            this.btnDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDel.TabIndex = 86;
            this.btnDel.TabStop = false;
            this.btnDel.Visible = false;
            this.btnDel.Zoom = 10;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageActive = null;
            this.btnReload.Location = new System.Drawing.Point(955, 18);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(38, 35);
            this.btnReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReload.TabIndex = 85;
            this.btnReload.TabStop = false;
            this.btnReload.Zoom = 10;
            this.btnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // indicator
            // 
            this.indicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.indicator.Location = new System.Drawing.Point(13, 55);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(120, 3);
            this.indicator.TabIndex = 76;
            this.indicator.TabStop = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 48);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(997, 16);
            this.bunifuSeparator2.TabIndex = 77;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // btnVehicle
            // 
            this.btnVehicle.Active = false;
            this.btnVehicle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.btnVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.btnVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVehicle.BorderRadius = 0;
            this.btnVehicle.ButtonText = "Client Info";
            this.btnVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVehicle.DisabledColor = System.Drawing.Color.DarkGray;
            this.btnVehicle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVehicle.Iconimage = null;
            this.btnVehicle.Iconimage_right = null;
            this.btnVehicle.Iconimage_right_Selected = null;
            this.btnVehicle.Iconimage_Selected = null;
            this.btnVehicle.IconMarginLeft = 0;
            this.btnVehicle.IconMarginRight = 0;
            this.btnVehicle.IconRightVisible = true;
            this.btnVehicle.IconRightZoom = 0D;
            this.btnVehicle.IconVisible = true;
            this.btnVehicle.IconZoom = 55D;
            this.btnVehicle.IsTab = false;
            this.btnVehicle.Location = new System.Drawing.Point(13, 10);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.btnVehicle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.btnVehicle.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.btnVehicle.selected = false;
            this.btnVehicle.Size = new System.Drawing.Size(120, 43);
            this.btnVehicle.TabIndex = 75;
            this.btnVehicle.Text = "Client Info";
            this.btnVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVehicle.Textcolor = System.Drawing.Color.Gray;
            this.btnVehicle.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicle.Click += new System.EventHandler(this.BtnReservations_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.Active = false;
            this.btnReservations.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.btnReservations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.btnReservations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReservations.BorderRadius = 0;
            this.btnReservations.ButtonText = "Reservations (1)";
            this.btnReservations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservations.DisabledColor = System.Drawing.Color.DarkGray;
            this.btnReservations.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReservations.Iconimage = null;
            this.btnReservations.Iconimage_right = null;
            this.btnReservations.Iconimage_right_Selected = null;
            this.btnReservations.Iconimage_Selected = null;
            this.btnReservations.IconMarginLeft = 0;
            this.btnReservations.IconMarginRight = 0;
            this.btnReservations.IconRightVisible = true;
            this.btnReservations.IconRightZoom = 0D;
            this.btnReservations.IconVisible = true;
            this.btnReservations.IconZoom = 55D;
            this.btnReservations.IsTab = false;
            this.btnReservations.Location = new System.Drawing.Point(149, 10);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.btnReservations.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.btnReservations.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.btnReservations.selected = false;
            this.btnReservations.Size = new System.Drawing.Size(155, 43);
            this.btnReservations.TabIndex = 78;
            this.btnReservations.Text = "Reservations (1)";
            this.btnReservations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReservations.Textcolor = System.Drawing.Color.Gray;
            this.btnReservations.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.Visible = false;
            this.btnReservations.Click += new System.EventHandler(this.BunifuFlatButton4_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(997, 682);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClient";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmStock";
            this.Load += new System.EventHandler(this.FrmStock_Load);
            this.Shown += new System.EventHandler(this.FrmStock_Shown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pages.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.pnlEnterprise.ResumeLayout(false);
            this.pnlEnterprise.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.ImageList imageList1;
        private Bunifu.UI.WinForms.BunifuPages pages;
        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private System.Windows.Forms.GroupBox pnlEnterprise;
        private System.Windows.Forms.Label lblIndividual;
        private Helper.CustomTextbox inputFAX;
        private System.Windows.Forms.Label lblExportPrise;
        private Helper.CustomTextbox inputVAT;
        private System.Windows.Forms.Label label21;
        private Helper.CustomTextbox inputEnterprise;
        private System.Windows.Forms.Label c;
        private Bunifu.UI.WinForms.BunifuCheckBox chkContactByEmail;
        private System.Windows.Forms.Label label17;
        private Bunifu.UI.WinForms.BunifuCheckBox chkContactByPhone;
        private System.Windows.Forms.Label label16;
        private Helper.CustomTextbox inputEmail;
        private System.Windows.Forms.Label label11;
        private Helper.CustomTextbox inputPhone;
        private System.Windows.Forms.Label label10;
        private Helper.CustomTextbox inputAddress;
        private System.Windows.Forms.Label label9;
        private Helper.CustomTextbox inputLastName;
        private System.Windows.Forms.Label label5;
        private Helper.CustomTextbox inputFirstName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox indicator;
        private Bunifu.Framework.UI.BunifuFlatButton btnVehicle;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuFlatButton btnReservations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox inputNotes;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuRadioButton optEnterprise;
        private Bunifu.UI.WinForms.BunifuRadioButton optIndividul;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuImageButton btnDel;
        private Bunifu.Framework.UI.BunifuImageButton btnReload;
    }
}