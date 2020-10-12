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
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.btn_HelpPointer = new System.Windows.Forms.PictureBox();
            this.btn_Help = new System.Windows.Forms.PictureBox();
            this.btn_Header = new System.Windows.Forms.Label();
            this.Logo_Panel = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.PictureBox();
            this.Menu_Panel = new System.Windows.Forms.Panel();
            this.btn_StoredData = new System.Windows.Forms.Button();
            this.btn_Visualisation = new System.Windows.Forms.Button();
            this.btn_Searching = new System.Windows.Forms.Button();
            this.btn_UploadData = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.ChildForm_Panel = new System.Windows.Forms.Panel();
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_HelpPointer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Help)).BeginInit();
            this.Logo_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            this.Menu_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header_Panel
            // 
            this.Header_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.Header_Panel.Controls.Add(this.btn_HelpPointer);
            this.Header_Panel.Controls.Add(this.btn_Help);
            this.Header_Panel.Controls.Add(this.btn_Header);
            this.Header_Panel.Controls.Add(this.Logo_Panel);
            this.Header_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_Panel.Location = new System.Drawing.Point(0, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(900, 70);
            this.Header_Panel.TabIndex = 0;
            this.Header_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_Panel_MouseDown);
            this.Header_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_Panel_MouseMove);
            this.Header_Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_Panel_MouseUp);
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
            // Logo_Panel
            // 
            this.Logo_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.Logo_Panel.Controls.Add(this.btn_Exit);
            this.Logo_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logo_Panel.Location = new System.Drawing.Point(0, 0);
            this.Logo_Panel.Name = "Logo_Panel";
            this.Logo_Panel.Size = new System.Drawing.Size(150, 70);
            this.Logo_Panel.TabIndex = 2;
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
            this.btn_Exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Exit_MouseDown);
            this.btn_Exit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Exit_MouseUp);
            // 
            // Menu_Panel
            // 
            this.Menu_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(79)))));
            this.Menu_Panel.Controls.Add(this.btn_StoredData);
            this.Menu_Panel.Controls.Add(this.btn_Visualisation);
            this.Menu_Panel.Controls.Add(this.btn_Searching);
            this.Menu_Panel.Controls.Add(this.btn_UploadData);
            this.Menu_Panel.Controls.Add(this.btn_Home);
            this.Menu_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_Panel.Location = new System.Drawing.Point(0, 70);
            this.Menu_Panel.Name = "Menu_Panel";
            this.Menu_Panel.Size = new System.Drawing.Size(150, 430);
            this.Menu_Panel.TabIndex = 1;
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
            this.btn_Visualisation.Click += new System.EventHandler(this.btn_Visualisation_Click);
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
            this.btn_Searching.Click += new System.EventHandler(this.btn_Searching_Click);
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
            this.btn_UploadData.Click += new System.EventHandler(this.btn_UploadData_Click);
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
            // ChildForm_Panel
            // 
            this.ChildForm_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildForm_Panel.Location = new System.Drawing.Point(150, 70);
            this.ChildForm_Panel.Name = "ChildForm_Panel";
            this.ChildForm_Panel.Size = new System.Drawing.Size(750, 430);
            this.ChildForm_Panel.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.ChildForm_Panel);
            this.Controls.Add(this.Menu_Panel);
            this.Controls.Add(this.Header_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "HashTable App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Header_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_HelpPointer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Help)).EndInit();
            this.Logo_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            this.Menu_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header_Panel;
        private System.Windows.Forms.Panel Logo_Panel;
        private System.Windows.Forms.Panel Menu_Panel;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Label btn_Header;
        private System.Windows.Forms.Button btn_StoredData;
        private System.Windows.Forms.Button btn_Visualisation;
        private System.Windows.Forms.Button btn_Searching;
        private System.Windows.Forms.Button btn_UploadData;
        private System.Windows.Forms.PictureBox btn_Help;
        private System.Windows.Forms.PictureBox btn_HelpPointer;
        private System.Windows.Forms.PictureBox btn_Exit;
        private System.Windows.Forms.Panel ChildForm_Panel;
    }
}