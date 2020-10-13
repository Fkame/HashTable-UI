namespace HashTable_UI_Prototype.SubForms
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.Statistic = new System.Windows.Forms.RichTextBox();
            this.Identificators = new System.Windows.Forms.RichTextBox();
            this.EnterIdentificator_TB = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Statistic
            // 
            this.Statistic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Statistic.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.Statistic.Location = new System.Drawing.Point(12, 12);
            this.Statistic.Name = "Statistic";
            this.Statistic.ReadOnly = true;
            this.Statistic.Size = new System.Drawing.Size(350, 271);
            this.Statistic.TabIndex = 0;
            this.Statistic.Text = "";
            // 
            // Identificators
            // 
            this.Identificators.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Identificators.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.Identificators.Location = new System.Drawing.Point(380, 12);
            this.Identificators.Name = "Identificators";
            this.Identificators.ReadOnly = true;
            this.Identificators.Size = new System.Drawing.Size(350, 406);
            this.Identificators.TabIndex = 1;
            this.Identificators.Text = "";
            // 
            // EnterIdentificator_TB
            // 
            this.EnterIdentificator_TB.BackColor = System.Drawing.Color.Beige;
            this.EnterIdentificator_TB.Font = new System.Drawing.Font("Ubuntu", 15.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.EnterIdentificator_TB.ForeColor = System.Drawing.Color.DimGray;
            this.EnterIdentificator_TB.Location = new System.Drawing.Point(12, 303);
            this.EnterIdentificator_TB.Name = "EnterIdentificator_TB";
            this.EnterIdentificator_TB.Size = new System.Drawing.Size(350, 31);
            this.EnterIdentificator_TB.TabIndex = 2;
            this.EnterIdentificator_TB.Text = "Enter identificator name";
            this.EnterIdentificator_TB.DoubleClick += new System.EventHandler(this.EnterIdentificator_TB_DoubleClick);
            this.EnterIdentificator_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterIdentificator_TB_KeyDown);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Beige;
            this.btn_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search.BackgroundImage")));
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Beige;
            this.btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Beige;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Location = new System.Drawing.Point(12, 350);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(350, 68);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search in hash table";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            this.btn_Search.MouseEnter += new System.EventHandler(this.btn_Search_MouseEnter);
            this.btn_Search.MouseLeave += new System.EventHandler(this.btn_Search_MouseLeave);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(750, 430);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.EnterIdentificator_TB);
            this.Controls.Add(this.Identificators);
            this.Controls.Add(this.Statistic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Statistic;
        private System.Windows.Forms.RichTextBox Identificators;
        private System.Windows.Forms.TextBox EnterIdentificator_TB;
        private System.Windows.Forms.Button btn_Search;
    }
}