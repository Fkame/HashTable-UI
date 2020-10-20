using System;
using System.Drawing;
using System.Windows.Forms;
using HashTable_UI_Prototype.SubForms;

namespace HashTable_UI_Prototype
{
    public partial class MainMenu
    {
        /// <summary>
        /// При вызове вызывает анимацию указателя на кнопку подсказки.
        /// </summary>
        private void HighLightingOfHelpButton()
        {
            if (Animation_of_btn_HelpPointer.Enabled) return;

            btn_HelpPointer.Visible = true;

            timeOfPlaying = 1000;
            XDifference = btn_HelpPointer.Width / 6;
            originalX = btn_HelpPointer.Location.X;

            Animation_of_btn_HelpPointer.Interval = 20;
            Animation_of_btn_HelpPointer.Start();
        }

        /// <summary>
        /// Флаг-переменная для анимации. Сообщает направление движения по оси ОХ.
        /// </summary>
        private bool isGrow = true;

        /// <summary>
        /// Указывает на время, которое должна продолжаться анимация.
        /// </summary>
        private int timeOfPlaying;

        /// <summary>
        /// Указывает на то, на какое максимальное расстояние может сдвинуться указатель по оси ОХ.
        /// </summary>
        private int XDifference;

        /// <summary>
        /// Хранит начальное положение указателя перед началом анимации..
        /// </summary>
        private int originalX;

        /// <summary>
        /// Реализация анимации кнопки и её последующее выключение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Animation_of_btn_HelpPointer_Tick(object sender, EventArgs e)
        {
            if (timeOfPlaying <= 0)
            {
                btn_HelpPointer.Visible = false;
                Animation_of_btn_HelpPointer.Stop();
                btn_HelpPointer.Location = new Point(originalX, btn_HelpPointer.Location.Y);
                return;
            }

            Point nowLoc = btn_HelpPointer.Location;

            if (isGrow)
            {
                nowLoc.X += 1;

                if (btn_HelpPointer.Location.X - originalX == XDifference)
                    isGrow = false;
            }
            else
            {
                nowLoc.X -= 1;

                if (originalX == btn_HelpPointer.Location.X)
                    isGrow = true;
            }

            btn_HelpPointer.Location = nowLoc;
            timeOfPlaying -= Animation_of_btn_HelpPointer.Interval;
        }

        /// <summary>
        /// Нажатие на кнопку вызова подсказки для текущего окна.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Help_Click(object sender, EventArgs e)
        {
            IFormWithHint form = null;
            try
            {
                form = (IFormWithHint)activeForm;
                string hint = form.GetHintText();
                Form hintForm = new HintForm(hint);
                hintForm.ShowDialog();
            } 
            catch (Exception ex)
            {
                return;
            }
        }

    }
}
