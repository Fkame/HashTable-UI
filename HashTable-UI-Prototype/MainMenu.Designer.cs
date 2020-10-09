namespace HashTable_UI_Prototype
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_HelpPointer = new System.Windows.Forms.PictureBox();
            this.btn_Help = new System.Windows.Forms.PictureBox();
            this.btn_Header = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_StoredData = new System.Windows.Forms.Button();
            this.btn_Visualisation = new System.Windows.Forms.Button();
            this.btn_Searching = new System.Windows.Forms.Button();
            this.btn_UploadData = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_HelpPointer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Help)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.btn_HelpPointer);
            this.panel1.Controls.Add(this.btn_Help);
            this.panel1.Controls.Add(this.btn_Header);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 70);
            this.panel1.TabIndex = 0;
            // 
            // btn_HelpPointer
            // 
            this.btn_HelpPointer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_HelpPointer.BackgroundImage")));
            this.btn_HelpPointer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_HelpPointer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_HelpPointer.Location = new System.Drawing.Point(767, 0);
            this.btn_HelpPointer.Margin = new System.Windows.Forms.Padding(0);
            this.btn_HelpPointer.Name = "btn_HelpPointer";
            this.btn_HelpPointer.Size = new System.Drawing.Size(58, 70);
            this.btn_HelpPointer.TabIndex = 5;
            this.btn_HelpPointer.TabStop = false;
            // 
            // btn_Help
            // 
            this.btn_Help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Help.BackgroundImage")));
            this.btn_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Help.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Help.Location = new System.Drawing.Point(825, 0);
            this.btn_Help.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(75, 70);
            this.btn_Help.TabIndex = 4;
            this.btn_Help.TabStop = false;
            // 
            // btn_Header
            // 
            this.btn_Header.BackColor = System.Drawing.Color.Transparent;
            this.btn_Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Header.Font = new System.Drawing.Font("Ubuntu", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Header.ForeColor = System.Drawing.Color.Beige;
            this.btn_Header.Location = new System.Drawing.Point(456, 15);
            this.btn_Header.Name = "btn_Header";
            this.btn_Header.Size = new System.Drawing.Size(117, 41);
            this.btn_Header.TabIndex = 3;
            this.btn_Header.Text = "HOME";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.panel3.Controls.Add(this.btn_Exit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 70);
            this.panel3.TabIndex = 2;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Exit.Location = new System.Drawing.Point(53, 15);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(41, 41);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(79)))));
            this.panel2.Controls.Add(this.btn_StoredData);
            this.panel2.Controls.Add(this.btn_Visualisation);
            this.panel2.Controls.Add(this.btn_Searching);
            this.panel2.Controls.Add(this.btn_UploadData);
            this.panel2.Controls.Add(this.btn_Home);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 430);
            this.panel2.TabIndex = 1;
            // 
            // btn_StoredData
            // 
            this.btn_StoredData.FlatAppearance.BorderSize = 0;
            this.btn_StoredData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StoredData.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_StoredData.ForeColor = System.Drawing.Color.Beige;
            this.btn_StoredData.Location = new System.Drawing.Point(0, 354);
            this.btn_StoredData.Margin = new System.Windows.Forms.Padding(0);
            this.btn_StoredData.Name = "btn_StoredData";
            this.btn_StoredData.Size = new System.Drawing.Size(150, 60);
            this.btn_StoredData.TabIndex = 6;
            this.btn_StoredData.Text = "Stored data";
            this.btn_StoredData.UseVisualStyleBackColor = true;
            // 
            // btn_Visualisation
            // 
            this.btn_Visualisation.FlatAppearance.BorderSize = 0;
            this.btn_Visualisation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Visualisation.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Visualisation.ForeColor = System.Drawing.Color.Beige;
            this.btn_Visualisation.Location = new System.Drawing.Point(0, 278);
            this.btn_Visualisation.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Visualisation.Name = "btn_Visualisation";
            this.btn_Visualisation.Size = new System.Drawing.Size(150, 60);
            this.btn_Visualisation.TabIndex = 5;
            this.btn_Visualisation.Text = "Visualisation";
            this.btn_Visualisation.UseVisualStyleBackColor = true;
            // 
            // btn_Searching
            // 
            this.btn_Searching.FlatAppearance.BorderSize = 0;
            this.btn_Searching.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Searching.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Searching.ForeColor = System.Drawing.Color.Beige;
            this.btn_Searching.Location = new System.Drawing.Point(0, 195);
            this.btn_Searching.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Searching.Name = "btn_Searching";
            this.btn_Searching.Size = new System.Drawing.Size(150, 60);
            this.btn_Searching.TabIndex = 4;
            this.btn_Searching.Text = "Searching";
            this.btn_Searching.UseVisualStyleBackColor = true;
            // 
            // btn_UploadData
            // 
            this.btn_UploadData.FlatAppearance.BorderSize = 0;
            this.btn_UploadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UploadData.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_UploadData.ForeColor = System.Drawing.Color.Beige;
            this.btn_UploadData.Location = new System.Drawing.Point(0, 115);
            this.btn_UploadData.Margin = new System.Windows.Forms.Padding(0);
            this.btn_UploadData.Name = "btn_UploadData";
            this.btn_UploadData.Size = new System.Drawing.Size(150, 60);
            this.btn_UploadData.TabIndex = 3;
            this.btn_UploadData.Text = "Upload data";
            this.btn_UploadData.UseVisualStyleBackColor = true;
            // 
            // btn_Home
            // 
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Home.ForeColor = System.Drawing.Color.Beige;
            this.btn_Home.Location = new System.Drawing.Point(0, 31);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(150, 60);
            this.btn_Home.TabIndex = 2;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "HashTable App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HashTableApp_Form_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HashTableApp_Form_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_HelpPointer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Help)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Label btn_Header;
        private System.Windows.Forms.Button btn_StoredData;
        private System.Windows.Forms.Button btn_Visualisation;
        private System.Windows.Forms.Button btn_Searching;
        private System.Windows.Forms.Button btn_UploadData;
        private System.Windows.Forms.PictureBox btn_Help;
        private System.Windows.Forms.PictureBox btn_HelpPointer;
        private System.Windows.Forms.PictureBox btn_Exit;
    }
}