using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashTable_UI_Prototype
{
    public partial class HashTableApp_Form : Form
    {
        public HashTableApp_Form()
        {
            InitializeComponent();
        }

        private Form mainForm = null;

        public HashTableApp_Form(Form mainForm) : this()
        {
            this.mainForm = mainForm;
        }

        /// <summary>
        /// Если закрывается вспомогательная форма - программа продолжнает работать, поэтому нужно закрыть и основную форму.
        /// </summary>
        /// <param name="sender">Указатель на объект, вызывавший событие.</param>
        /// <param name="e">Данные о событии.</param>
        private void HashTableApp_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mainForm.Close();
        }

        /// <summary>
        /// Закрытие формы при нажатии Escape.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HashTableApp_Form_KeyUp(object sender, KeyEventArgs e)
        {
            // Закрытие формы на клавишу Escape
            if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}
