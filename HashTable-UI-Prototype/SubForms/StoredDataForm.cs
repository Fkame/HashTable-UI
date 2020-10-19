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
    public partial class StoredDataForm : Form
    {
        public static Color HIGHLIGHT_COLOR = Color.FromArgb(191, 82, 48);

        private MainMenu parentForm;

        public StoredDataForm(MainMenu parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void StoredDataForm_Load(object sender, EventArgs e)
        { 
            #region Визуальный осмотр видов границ ячеек
            /*
            timer1.Interval = 2000;
            styles[0] = DataGridViewCellBorderStyle.None;
            styles[1] = DataGridViewCellBorderStyle.Single;
            styles[2] = DataGridViewCellBorderStyle.SingleHorizontal;
            styles[3] = DataGridViewCellBorderStyle.SingleVertical;
            styles[4] = DataGridViewCellBorderStyle.Raised;
            styles[5] = DataGridViewCellBorderStyle.RaisedHorizontal;
            styles[6] = DataGridViewCellBorderStyle.RaisedVertical;
            styles[7] = DataGridViewCellBorderStyle.Sunken;
            styles[8] = DataGridViewCellBorderStyle.SunkenHorizontal;
            styles[9] = DataGridViewCellBorderStyle.SunkenVertical;

            timer1.Start();
            */
            #endregion
        }

        private void CustomizeDataGridView()
        {
            // Общий вид таблицы
            DataTable.EnableHeadersVisualStyles = false;
            DataTable.AlternatingRowsDefaultCellStyle = null;
            DataTable.BackgroundColor = Color.Beige;
            DataTable.RowHeadersVisible = false;

            // Ячейки с данными
            DataTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataTable.GridColor = StoredDataForm.HIGHLIGHT_COLOR;
            DataTable.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            DataTable.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            DataTable.BackgroundColor = Color.Beige;
            DataTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataTable.DefaultCellStyle.Font = new Font("Ubuntu", 14);

            // Ячейки заголовка
            DataTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataTable.ColumnHeadersDefaultCellStyle.Font = new Font("Ubuntu", 18, FontStyle.Bold);
            DataTable.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(48, 48, 59);
            DataTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.Beige;
            
            // Настройка ширины колонок
            foreach (DataGridViewColumn c in DataTable.Columns)
            {
                c.Width = DataTable.Width / 3 - 7;
            }

            // Найстройка высоты ячеек
            foreach (DataGridViewRow c in DataTable.Rows)
            {
                c.Height = c.Height + 10;
            }
        }

        private void LoadDataToDataGridView()
        {
            string[] hashTable = parentForm.HashTable.GetFullHashTableAsArray();
            DataTable.RowCount = hashTable.Length;

            for (int i = 0; i < hashTable.Length; i++)
            {
                DataTable.Rows[i].Cells[0].Value = i.ToString();
                if (hashTable[i].Equals(String.Empty))
                {
                    DataTable.Rows[i].Cells[1].Value = "null";
                }
                else
                {
                    DataTable.Rows[i].Cells[1].Value = hashTable[i];
                }
                
                if (hashTable[i].Equals(String.Empty))
                {
                    DataTable.Rows[i].Cells[2].Value = "null";
                }
                else
                {
                    DataTable.Rows[i].Cells[2].Value = parentForm.HashTable.IsValueStoredAsRehash(hashTable[i]);
                }
            }
        }

        private DataGridViewCellBorderStyle[] styles = new DataGridViewCellBorderStyle[10];
        private int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //DataTable.CellBorderStyle = styles[count++ % styles.Length];
        }

        private void StoredDataForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false) return;

            DataTable.Rows.Clear();
            LoadDataToDataGridView();
            CustomizeDataGridView();
        }
    }
}
