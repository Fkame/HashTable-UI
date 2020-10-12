﻿using System;
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
            SetInitialValues();
        }

        /// <summary>
        /// Инициализация начальных данных в элементах
        /// </summary>
        private void SetInitialValues()
        {
            var data = GetAndSetStatistic();
            DrawVisualisation(data);
            DrawHistogram(data);
        }

        private const int AMOUNT_OF_CELLS_IN_WIDTH = 6;
        private const int PERCENT_OF_BORDERS_IN_CELL = 10;
        private const float RATIO_OF_WIDTH_TO_HEIGHT_OF_CELL = 3f / 4;

        private Color redColorOfCell = Color.FromArgb(149, 53, 53);
        private Color greenColorOfCell = Color.FromArgb(116, 185, 73);
        private Color greyColorOfCell = Color.FromArgb(196, 196, 196);

        private void DrawVisualisation((int full, int notRe, int re) data)
        {
            Graphics g;

            int amountOfRowsInPicture = 0;
            if (data.full % AMOUNT_OF_CELLS_IN_WIDTH == 0)
            {
                amountOfRowsInPicture = data.full / AMOUNT_OF_CELLS_IN_WIDTH;
            }
            else
            {
                amountOfRowsInPicture = data.full / AMOUNT_OF_CELLS_IN_WIDTH + 1;
            }

            int nowPictureBoxWidth = VisualCells_PB.Width;
            int cellWidth = nowPictureBoxWidth / AMOUNT_OF_CELLS_IN_WIDTH;
            int cellHeight = (int)(cellWidth / RATIO_OF_WIDTH_TO_HEIGHT_OF_CELL);
            int calcPictureBoxHeight = cellHeight * amountOfRowsInPicture;

            int cellBodyWidth = (int)(cellWidth * ((100.0 - PERCENT_OF_BORDERS_IN_CELL) / 100.0));
            int cellBodyHeight = (int)(cellHeight * ((100.0 - PERCENT_OF_BORDERS_IN_CELL) / 100.0));

            // Создание изображения и получение способа рисования
            VisualCells_PB.Image = new Bitmap(nowPictureBoxWidth, calcPictureBoxHeight);
            g = Graphics.FromImage(VisualCells_PB.Image);

            // Отрисовка - стоит сделать многопоточной
            Brush red_pen = new SolidBrush(redColorOfCell);
            Brush green_pen = new SolidBrush(greenColorOfCell);
            Brush grey_pen = new SolidBrush(greyColorOfCell);

            Brush toDraw = null;
            string[] values = parentForm.HashTable.GetFullHashTableAsArray();
            
            int count = 0;
            for (int y = 0; y < amountOfRowsInPicture; y++) 
            {
                for (int x = 0; x < AMOUNT_OF_CELLS_IN_WIDTH; x++)
                {
                    if (values[count].Equals(string.Empty))
                    {
                        toDraw = grey_pen;
                    }
                    else if (parentForm.HashTable.IsValueStoredAsRehash(values[count]))
                    {
                        toDraw = red_pen;
                    }
                    else
                    {
                        toDraw = green_pen;
                    }

                    // Берётся координата от прямоугольника с учётом границ и делается сдвиг к его центру
                    int xCoord = x * cellWidth + (cellWidth - cellBodyWidth) / 2;
                    int yCoord = y * cellHeight + (cellHeight - cellBodyHeight) / 2; ;
                    g.FillRectangle(toDraw, xCoord, yCoord, cellBodyWidth, cellBodyHeight);

                    if (++count == values.Length) break;
                }

                if (count == values.Length) break;
                VisualCells_PB.Refresh();
            }
        }

        private void DrawHistogram((int full, int notRe, int re) data)
        {

        }

        private (int FullAmount, int NotReashed, int Rehashed) GetAndSetStatistic()
        {
            // Поле текста
            StringBuilder text = new StringBuilder("- - - Here will be statistic of searching - - -\n");

            // Amount of identificators
            text.Append("Amount of identificators = ");
            text.Append(parentForm.HashTable.HashTableFullness);
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
            int rehashCount = parentForm.HashTable.GetAmountOfRehashedValues();
            text.Append("Amount of collisions = ");
            text.Append(rehashCount);
            text.Append(" [Red]\n");

            // max rehash value
            text.Append("Maximum rehash level = ");
            text.Append(parentForm.HashTable.GetMaxRehashLevel());
            text.Append("\n");

            // Amount of Empty
            text.Append("Amount of Empty = ");
            string[] allValues = parentForm.HashTable.GetFullHashTableAsArray();
            int emptyCount = allValues.Length - values.Length;
            text.Append(emptyCount);
            text.Append(" [Grey]\n");

            // Amount of not rehashed values
            int notRehashCount = parentForm.HashTable.GetAmountOfNotRehashedValues();
            text.Append("Amount of not rehashed values = ");
            text.Append(notRehashCount);
            text.Append(" [Green]\n");

            Statistic.Text = text.ToString();

            int fullCount = emptyCount + rehashCount + notRehashCount;
            return (fullCount, notRehashCount, rehashCount);
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
            //DrawBorderToElement(VisualCells_PB, 5, g, SearchForm.HIGHLIGHT_COLOR);
            DrawBorderToElement(Gistogram_Panel, 5, g, SearchForm.HIGHLIGHT_COLOR);
        }

        #endregion

    }
}