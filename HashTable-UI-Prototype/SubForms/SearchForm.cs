using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HashTable_UI_Prototype.SubForms
{
    public partial class SearchForm : Form
    {
        public static Color HIGHLIGHT_COLOR = Color.FromArgb(31, 125, 99);

        private MainMenu parentForm;

        public SearchForm(MainMenu parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        public bool NeedToUpdateDataBeforeShowing { get; set; } = true;

        #region Инициализация начальных значений

        /// <summary>
        /// Инициализация начальных данных в элементах
        /// </summary>
        private void SetInitialValues()
        {
            // Поля текста
            FillIdentificatorsList();
            Statistic.Text = "- - - Here will be statistic of searching - - -\n";
        }

        private void FillIdentificatorsList()
        {
            Identificators.Text = "- - - Identificators - - -\n";

            string[] values = parentForm.HashTable.GetOnlyNotNullValues();
            string valuesInLine = String.Join("\n", values);

            Identificators.Text += "[Full amount = " + values.Length.ToString() + "]";

            Identificators.Text += valuesInLine;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            //SetInitialValues();
        }

        #endregion

        #region Анимация при наведении на кнопку

        private const int COMPRESSION_FONT_VALUE = 1;
        private Color originalColor;
        private Color onMouseEnterColor = Color.DimGray;

        private void btn_Search_MouseEnter(object sender, EventArgs e)
        {
            originalColor = btn_Search.ForeColor;
            btn_Search.ForeColor = onMouseEnterColor;

            Font f = btn_Search.Font;
            btn_Search.Font = new Font(f.FontFamily, f.Size + COMPRESSION_FONT_VALUE, f.Style);
        }

        private void btn_Search_MouseLeave(object sender, EventArgs e)
        {
            btn_Search.ForeColor = originalColor;

            Font f = btn_Search.Font;
            btn_Search.Font = new Font(f.FontFamily, f.Size - COMPRESSION_FONT_VALUE, f.Style);
        }

        #endregion

        private void btn_Search_Click(object sender, EventArgs e)
        {
            StringBuilder analysis = new StringBuilder("- - - Statistic - - -\n");
            string value = EnterIdentificator_TB.Text.Trim(' ');

            // Найдено ли слово
            analysis.Append("Result = ");
            if (!parentForm.HashTable.IsExists(value)) 
                analysis.Append("not founded\n");
            else 
                analysis.Append("found\n");

            // Длина слова
            analysis.Append("Length of word = ");
            analysis.Append(value.Length);
            analysis.Append("\n");

            // Хэш
            analysis.Append("Hash of word = ");
            analysis.Append(parentForm.HashTable.GetHash(value));
            analysis.Append("\n");

            // Типы хэшей
            analysis.Append("Type of hash fuction = ");
            analysis.Append(parentForm.HashTable.HashFunc.ToString());
            analysis.Append("\nType of rehash fuction = ");
            analysis.Append(parentForm.HashTable.ReHashFunc.ToString());
            analysis.Append("\n");

            // Является ли значение рэхешем
            bool isRehash = parentForm.HashTable.IsValueStoredAsRehash(value);

            analysis.Append("Is rehashed = "); 
            analysis.Append(isRehash);
            analysis.Append("\n");

            // Количество рэхешей для записи слова
            analysis.Append("Amount of rehashes = ");
            analysis.Append(parentForm.HashTable.GetRehashLevel(value));
            analysis.Append("\n");

            // Время, затраченное на поиск слова
            Stopwatch time = Stopwatch.StartNew();
            parentForm.HashTable.IsExists(value);
            time.Stop();
            double timeInMs = time.Elapsed.TotalMilliseconds;

            analysis.Append("TimeOfSearching = ");
            analysis.Append(timeInMs);
            analysis.Append("\n");

            Statistic.Text = analysis.ToString();
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
            DrawBorderToElement(Identificators, 5, g, SearchForm.HIGHLIGHT_COLOR);
            DrawBorderToElement(Statistic, 5, g, SearchForm.HIGHLIGHT_COLOR);
            DrawBorderToElement(EnterIdentificator_TB, 2, g, Color.DimGray);
        }

        #endregion

        #region Горячие клавиши при нажатии на поле ввода
        private void EnterIdentificator_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.A))
            {
                EnterIdentificator_TB.SelectAll();
                //убираем звуковое сопровождение при нажатии клавиш
                e.Handled = e.SuppressKeyPress = true;
            }

            if (e.KeyData == Keys.Enter)
            {
                btn_Search_Click(null, EventArgs.Empty);
            }
        }

        private void EnterIdentificator_TB_DoubleClick(object sender, EventArgs e)
        {
            EnterIdentificator_TB.SelectAll();
        }

        #endregion

        private void SearchForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false) return;
            if (NeedToUpdateDataBeforeShowing == true)
                SetInitialValues();
        }
    }
}
