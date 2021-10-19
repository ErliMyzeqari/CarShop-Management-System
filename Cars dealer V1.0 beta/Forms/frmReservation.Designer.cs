namespace Cars_dealer_V1._0_beta.Forms
{
    partial class frmReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservation));
            Bunifu.ToggleSwitch.ToggleState toggleState1 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState2 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState3 = new Bunifu.ToggleSwitch.ToggleState();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label19 = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDateReserved = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddReservation = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputNotes = new System.Windows.Forms.RichTextBox();
            this.chkSold = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            this.lblsold = new System.Windows.Forms.Label();
            this.txtSellingPrice = new Cars_dealer_V1._0_beta.Helper.CustomTextbox();
            this.lblDateSold = new System.Windows.Forms.Label();
            this.txtDateSold = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(828, 56);
            this.panel2.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(780, 6);
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
            this.lblTitle.Size = new System.Drawing.Size(159, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reserve Vehicle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(30, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Selling Price";
            // 
            // lblClient
            // 
            this.lblClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClient.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.lblClient.Location = new System.Drawing.Point(78, 94);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(290, 17);
            this.lblClient.TabIndex = 82;
            this.lblClient.Text = "txtname";
            this.lblClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblClient.Click += new System.EventHandler(this.LblClient_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(21, 114);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(347, 16);
            this.bunifuSeparator1.TabIndex = 81;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(30, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 17);
            this.label19.TabIndex = 80;
            this.label19.Text = "Client";
            // 
            // lblVehicle
            // 
            this.lblVehicle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle.ForeColor = System.Drawing.Color.DimGray;
            this.lblVehicle.Location = new System.Drawing.Point(487, 94);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(283, 17);
            this.lblVehicle.TabIndex = 85;
            this.lblVehicle.Text = "txtname";
            this.lblVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(420, 114);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(391, 16);
            this.bunifuSeparator2.TabIndex = 84;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(432, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Vehicle";
            // 
            // txtDateReserved
            // 
            this.txtDateReserved.Location = new System.Drawing.Point(33, 180);
            this.txtDateReserved.Name = "txtDateReserved";
            this.txtDateReserved.Size = new System.Drawing.Size(281, 20);
            this.txtDateReserved.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 87;
            this.label3.Text = "Date Reserved ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(432, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 89;
            this.label4.Text = "Due Date";
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(435, 180);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(272, 20);
            this.txtDueDate.TabIndex = 88;
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Active = false;
            this.btnAddReservation.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnAddReservation.BackColor = System.Drawing.Color.Purple;
            this.btnAddReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddReservation.BorderRadius = 0;
            this.btnAddReservation.ButtonText = "   Save";
            this.btnAddReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReservation.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddReservation.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddReservation.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddReservation.Iconimage")));
            this.btnAddReservation.Iconimage_right = null;
            this.btnAddReservation.Iconimage_right_Selected = null;
            this.btnAddReservation.Iconimage_Selected = null;
            this.btnAddReservation.IconMarginLeft = 0;
            this.btnAddReservation.IconMarginRight = 0;
            this.btnAddReservation.IconRightVisible = false;
            this.btnAddReservation.IconRightZoom = 0D;
            this.btnAddReservation.IconVisible = true;
            this.btnAddReservation.IconZoom = 38D;
            this.btnAddReservation.IsTab = false;
            this.btnAddReservation.Location = new System.Drawing.Point(697, 486);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnAddReservation.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.btnAddReservation.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddReservation.selected = false;
            this.btnAddReservation.Size = new System.Drawing.Size(114, 41);
            this.btnAddReservation.TabIndex = 92;
            this.btnAddReservation.Text = "   Save";
            this.btnAddReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddReservation.Textcolor = System.Drawing.Color.White;
            this.btnAddReservation.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddReservation.Click += new System.EventHandler(this.BtnAddReservation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputNotes);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(25, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 95);
            this.groupBox1.TabIndex = 93;
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
            this.inputNotes.Size = new System.Drawing.Size(772, 71);
            this.inputNotes.TabIndex = 80;
            this.inputNotes.Text = "";
            // 
            // chkSold
            // 
            this.chkSold.Animation = 5;
            this.chkSold.BackColor = System.Drawing.Color.Transparent;
            this.chkSold.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkSold.BackgroundImage")));
            this.chkSold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSold.Location = new System.Drawing.Point(431, 253);
            this.chkSold.Name = "chkSold";
            this.chkSold.Size = new System.Drawing.Size(35, 20);
            this.chkSold.TabIndex = 94;
            toggleState1.BackColor = System.Drawing.Color.Empty;
            toggleState1.BackColorInner = System.Drawing.Color.Empty;
            toggleState1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            toggleState1.BorderColorInner = System.Drawing.Color.Empty;
            toggleState1.BorderRadius = 1;
            toggleState1.BorderRadiusInner = 1;
            toggleState1.BorderThickness = 1;
            toggleState1.BorderThicknessInner = 1;
            this.chkSold.ToggleStateDisabled = toggleState1;
            toggleState2.BackColor = System.Drawing.Color.Gray;
            toggleState2.BackColorInner = System.Drawing.Color.White;
            toggleState2.BorderColor = System.Drawing.Color.Gray;
            toggleState2.BorderColorInner = System.Drawing.Color.White;
            toggleState2.BorderRadius = 17;
            toggleState2.BorderRadiusInner = 15;
            toggleState2.BorderThickness = 1;
            toggleState2.BorderThicknessInner = 1;
            this.chkSold.ToggleStateOff = toggleState2;
            toggleState3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            toggleState3.BackColorInner = System.Drawing.Color.White;
            toggleState3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            toggleState3.BorderColorInner = System.Drawing.Color.White;
            toggleState3.BorderRadius = 17;
            toggleState3.BorderRadiusInner = 15;
            toggleState3.BorderThickness = 1;
            toggleState3.BorderThicknessInner = 1;
            this.chkSold.ToggleStateOn = toggleState3;
            this.chkSold.Value = false;
            this.chkSold.OnValuechange += new System.EventHandler(this.ChkSold_OnValuechange);
            // 
            // lblsold
            // 
            this.lblsold.AutoSize = true;
            this.lblsold.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblsold.Location = new System.Drawing.Point(474, 254);
            this.lblsold.Name = "lblsold";
            this.lblsold.Size = new System.Drawing.Size(131, 17);
            this.lblsold.TabIndex = 95;
            this.lblsold.Text = "Mark Vehicle as Sold";
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.AcceptsReturn = false;
            this.txtSellingPrice.AcceptsTab = false;
            this.txtSellingPrice.AnimationSpeed = 220;
            this.txtSellingPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSellingPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSellingPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtSellingPrice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSellingPrice.BackgroundImage")));
            this.txtSellingPrice.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSellingPrice.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtSellingPrice.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSellingPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.txtSellingPrice.BorderRadius = 1;
            this.txtSellingPrice.BorderThickness = 1;
            this.txtSellingPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSellingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSellingPrice.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtSellingPrice.DefaultText = "";
            this.txtSellingPrice.FillColor = System.Drawing.Color.White;
            this.txtSellingPrice.HideSelection = true;
            this.txtSellingPrice.IconLeft = null;
            this.txtSellingPrice.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSellingPrice.IconPadding = 10;
            this.txtSellingPrice.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSellingPrice.IconRight")));
            this.txtSellingPrice.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSellingPrice.Lines = new string[0];
            this.txtSellingPrice.Location = new System.Drawing.Point(33, 254);
            this.txtSellingPrice.MaxLength = 32767;
            this.txtSellingPrice.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtSellingPrice.Modified = false;
            this.txtSellingPrice.Multiline = false;
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.PasswordChar = '\0';
            this.txtSellingPrice.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSellingPrice.PlaceholderText = "";
            this.txtSellingPrice.ReadOnly = false;
            this.txtSellingPrice.RegEx = "^\\d+\\.?\\d*$";
            this.txtSellingPrice.SelectedText = "";
            this.txtSellingPrice.SelectionLength = 0;
            this.txtSellingPrice.SelectionStart = 0;
            this.txtSellingPrice.ShortcutsEnabled = true;
            this.txtSellingPrice.Size = new System.Drawing.Size(281, 35);
            this.txtSellingPrice.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtSellingPrice.TabIndex = 53;
            this.txtSellingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSellingPrice.TextMarginLeft = 5;
            this.txtSellingPrice.TextMarginTop = 0;
            this.txtSellingPrice.TextPlaceholder = "";
            this.txtSellingPrice.UseSystemPasswordChar = false;
            this.txtSellingPrice.ValidatioErrorBorderColor = System.Drawing.Color.Tomato;
            this.txtSellingPrice.ValidationFormat = Cars_dealer_V1._0_beta.Helper.CustomTextbox.ValidationType.Decimal;
            this.txtSellingPrice.ValidatioSuccessBorderColor = System.Drawing.Color.SeaGreen;
            // 
            // lblDateSold
            // 
            this.lblDateSold.AutoSize = true;
            this.lblDateSold.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateSold.ForeColor = System.Drawing.Color.Black;
            this.lblDateSold.Location = new System.Drawing.Point(432, 296);
            this.lblDateSold.Name = "lblDateSold";
            this.lblDateSold.Size = new System.Drawing.Size(66, 17);
            this.lblDateSold.TabIndex = 97;
            this.lblDateSold.Text = "Date Sold";
            this.lblDateSold.Visible = false;
            // 
            // txtDateSold
            // 
            this.txtDateSold.Location = new System.Drawing.Point(435, 320);
            this.txtDateSold.Name = "txtDateSold";
            this.txtDateSold.Size = new System.Drawing.Size(272, 20);
            this.txtDateSold.TabIndex = 96;
            this.txtDateSold.Visible = false;
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(828, 540);
            this.Controls.Add(this.lblDateSold);
            this.Controls.Add(this.txtDateSold);
            this.Controls.Add(this.lblsold);
            this.Controls.Add(this.chkSold);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDueDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDateReserved);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtSellingPrice);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmReservation";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label5;
        private Helper.CustomTextbox txtSellingPrice;
        private System.Windows.Forms.Label lblClient;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblVehicle;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtDateReserved;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtDueDate;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddReservation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox inputNotes;
        private Bunifu.ToggleSwitch.BunifuToggleSwitch chkSold;
        private System.Windows.Forms.Label lblsold;
        private System.Windows.Forms.Label lblDateSold;
        private System.Windows.Forms.DateTimePicker txtDateSold;
    }
}