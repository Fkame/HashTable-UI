using System;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;

using HashTableApp.HashTableStructure;
using HashTableApp.HashTableStructure.HashFunctions;
using HashTableApp.HashTableStructure.ReHashFunctions;

namespace HashTable_UI_Prototype.SubForms
{
    public partial class UploadData_Form : Form
    {
        public static Color HIGHLIGHT_COLOR = Color.FromArgb(161, 40, 95);

        private String initialListOfIdentificatorsText = "- - - Here will be list of identificators from file - - -";
        private String initialStatysticText = "- - - Here will be statystic of reading file - - -";
        private String initialFileNameText = "File name";
        private String initialSeparatorFieldText = "Enter separator";

        private String initialChooseHash_CB_Text = "Choose hash-type here";
        private String initialChooseRehash_CB_Text = "Choose rehash-type here";

        private const int EDGE_VALUE = 500;
        private const int STEP_VALUE = 3;
        private String[] hashes = { "Simple adaption hash", "Simple division hash" };
        private String[] rehashes = { "On multiplication based", "On random based" };

        private MainMenu parentForm;

        public UploadData_Form(MainMenu parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        /// <summary>
        /// Инициализация начальных данных в элементах
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UploadData_Form_Load(object sender, EventArgs e)
        {
            SetInitialValues();
        }

        /// <summary>
        /// Инициализация начальных данных в элементах
        /// </summary>
        private void SetInitialValues()
        {
            // Поля текста
            ListOfIdentificators.Text = initialListOfIdentificatorsText;
            Statistic.Text = initialStatysticText;
            FileName_TextBox.Text = initialFileNameText;
            EnterSeparator_TextBox.Text = initialSeparatorFieldText;

            // Списки
            ChooseHash_CB.Text = initialChooseHash_CB_Text;
            ChooseRehash_CB.Text = initialChooseRehash_CB_Text;
            ChooseHash_CB.Items.AddRange(hashes);
            ChooseRehash_CB.Items.AddRange(rehashes);

            // Некоторые состояния
            needToRecreateHashFunction = false;

            UnlockHashFields();
        }

        public void BlockHashFields()
        {
            ChooseHash_CB.Enabled = false;
            ChooseRehash_CB.Enabled = false;
        }

        public void UnlockHashFields ()
        {
            ChooseHash_CB.Enabled = true;
            ChooseRehash_CB.Enabled = true;
        }

        /// <summary>
        /// Нажатие на кнопку Refresh. Происходит сборс введённых данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Refresh_PB_Click(object sender, EventArgs e)
        {
            SetInitialValues();
            parentForm.BlockMainButtons();
        }

        #region Отключение возможности редактирования поля ввода в Combobox

        private void ChooseHash_CB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ChooseRehash_CB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion

        #region Отрисовка границ вокруг элементов
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Обводки границ элементов
            DrawBorderToElement(ListOfIdentificators, 5, g, UploadData_Form.HIGHLIGHT_COLOR);
            DrawBorderToElement(Statistic, 5, g, UploadData_Form.HIGHLIGHT_COLOR);
            DrawBorderToElement(FileName_TextBox, 2, g, Color.DimGray);
            DrawBorderToElement(ChooseHash_CB, 5, g, UploadData_Form.HIGHLIGHT_COLOR);
            DrawBorderToElement(ChooseRehash_CB, 5, g, UploadData_Form.HIGHLIGHT_COLOR);
            DrawBorderToElement(EnterSeparator_TextBox, 2, g, UploadData_Form.HIGHLIGHT_COLOR);
        }

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

        #endregion

        #region Чтение файла и заполнение полей идентификаторов и анализа

        private bool needToRecreateHashFunction = false;

        private void btn_LoadFile_Click(object sender, EventArgs e)
        {
            Stopwatch timeOfReading = null;

            var fileContent = string.Empty;
            var filePath = string.Empty;

            // Чтение из файла
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    timeOfReading = Stopwatch.StartNew();
                    filePath = openFileDialog.FileName;
                    fileContent = System.IO.File.ReadAllText(filePath);
                }
                else
                {
                    return;
                }
            }

            timeOfReading.Stop();
            double timeOfReadingInMs = timeOfReading.Elapsed.TotalMilliseconds;

            // Чтение разделителя
            char separator = '\n';
            if (EnterSeparator_TextBox.Text.Length == 1) separator = EnterSeparator_TextBox.Text[0];

            Stopwatch timeOfAnalysis = Stopwatch.StartNew();

            // Получение обработанных текстов
            string listOFIdentificators = ScanningAndAdaptingText(fileContent, separator);
            string statistic = TextAnalyzer(listOFIdentificators, '\n');

            double timeOfAnalysisInMs = timeOfAnalysis.Elapsed.TotalMilliseconds;

            // Добавление значений времени в строку анализа
            StringBuilder tempStatistic = new StringBuilder(statistic);
            tempStatistic.Append("\nTime of reading = ").Append(timeOfReadingInMs).Append(" ms");
            tempStatistic.Append("\nTime of analysis = ").Append(timeOfAnalysisInMs).Append(" ms");

            // Вывод данных
            ListOfIdentificators.Text = "- - - List of identificators - - -\n" + listOFIdentificators;
            Statistic.Text = "- - - List of statistic - - -\n" + tempStatistic.ToString();
            FileName_TextBox.Text = filePath;

            parentForm.UnlockMainButtons();
            needToRecreateHashFunction = true;
        }

        /// <summary>
        /// Разбивает сплошной текст на части по указанному разделителю, убирает лишние символы, а потом соединяет все части своим разделителем.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private string ScanningAndAdaptingText(string text, char separator)
        {
            string[] lines = text.Split(separator);
            char[] trimChars = { ' ' };

            StringBuilder rez = new StringBuilder();
            foreach (string line in lines)
            {
                rez.Append(line.Trim(trimChars));
                rez.Append('\n');
            }

            return rez.ToString();
        }

        /// <summary>
        /// Анализирует текст на указанные в методе характеристики
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private string TextAnalyzer(string text, char separator)
        {
            StringBuilder resultLine = new StringBuilder();
            string[] lines = text.Split(separator);

            resultLine.Append("Amount of identificator = ").Append(lines.Length).Append("\n");

            int maxLen = lines[0].Length;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Length > maxLen) 
                    maxLen = lines[i].Length;
            }
            resultLine.Append("Maximum length of word = ").Append(maxLen);

            return resultLine.ToString();
        }

        #endregion

        #region Анимация при наведении на кнопку

        private const int COMPRESSION_FONT_VALUE = 1;
        private Color originalColor;
        private Color onMouseEnterColor = Color.DimGray;

        private void btn_LoadFile_MouseEnter(object sender, EventArgs e)
        {
            originalColor = btn_LoadFile.ForeColor;
            btn_LoadFile.ForeColor = onMouseEnterColor;

            Font f = btn_LoadFile.Font;
            btn_LoadFile.Font = new Font(f.FontFamily, f.Size + COMPRESSION_FONT_VALUE, f.Style);
        }

        private void btn_LoadFile_MouseLeave(object sender, EventArgs e)
        {
            btn_LoadFile.ForeColor = originalColor;

            Font f = btn_LoadFile.Font;
            btn_LoadFile.Font = new Font(f.FontFamily, f.Size - COMPRESSION_FONT_VALUE, f.Style);
        }

        #endregion

        #region Анимация при наведении на иконку

        private void Refresh_PB_MouseEnter(object sender, EventArgs e)
        {
            Size preS = this.Refresh_PB.Size;
            Point preL = this.Refresh_PB.Location;

            preS.Width -= 10;
            preS.Height -= 10;

            preL.X += 5;
            preL.Y += 5;

            this.Refresh_PB.Size = preS;
            this.Refresh_PB.Location = preL;
        }

        private void Refresh_PB_MouseLeave(object sender, EventArgs e)
        {
            Size preS = this.Refresh_PB.Size;
            Point preL = this.Refresh_PB.Location;

            preS.Width += 10;
            preS.Height += 10;

            preL.X -= 5;
            preL.Y -= 5;

            this.Refresh_PB.Size = preS;
            this.Refresh_PB.Location = preL;
        }

        #endregion

        /// <summary>
        /// Блокировка выбора хэш функции в момент сокрытия формы. Последующее разблокировка произойдёт при Refresh или нажатии на кнопку зарузки файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UploadData_Form_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false & this.needToRecreateHashFunction)
            {
                BlockHashFields();

                IHashFunction hash;
                switch (ChooseHash_CB.SelectedIndex)
                {
                    case 0: hash = new SimpleAdaptStringHF(EDGE_VALUE); break;
                    default: hash = new SimpleDivisionStringHF(EDGE_VALUE); break;
                }

                IRehashFunction rehash;
                switch (ChooseRehash_CB.SelectedIndex)
                {
                    case 0: rehash = new OnMultiplicationBasedRHF(STEP_VALUE, EDGE_VALUE); break;
                    default: rehash = new OnRandomBasedRHF(EDGE_VALUE); break;
                }

                parentForm.HashTable = new HashTableForString(hash, rehash);

                // Получаем текст и удаляем заголовок
                string tempText = ListOfIdentificators.Text;
                string text = tempText.Substring(tempText.IndexOf('\n') + 1);

                // Заносим данные в хэш-таблицу
                string[] indentificators = text.Split('\n');
                foreach (string name in indentificators)
                {
                    parentForm.HashTable.Add(name);
                }

                needToRecreateHashFunction = false;
            }
        }

        /*
public HashTable GetHashTable()
{

}
*/
    }
}
