using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HashTable_UI_Prototype.SubForms;

namespace HashTable_UI_Prototype
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Указатель на первую запускаемую форму - экран приветствия
        /// </summary>
        private Form weclomeForm = null;

        public MainMenu(Form weclomeForm) : this()
        {
            this.weclomeForm = weclomeForm;
        }

        /// <summary>
        /// Список с ссылками на открытые мини-окна, которые нужно закрыть перед закрытием этой формы
        /// </summary>
        private List<Form> windows = new List<Form>();

        /// <summary>
        /// Какая форма в данный момент показывается.
        /// </summary>
        private Form activeNowForm;

        /// <summary>
        /// Окошко, которое выводит текст и объясняет содержимое той или иной формы. Представляет собой модульное окно с текстом.
        /// </summary>
        private Form helpWindow;

        /// <summary>
        /// Действия при загрузке формы.
        /// </summary>
        /// <param name="sender">Указатель на объект, вызывавший событие.</param>
        /// <param name="e">Данные о событии.</param>
        private void MainMenu_Load(object sender, EventArgs e)
        {
            Form home = new Home_Form();
            this.windows.Add(home);
            this.activeNowForm = home;
        }

        private void HighlightButtonOfActiveForm()
        {

        }

        /// <summary>
        /// Если закрывается вспомогательная форма - программа продолжнает работать, поэтому нужно закрыть и основную форму.
        /// </summary>
        /// <param name="sender">Указатель на объект, вызывавший событие.</param>
        /// <param name="e">Данные о событии.</param>
        private void HashTableApp_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.weclomeForm.Close();
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

        private void btn_Home_Click(object sender, EventArgs e)
        {
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
