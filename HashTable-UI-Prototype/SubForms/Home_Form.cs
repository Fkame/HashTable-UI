using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashTable_UI_Prototype.SubForms
{
    public partial class Home_Form : Form, IFormWithHint
    {
        private string[] HINT_TEXT = { 
            "\t\tHello!",
            "\nThis is my HashTable mini visualisator.\n",
            "Some buttons now are not accepted because you need to download data to program.",
            "You can do this in next tab - Upload data.",
            "\nIf you dont understand what you see, please, click on this hint button - it will give you some info about current tab.",
            "\n~~~Close this window to continue~~~"
            };

        public Home_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        public static Color HIGHLIGHT_COLOR = Color.FromArgb(77,178,172);

        public string GetHintText()
        {
            return string.Join("\n", HINT_TEXT);
        }
    }
}
