namespace Cars_dealer_V1._0_beta.Pages
{
    partial class ReportsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsPage));
            this.lblDatesoldLabel = new System.Windows.Forms.Label();
            this.bunifuSeparator8 = new Bunifu.Framework.UI.BunifuSeparator();
            this.report1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.report2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.printer = new KimToo.EasyHTMLReports(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatesoldLabel
            // 
            this.lblDatesoldLabel.AutoSize = true;
            this.lblDatesoldLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatesoldLabel.ForeColor = System.Drawing.Color.Purple;
            this.lblDatesoldLabel.Location = new System.Drawing.Point(34, 29);
            this.lblDatesoldLabel.Name = "lblDatesoldLabel";
            this.lblDatesoldLabel.Size = new System.Drawing.Size(88, 17);
            this.lblDatesoldLabel.TabIndex = 98;
            this.lblDatesoldLabel.Text = "Daily Reports";
            // 
            // bunifuSeparator8
            // 
            this.bunifuSeparator8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator8.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator8.LineThickness = 1;
            this.bunifuSeparator8.Location = new System.Drawing.Point(25, 51);
            this.bunifuSeparator8.Name = "bunifuSeparator8";
            this.bunifuSeparator8.Size = new System.Drawing.Size(440, 16);
            this.bunifuSeparator8.TabIndex = 99;
            this.bunifuSeparator8.Transparency = 255;
            this.bunifuSeparator8.Vertical = false;
            // 
            // report1
            // 
            this.report1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.report1.color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.report1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.report1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.report1.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.report1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.report1.Image = ((System.Drawing.Image)(resources.GetObject("report1.Image")));
            this.report1.ImagePosition = 18;
            this.report1.ImageZoom = 40;
            this.report1.LabelPosition = 36;
            this.report1.LabelText = "Summary";
            this.report1.Location = new System.Drawing.Point(37, 85);
            this.report1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.report1.Name = "report1";
            this.report1.Size = new System.Drawing.Size(117, 110);
            this.report1.TabIndex = 100;
            this.report1.Click += new System.EventHandler(this.report1_Click);
            // 
            // report2
            // 
            this.report2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.report2.color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.report2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.report2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.report2.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.report2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.report2.Image = ((System.Drawing.Image)(resources.GetObject("report2.Image")));
            this.report2.ImagePosition = 18;
            this.report2.ImageZoom = 40;
            this.report2.LabelPosition = 36;
            this.report2.LabelText = "Summary";
            this.report2.Location = new System.Drawing.Point(37, 318);
            this.report2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.report2.Name = "report2";
            this.report2.Size = new System.Drawing.Size(117, 110);
            this.report2.TabIndex = 106;
            this.report2.Click += new System.EventHandler(this.report2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(34, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 104;
            this.label1.Text = "Monthly Reports";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(25, 284);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(440, 16);
            this.bunifuSeparator1.TabIndex = 105;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
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
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(749, 156);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(100, 50);
            this.logo.TabIndex = 112;
            this.logo.TabStop = false;
            this.logo.Visible = false;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(261, 31);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 113;
            // 
            // ReportsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.date);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.report2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.report1);
            this.Controls.Add(this.lblDatesoldLabel);
            this.Controls.Add(this.bunifuSeparator8);
            this.Name = "ReportsPage";
            this.Size = new System.Drawing.Size(964, 780);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatesoldLabel;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator8;
        private Bunifu.Framework.UI.BunifuTileButton report1;
        private Bunifu.Framework.UI.BunifuTileButton report2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private KimToo.EasyHTMLReports printer;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.DateTimePicker date;
    }
}
