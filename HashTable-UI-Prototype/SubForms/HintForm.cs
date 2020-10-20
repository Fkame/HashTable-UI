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
    /// <summary>
    /// Класс, реализующий маленькое модальное окно, которое должно выводить подсказки к дочерним формам.
    /// </summary>
    public partial class HintForm : Form
    {
        public HintForm(string hint)
        {
            InitializeComponent();
            this.HindTextBox.Text = hint;
        }
    }
}
