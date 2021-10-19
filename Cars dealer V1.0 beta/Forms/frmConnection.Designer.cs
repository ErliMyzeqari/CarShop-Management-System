namespace Cars_dealer_V1._0_beta.Forms
{
    partial class frmConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnection));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUser = new Cars_dealer_V1._0_beta.Helper.CustomTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPort = new Cars_dealer_V1._0_beta.Helper.CustomTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDatabase = new Cars_dealer_V1._0_beta.Helper.CustomTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHost = new Cars_dealer_V1._0_beta.Helper.CustomTextbox();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new Cars_dealer_V1._0_beta.Helper.CustomTextbox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(428, 56);
            this.panel2.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(380, 6);
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
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(16, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Database Configuration";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(18, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.TabIndex = 69;
            this.label11.Text = "User";
            // 
            // txtUser
            // 
            this.txtUser.AcceptsReturn = false;
            this.txtUser.AcceptsTab = false;
            this.txtUser.AnimationSpeed = 220;
            this.txtUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUser.BackgroundImage")));
            this.txtUser.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtUser.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtUser.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtUser.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtUser.BorderRadius = 1;
            this.txtUser.BorderThickness = 1;
            this.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtUser.DefaultText = "";
            this.txtUser.FillColor = System.Drawing.Color.White;
            this.txtUser.HideSelection = true;
            this.txtUser.IconLeft = null;
            this.txtUser.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.IconPadding = 10;
            this.txtUser.IconRight = ((System.Drawing.Image)(resources.GetObject("txtUser.IconRight")));
            this.txtUser.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Lines = new string[0];
            this.txtUser.Location = new System.Drawing.Point(21, 303);
            this.txtUser.MaxLength = 32767;
            this.txtUser.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtUser.Modified = false;
            this.txtUser.Multiline = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtUser.PlaceholderText = "";
            this.txtUser.ReadOnly = false;
            this.txtUser.RegEx = "^(?!\\s*$).+";
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(384, 35);
            this.txtUser.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtUser.TabIndex = 68;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.TextMarginLeft = 5;
            this.txtUser.TextMarginTop = 0;
            this.txtUser.TextPlaceholder = "";
            this.txtUser.UseSystemPasswordChar = false;
            this.txtUser.ValidatioErrorBorderColor = System.Drawing.Color.Tomato;
            this.txtUser.ValidationFormat = Cars_dealer_V1._0_beta.Helper.CustomTextbox.ValidationType.NotEmpty;
            this.txtUser.ValidatioSuccessBorderColor = System.Drawing.Color.SeaGreen;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(18, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 17);
            this.label10.TabIndex = 67;
            this.label10.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.AcceptsReturn = false;
            this.txtPort.AcceptsTab = false;
            this.txtPort.AnimationSpeed = 220;
            this.txtPort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPort.BackColor = System.Drawing.Color.Transparent;
            this.txtPort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPort.BackgroundImage")));
            this.txtPort.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPort.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtPort.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPort.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPort.BorderRadius = 1;
            this.txtPort.BorderThickness = 1;
            this.txtPort.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPort.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtPort.DefaultText = "";
            this.txtPort.FillColor = System.Drawing.Color.White;
            this.txtPort.HideSelection = true;
            this.txtPort.IconLeft = null;
            this.txtPort.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPort.IconPadding = 10;
            this.txtPort.IconRight = ((System.Drawing.Image)(resources.GetObject("txtPort.IconRight")));
            this.txtPort.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPort.Lines = new string[0];
            this.txtPort.Location = new System.Drawing.Point(21, 234);
            this.txtPort.MaxLength = 32767;
            this.txtPort.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtPort.Modified = false;
            this.txtPort.Multiline = false;
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPort.PlaceholderText = "";
            this.txtPort.ReadOnly = false;
            this.txtPort.RegEx = "^[0-9]*$";
            this.txtPort.SelectedText = "";
            this.txtPort.SelectionLength = 0;
            this.txtPort.SelectionStart = 0;
            this.txtPort.ShortcutsEnabled = true;
            this.txtPort.Size = new System.Drawing.Size(384, 35);
            this.txtPort.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtPort.TabIndex = 66;
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPort.TextMarginLeft = 5;
            this.txtPort.TextMarginTop = 0;
            this.txtPort.TextPlaceholder = "";
            this.txtPort.UseSystemPasswordChar = false;
            this.txtPort.ValidatioErrorBorderColor = System.Drawing.Color.Tomato;
            this.txtPort.ValidationFormat = Cars_dealer_V1._0_beta.Helper.CustomTextbox.ValidationType.Integer;
            this.txtPort.ValidatioSuccessBorderColor = System.Drawing.Color.SeaGreen;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(18, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 65;
            this.label9.Text = "Database";
            // 
            // txtDatabase
            // 
            this.txtDatabase.AcceptsReturn = false;
            this.txtDatabase.AcceptsTab = false;
            this.txtDatabase.AnimationSpeed = 220;
            this.txtDatabase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDatabase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDatabase.BackColor = System.Drawing.Color.Transparent;
            this.txtDatabase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtDatabase.BackgroundImage")));
            this.txtDatabase.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtDatabase.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtDatabase.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtDatabase.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtDatabase.BorderRadius = 1;
            this.txtDatabase.BorderThickness = 1;
            this.txtDatabase.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDatabase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatabase.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtDatabase.DefaultText = "";
            this.txtDatabase.FillColor = System.Drawing.Color.White;
            this.txtDatabase.HideSelection = true;
            this.txtDatabase.IconLeft = null;
            this.txtDatabase.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatabase.IconPadding = 10;
            this.txtDatabase.IconRight = ((System.Drawing.Image)(resources.GetObject("txtDatabase.IconRight")));
            this.txtDatabase.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatabase.Lines = new string[0];
            this.txtDatabase.Location = new System.Drawing.Point(21, 164);
            this.txtDatabase.MaxLength = 32767;
            this.txtDatabase.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtDatabase.Modified = false;
            this.txtDatabase.Multiline = false;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.PasswordChar = '\0';
            this.txtDatabase.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDatabase.PlaceholderText = "";
            this.txtDatabase.ReadOnly = false;
            this.txtDatabase.RegEx = "^(?!\\s*$).+";
            this.txtDatabase.SelectedText = "";
            this.txtDatabase.SelectionLength = 0;
            this.txtDatabase.SelectionStart = 0;
            this.txtDatabase.ShortcutsEnabled = true;
            this.txtDatabase.Size = new System.Drawing.Size(384, 35);
            this.txtDatabase.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtDatabase.TabIndex = 64;
            this.txtDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDatabase.TextMarginLeft = 5;
            this.txtDatabase.TextMarginTop = 0;
            this.txtDatabase.TextPlaceholder = "";
            this.txtDatabase.UseSystemPasswordChar = false;
            this.txtDatabase.ValidatioErrorBorderColor = System.Drawing.Color.Tomato;
            this.txtDatabase.ValidationFormat = Cars_dealer_V1._0_beta.Helper.CustomTextbox.ValidationType.NotEmpty;
            this.txtDatabase.ValidatioSuccessBorderColor = System.Drawing.Color.SeaGreen;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(18, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 63;
            this.label5.Text = "Server";
            // 
            // txtHost
            // 
            this.txtHost.AcceptsReturn = false;
            this.txtHost.AcceptsTab = false;
            this.txtHost.AnimationSpeed = 220;
            this.txtHost.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtHost.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtHost.BackColor = System.Drawing.Color.Transparent;
            this.txtHost.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtHost.BackgroundImage")));
            this.txtHost.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtHost.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtHost.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtHost.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.txtHost.BorderRadius = 1;
            this.txtHost.BorderThickness = 1;
            this.txtHost.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtHost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHost.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtHost.DefaultText = "";
            this.txtHost.FillColor = System.Drawing.Color.White;
            this.txtHost.HideSelection = true;
            this.txtHost.IconLeft = null;
            this.txtHost.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHost.IconPadding = 10;
            this.txtHost.IconRight = ((System.Drawing.Image)(resources.GetObject("txtHost.IconRight")));
            this.txtHost.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHost.Lines = new string[0];
            this.txtHost.Location = new System.Drawing.Point(21, 98);
            this.txtHost.MaxLength = 32767;
            this.txtHost.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtHost.Modified = false;
            this.txtHost.Multiline = false;
            this.txtHost.Name = "txtHost";
            this.txtHost.PasswordChar = '\0';
            this.txtHost.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtHost.PlaceholderText = "";
            this.txtHost.ReadOnly = false;
            this.txtHost.RegEx = "^(?!\\s*$).+";
            this.txtHost.SelectedText = "";
            this.txtHost.SelectionLength = 0;
            this.txtHost.SelectionStart = 0;
            this.txtHost.ShortcutsEnabled = true;
            this.txtHost.Size = new System.Drawing.Size(384, 35);
            this.txtHost.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtHost.TabIndex = 62;
            this.txtHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHost.TextMarginLeft = 5;
            this.txtHost.TextMarginTop = 0;
            this.txtHost.TextPlaceholder = "";
            this.txtHost.UseSystemPasswordChar = false;
            this.txtHost.ValidatioErrorBorderColor = System.Drawing.Color.Tomato;
            this.txtHost.ValidationFormat = Cars_dealer_V1._0_beta.Helper.CustomTextbox.ValidationType.NotEmpty;
            this.txtHost.ValidatioSuccessBorderColor = System.Drawing.Color.SeaGreen;
            // 
            // btnSave
            // 
            this.btnSave.Active = false;
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Purple;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "Save Changes";
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
            this.btnSave.Location = new System.Drawing.Point(-7, 441);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(441, 48);
            this.btnSave.TabIndex = 76;
            this.btnSave.Text = "Save Changes";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 78;
            this.label1.Text = "Pasword";
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.AnimationSpeed = 220;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPassword.BorderRadius = 1;
            this.txtPassword.BorderThickness = 1;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.White;
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = null;
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.IconPadding = 10;
            this.txtPassword.IconRight = ((System.Drawing.Image)(resources.GetObject("txtPassword.IconRight")));
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(21, 373);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtPassword.Modified = false;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.RegEx = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(384, 35);
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtPassword.TabIndex = 77;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMarginLeft = 5;
            this.txtPassword.TextMarginTop = 0;
            this.txtPassword.TextPlaceholder = "";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.ValidatioErrorBorderColor = System.Drawing.Color.Tomato;
            this.txtPassword.ValidationFormat = Cars_dealer_V1._0_beta.Helper.CustomTextbox.ValidationType.Custom;
            this.txtPassword.ValidatioSuccessBorderColor = System.Drawing.Color.SeaGreen;
            // 
            // frmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(428, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmConnection";
            this.Shown += new System.EventHandler(this.FrmConnection_Shown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label11;
        private Helper.CustomTextbox txtUser;
        private System.Windows.Forms.Label label10;
        private Helper.CustomTextbox txtPort;
        private System.Windows.Forms.Label label9;
        private Helper.CustomTextbox txtDatabase;
        private System.Windows.Forms.Label label5;
        private Helper.CustomTextbox txtHost;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private System.Windows.Forms.Label label1;
        private Helper.CustomTextbox txtPassword;
    }
}