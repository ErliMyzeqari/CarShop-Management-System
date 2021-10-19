using System;
using System.Collections.Generic;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_dealer_V1._0_beta.Helper
{
    public class CustomTextbox : Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    {
        public static bool ValidateContainer(Control container,bool ChildContaiers = true)
        {
            if (ChildContaiers)
            {
                foreach (var item in container.Controls.OfType<Panel>().ToList())
                {
                    if (!ValidateContainer(item))
                    {
                        return false;
                    }
                }

                foreach (var item in container.Controls.OfType<GroupBox>().ToList())
                {
                    if (!ValidateContainer(item))
                    {
                        return false;
                    }
                } 
            }

            foreach (var item in container.Controls.OfType<CustomTextbox>().ToList())
            {
                if ( !item.Validate())
                {
                    return false;
                }
            }
            return true;
        }


        public enum ValidationType
        {
            Custom,
            NotEmpty,
            Email,
            Year,
            Integer,
            Phone,
            Decimal

        }

        List<string> RegList = new List<string>() {
            "",
            "^(?!\\s*$).+",
            "(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])",
            "^\\d{4}$",
            "^[0-9]*$",
            "^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\\s\\./0-9]*$",
           "^\\d+\\.?\\d*$"
        };

        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ImageList imageList2;
        string regx = string.Empty;
        ValidationType _ValidationFormat = ValidationType.NotEmpty;
        public ValidationType ValidationFormat
        {
            get
            {
                return _ValidationFormat;
            }
            set
            {
                _ValidationFormat = value;
                if ((int)value > 0)
                {
                    RegEx = RegList[(int)value];
                }
            }
        }
        bool added = false;
        public string RegEx
        {
            get
            {
                return regx;
            }
            set
            {
                regx = value;
                if (!added)
                {
                    InitializeComponent();
                    this.TextChanged += CustomTextbox_TextChanged;
                    CustomTextbox_TextChanged(this, new EventArgs());
                    added = true;
                }
            }
        }



        private void CustomTextbox_TextChanged(object sender, EventArgs e)
        {
            if(!this.Enabled)
            {
                this.IconRight = null;
                return;
            }

            var r = RunRegex();
            if (r)
            {
                this.IconRight = imageList2.Images[0];
            }

            else
            {
                if (this.ValidationFormat == ValidationType.Custom && RegEx.Trim().Length == 0)
                {
                    this.IconRight = null;
                }
                else
                {
                    this.IconRight = imageList2.Images[1];
                }



            }
        }

        public Color ValidatioErrorBorderColor { get; set; } = Color.Tomato;

        public Color ValidatioSuccessBorderColor { get; set; } = Color.SeaGreen;


        bool RunRegex()
        {
            var match = Regex.Match(this.Text, this.RegEx, RegexOptions.IgnoreCase);
            return match.Success;
        }

        public bool Validate()
        {
            if (!this.Enabled) return true;
            if (!this.Visible) return true;

            return RunRegex();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomTextbox));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "checkmark_64px.png");
            this.imageList2.Images.SetKeyName(1, "attention_30px.png");
            // 
            // CustomTextbox
            // 
            this.Lines = new string[0];
            this.Name = "CustomTextbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
