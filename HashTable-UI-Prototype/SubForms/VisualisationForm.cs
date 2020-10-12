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
    public partial class VisualisationForm : Form
    {
        public static Color HIGHLIGHT_COLOR = Color.FromArgb(191, 182, 48);

        private MainMenu parentForm;

        public VisualisationForm(MainMenu parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void VisualisationForm_Shown(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Инициализация начальных данных в элементах
        /// </summary>
        private void SetInitialValues()
        {
            // Поля текста
            StringBuilder text = new StringBuilder("- - - Here will be statistic of searching - - -\n");


            // Amount of identificators
            text.Append("Amount of identificators");
            text.Append(parentForm.HashTable.HashMapSize);
            text.Append("\n");

            // Max len
            text.Append("Maximum lenght = ");
            string[] values = parentForm.HashTable.GetOnlyNotNullValues();

            int maxL = values[0].Length;
            foreach (string value in values)
            {
                maxL = value.Length > maxL ? value.Length : maxL;
            }

            text.Append(maxL);
            text.Append("\n");

            // Amount of collisions
            text.Append("Amount of collisions = ");
            text.Append("\n");

            // Amount of Empty
            text.Append("Amount of Empty = ");
            string[] allValues = parentForm.HashTable.GetFullHashTableAsArray();
            text.Append(allValues.Length - values.Length);
            text.Append("[Grey]\n");

            // Amount of fill
            text.Append("Amount of fill = ");
            text.Append("\n");

            Statistic.Text = text.ToString();
        }

        #region Обводка границ вокруг элемента

        private void DrawBorderToElement(Control box, int borderWidth, Graphics g, Color color)
        {
            Rectangle field = new Rectangle(
                box.Location.X - borderWidth,
                box.Location.Y - borderWidth,
                box.Width + borderWidth * 2,
                box.Height + borderWidth * 2
                );

            ControlPaint.DrawBorder(
                g, field,
                color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Обводки границ элементов
            DrawBorderToElement(Statistic, 5, g, SearchForm.HIGHLIGHT_COLOR);
            DrawBorderToElement(VisualCells_PB, 5, g, SearchForm.HIGHLIGHT_COLOR);
            DrawBorderToElement(Gistogram_Panel, 5, g, SearchForm.HIGHLIGHT_COLOR);
        }

        #endregion

    }
}
