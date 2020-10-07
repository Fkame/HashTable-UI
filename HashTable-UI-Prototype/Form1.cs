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
    public partial class Welcome_Form : Form
    {
        public Welcome_Form()
        {
            InitializeComponent();

            // Начальные конфигурации
            this.preStartConfigureations();
        }

        /// <summary>
        /// Цвет, в который должна окраситься в итоге фраза посередине экрана.
        /// </summary>
        private (int R, int G, int B) GAINSBORO_IN_RGB = (220, 220, 220);

        /// <summary>
        /// Задержка перед началом появления текста.
        /// </summary>
        private int PauseBeforeStart = 1000;

        /// <summary>
        /// Меняющийся со временем коэфициент, увеличивающий скорость изменения цвета текста.
        /// Когда текст уже слегка виден его дальнейшее изменение становится менее заметно глазу и кажется, будто
        /// скорость его проявления упала. Эту проблему решает этот коэффициент и коэфициент сдерживания, который описан далее.
        /// </summary>
        private int speedOfRising = 0;

        /// <summary>
        /// Второй коэфициент для системы увеличения скорости проявления текста. Чтобы не исчислять скорость
        /// вещественными числами, я разделил его на: скорось роста и сдерживающий рост фактор.
        /// </summary>
        private const int RESISTANCE_OF_SPEED_RISING = 10;

        /// <summary>
        /// Частота срабатывания таймера в миллисекундах. Прсото вынес, чтобы не было "магических чисел" в коде.
        /// </summary>
        private const int TIMER_INTERVAL = 20;

        /// <summary>
        /// Некоторые начальные конфигурации: запуск таймера, начальный цвет фразы и т.д.
        /// </summary>
        private void preStartConfigureations()
        {
            // Подготовка начальной фразы - она невидима, но насыщается цветом по таймеру
            this.WelcomeText_Label.ForeColor = Welcome_panel.BackColor;
            timer1.Interval = TIMER_INTERVAL;
            timer1.Start();
        }

        /// <summary>
        /// Выход из формы. Закрытие программы по нажатию клавиши Escape
        /// </summary>
        /// <param name="sender">Указатель на объект, вызывавший событие</param>
        /// <param name="e">Данные для событий KeyUp и KeyDown. Хранит информацию о нажатой кнопке или типа того.</param>
        private void Welcome_Form_KeyUp(object sender, KeyEventArgs e)
        {
            // Закрытие формы на клавишу Escape
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        /// <summary>
        /// Таймер по которому происходит постепенное проявление фразы - изменение от цвета формы к
        /// финальному цвету GAINSBORO_IN_RGB.
        /// </summary>
        /// <param name="sender">Указатель на объект, вызывавший событие</param>
        /// <param name="e">Представляет базовый класс для классов, содержащих данные событий, 
        /// и предоставляет значение для событий, не содержащих данных.</param>
        private void timer1_Tick(object sender, EventArgs e)
        {  
            // Начальная задержка перед появлением фразы
            if (PauseBeforeStart > 0)
            {
                PauseBeforeStart -= timer1.Interval;
                return;
            }

            Color preColor = WelcomeText_Label.ForeColor;
            int r = preColor.R;
            int g = preColor.G;
            int b = preColor.B;

            // Хочется, чтобы наращивание цвета ускорялось со временем
            r += 1 + speedOfRising / RESISTANCE_OF_SPEED_RISING;
            r = (r > GAINSBORO_IN_RGB.R) ? GAINSBORO_IN_RGB.R : r;
            g += 1 + speedOfRising / RESISTANCE_OF_SPEED_RISING;
            g = (g > GAINSBORO_IN_RGB.G) ? GAINSBORO_IN_RGB.G : g;
            b += 1 + speedOfRising / RESISTANCE_OF_SPEED_RISING;
            b = (b > GAINSBORO_IN_RGB.B) ? GAINSBORO_IN_RGB.B : b;

            Color newColor = Color.FromArgb(r, g, b);
            if (newColor.Equals(preColor))
                timer1.Stop();
            else
                WelcomeText_Label.ForeColor = newColor;

            speedOfRising++;
        }

        #region Перемещение формы при нажатии на неё
        /// <summary>
        /// Переменная, указывающая на то, находится ли в данный момент левая кнопка мыши зажатой.
        /// </summary>
        private bool isMouseClicked = false;

        /// <summary>
        /// Координаты мыши до начала перемещения. Нужны для облегченного измерения сдвига.
        /// </summary>
        private (int X, int Y) coordsBeforeMove = (X: 0, Y: 0);

        private void WelcomeText_Label_MouseMove(object sender, MouseEventArgs e)
        {
            if (!this.isMouseClicked) return;

            int changeOX = e.X - coordsBeforeMove.X;
            int changeOY = e.Y - coordsBeforeMove.Y;

            Point windowPosition = this.Location;
            windowPosition.X = windowPosition.X + changeOX;
            windowPosition.Y = windowPosition.Y + changeOY;

            this.Location = windowPosition;
        }

        private void WelcomeText_Label_MouseUp(object sender, MouseEventArgs e)
        {
            this.isMouseClicked = false;
        }

        private void WelcomeText_Label_MouseDown(object sender, MouseEventArgs e)
        {
            this.isMouseClicked = true;
            this.coordsBeforeMove.X = e.X;
            this.coordsBeforeMove.Y = e.Y;
        }
        #endregion
    }
}
