using System;
using System.Drawing;
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
        /// Стандартный цвет для невыделенного элемента.
        /// </summary>
        private static Color NOT_SELECTED_BUTTON_COLOR = Color.FromArgb(48, 47, 79);

        /// <summary>
        /// Переменная используется для того, чтобы свернуть или закрыть предыдущую форму.
        /// </summary>
        private Form activeForm;

        /// <summary>
        /// Ссылка на вложенную форму вкладки "Home"
        /// </summary>
        private Home_Form homeForm;

        /// <summary>
        /// Ссылка на вложенную форму вкладки "Upload data"
        /// </summary>
        private UploadData_Form uploadDataForm;

        /// <summary>
        /// Действия при загрузке формы:
        /// 1. Нужно создать "домашнюю" форму и поместить её на панель.
        /// 2. Нужно перекрасить в соответствующие цвета кнопку и заголовок.
        /// 3. Нужно скрыть до загрузки данных 3 последние кнопки
        /// </summary>
        /// <param name="sender">Указатель на объект, вызывавший событие.</param>
        /// <param name="e">Данные о событии.</param>
        private void MainMenu_Load(object sender, EventArgs e)
        {
            homeForm = new Home_Form();
            btn_Home.BackColor = Home_Form.HIGHLIGHT_COLOR;
            Header_Panel.BackColor = Home_Form.HIGHLIGHT_COLOR;

            activeForm = homeForm;
            this.DoFillActiveInPanelStaff();

            BlockMainButtons();
        }

        public void BlockMainButtons()
        {
            btn_Searching.Enabled = false;
            btn_Visualisation.Enabled = false;
            btn_StoredData.Enabled = false;
        }

        public void UnlockMainButtons()
        {
            btn_Searching.Enabled = true;
            btn_Visualisation.Enabled = true;
            btn_StoredData.Enabled = true;
        }

        /// <summary>
        /// Метод, который открывает активную форму в мини-окне панели
        /// </summary>
        private void DoFillActiveInPanelStaff()
        {
            activeForm.TopLevel = false;
            activeForm.Dock = DockStyle.Fill;
            ChildForm_Panel.Controls.Add(activeForm);
            ChildForm_Panel.Tag = activeForm;
            activeForm.BringToFront();
            activeForm.Show();
        }
  

        #region Кнопки закрытия и событие закрытия формы

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Exit_MouseDown(object sender, MouseEventArgs e)
        {
            Size preS = this.btn_Exit.Size;
            Point preL = this.btn_Exit.Location;

            preS.Width -= 10;
            preS.Height -= 10;

            preL.X += 5;
            preL.Y += 5;

            this.btn_Exit.Size = preS;
            this.btn_Exit.Location = preL;
        }

        private void btn_Exit_MouseUp(object sender, MouseEventArgs e)
        {
            Size preS = this.btn_Exit.Size;
            Point preL = this.btn_Exit.Location;

            preS.Width += 10;
            preS.Height += 10;

            preL.X -= 5;
            preL.Y -= 5;

            this.btn_Exit.Size = preS;
            this.btn_Exit.Location = preL;
        }

        /// <summary>
        /// Если закрывается вспомогательная форма - программа продолжнает работать, поэтому нужно закрыть и основную форму.
        /// </summary>
        /// <param name="sender">Указатель на объект, вызывавший событие.</param>
        /// <param name="e">Данные о событии.</param>
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (homeForm != null) homeForm.Close();
            // ...

            this.weclomeForm.Close();
        }

        #endregion

        #region Перемещение окна

        /// <summary>
        /// Переменная, указывающая на то, находится ли в данный момент левая кнопка мыши зажатой.
        /// </summary>
        private bool isMouseClicked = false;

        /// <summary>
        /// Координаты мыши до начала перемещения. Нужны для облегченного измерения сдвига.
        /// </summary>
        private (int X, int Y) coordsBeforeMove = (X: 0, Y: 0);

        private void Header_Panel_MouseUp(object sender, MouseEventArgs e)
        {
            this.isMouseClicked = false;
        }

        private void Header_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!this.isMouseClicked) return;

            int changeOX = e.X - coordsBeforeMove.X;
            int changeOY = e.Y - coordsBeforeMove.Y;

            Point windowPosition = this.Location;
            windowPosition.X = windowPosition.X + changeOX;
            windowPosition.Y = windowPosition.Y + changeOY;

            this.Location = windowPosition;
        }

        private void Header_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            this.isMouseClicked = true;
            this.coordsBeforeMove.X = e.X;
            this.coordsBeforeMove.Y = e.Y;
        }


        #endregion

    }
}
