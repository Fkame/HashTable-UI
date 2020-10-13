namespace HashTable_UI_Prototype.SubForms
{
    partial class UploadData_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadData_Form));
            this.Refresh_PB = new System.Windows.Forms.PictureBox();
            this.ChooseHash_CB = new System.Windows.Forms.ComboBox();
            this.ChooseRehash_CB = new System.Windows.Forms.ComboBox();
            this.ListOfIdentificators = new System.Windows.Forms.RichTextBox();
            this.Statistic = new System.Windows.Forms.RichTextBox();
            this.FileName_TextBox = new System.Windows.Forms.TextBox();
            this.btn_LoadFile = new System.Windows.Forms.Button();
            this.EnterSeparator_TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Refresh_PB
            // 
            this.Refresh_PB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh_PB.BackgroundImage")));
            this.Refresh_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Refresh_PB.Location = new System.Drawing.Point(12, 12);
            this.Refresh_PB.Name = "Refresh_PB";
            this.Refresh_PB.Size = new System.Drawing.Size(63, 55);
            this.Refresh_PB.TabIndex = 1;
            this.Refresh_PB.TabStop = false;
            this.Refresh_PB.Click += new System.EventHandler(this.Refresh_PB_Click);
            this.Refresh_PB.MouseEnter += new System.EventHandler(this.Refresh_PB_MouseEnter);
            this.Refresh_PB.MouseLeave += new System.EventHandler(this.Refresh_PB_MouseLeave);
            // 
            // ChooseHash_CB
            // 
            this.ChooseHash_CB.Font = new System.Drawing.Font("Ubuntu Light", 15.25F);
            this.ChooseHash_CB.FormattingEnabled = true;
            this.ChooseHash_CB.Location = new System.Drawing.Point(97, 22);
            this.ChooseHash_CB.Name = "ChooseHash_CB";
            this.ChooseHash_CB.Size = new System.Drawing.Size(282, 32);
            this.ChooseHash_CB.TabIndex = 2;
            this.ChooseHash_CB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChooseHash_CB_KeyPress);
            // 
            // ChooseRehash_CB
            // 
            this.ChooseRehash_CB.Font = new System.Drawing.Font("Ubuntu Light", 15.25F);
            this.ChooseRehash_CB.FormattingEnabled = true;
            this.ChooseRehash_CB.Location = new System.Drawing.Point(418, 22);
            this.ChooseRehash_CB.Name = "ChooseRehash_CB";
            this.ChooseRehash_CB.Size = new System.Drawing.Size(301, 32);
            this.ChooseRehash_CB.TabIndex = 3;
            this.ChooseRehash_CB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChooseRehash_CB_KeyPress);
            // 
            // ListOfIdentificators
            // 
            this.ListOfIdentificators.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListOfIdentificators.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListOfIdentificators.Location = new System.Drawing.Point(12, 83);
            this.ListOfIdentificators.Name = "ListOfIdentificators";
            this.ListOfIdentificators.ReadOnly = true;
            this.ListOfIdentificators.Size = new System.Drawing.Size(357, 271);
            this.ListOfIdentificators.TabIndex = 4;
            this.ListOfIdentificators.Text = "- - - Here will be list of identificators from file - - -\n";
            // 
            // Statistic
            // 
            this.Statistic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Statistic.Font = new System.Drawing.Font("Ubuntu", 11.95F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Statistic.Location = new System.Drawing.Point(393, 83);
            this.Statistic.Name = "Statistic";
            this.Statistic.ReadOnly = true;
            this.Statistic.Size = new System.Drawing.Size(345, 271);
            this.Statistic.TabIndex = 5;
            this.Statistic.Text = "- - - Here will be statystic of reading file - - -";
            // 
            // FileName_TextBox
            // 
            this.FileName_TextBox.BackColor = System.Drawing.Color.Beige;
            this.FileName_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileName_TextBox.Font = new System.Drawing.Font("Ubuntu", 15.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FileName_TextBox.ForeColor = System.Drawing.Color.DimGray;
            this.FileName_TextBox.Location = new System.Drawing.Point(12, 374);
            this.FileName_TextBox.Name = "FileName_TextBox";
            this.FileName_TextBox.ReadOnly = true;
            this.FileName_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.FileName_TextBox.Size = new System.Drawing.Size(247, 31);
            this.FileName_TextBox.TabIndex = 6;
            this.FileName_TextBox.Text = "File name";
            this.FileName_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_LoadFile
            // 
            this.btn_LoadFile.BackColor = System.Drawing.Color.Beige;
            this.btn_LoadFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_LoadFile.BackgroundImage")));
            this.btn_LoadFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_LoadFile.FlatAppearance.BorderSize = 0;
            this.btn_LoadFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Beige;
            this.btn_LoadFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Beige;
            this.btn_LoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadFile.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_LoadFile.Location = new System.Drawing.Point(265, 360);
            this.btn_LoadFile.Name = "btn_LoadFile";
            this.btn_LoadFile.Size = new System.Drawing.Size(270, 62);
            this.btn_LoadFile.TabIndex = 7;
            this.btn_LoadFile.Text = "Click to choose file";
            this.btn_LoadFile.UseVisualStyleBackColor = false;
            this.btn_LoadFile.Click += new System.EventHandler(this.btn_LoadFile_Click);
            this.btn_LoadFile.MouseEnter += new System.EventHandler(this.btn_LoadFile_MouseEnter);
            this.btn_LoadFile.MouseLeave += new System.EventHandler(this.btn_LoadFile_MouseLeave);
            // 
            // EnterSeparator_TextBox
            // 
            this.EnterSeparator_TextBox.BackColor = System.Drawing.Color.Beige;
            this.EnterSeparator_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnterSeparator_TextBox.Font = new System.Drawing.Font("Ubuntu", 15.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.EnterSeparator_TextBox.ForeColor = System.Drawing.Color.DimGray;
            this.EnterSeparator_TextBox.Location = new System.Drawing.Point(541, 374);
            this.EnterSeparator_TextBox.Name = "EnterSeparator_TextBox";
            this.EnterSeparator_TextBox.Size = new System.Drawing.Size(197, 31);
            this.EnterSeparator_TextBox.TabIndex = 8;
            this.EnterSeparator_TextBox.Text = "Enter separator";
            // 
            // UploadData_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(750, 430);
            this.Controls.Add(this.EnterSeparator_TextBox);
            this.Controls.Add(this.btn_LoadFile);
            this.Controls.Add(this.FileName_TextBox);
            this.Controls.Add(this.Statistic);
            this.Controls.Add(this.ListOfIdentificators);
            this.Controls.Add(this.ChooseRehash_CB);
            this.Controls.Add(this.ChooseHash_CB);
            this.Controls.Add(this.Refresh_PB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UploadData_Form";
            this.Text = "Upload data";
            this.Load += new System.EventHandler(this.UploadData_Form_Load);
            this.VisibleChanged += new System.EventHandler(this.UploadData_Form_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Refresh_PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Refresh_PB;
        private System.Windows.Forms.ComboBox ChooseHash_CB;
        private System.Windows.Forms.ComboBox ChooseRehash_CB;
        private System.Windows.Forms.RichTextBox ListOfIdentificators;
        private System.Windows.Forms.RichTextBox Statistic;
        private System.Windows.Forms.TextBox FileName_TextBox;
        private System.Windows.Forms.Button btn_LoadFile;
        private System.Windows.Forms.TextBox EnterSeparator_TextBox;
    }
}