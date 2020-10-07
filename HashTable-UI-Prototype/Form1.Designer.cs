namespace HashTable_UI_Prototype
{
    partial class Welcome_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Welcome_panel = new System.Windows.Forms.Panel();
            this.WelcomeText_Label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Welcome_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcome_panel
            // 
            this.Welcome_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Welcome_panel.Controls.Add(this.WelcomeText_Label);
            this.Welcome_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Welcome_panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Welcome_panel.Location = new System.Drawing.Point(0, 0);
            this.Welcome_panel.Name = "Welcome_panel";
            this.Welcome_panel.Size = new System.Drawing.Size(900, 500);
            this.Welcome_panel.TabIndex = 0;
            // 
            // WelcomeText_Label
            // 
            this.WelcomeText_Label.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeText_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WelcomeText_Label.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeText_Label.ForeColor = System.Drawing.Color.Gainsboro;
            this.WelcomeText_Label.Location = new System.Drawing.Point(0, 0);
            this.WelcomeText_Label.Name = "WelcomeText_Label";
            this.WelcomeText_Label.Size = new System.Drawing.Size(900, 500);
            this.WelcomeText_Label.TabIndex = 0;
            this.WelcomeText_Label.Text = "Hello";
            this.WelcomeText_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeText_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WelcomeText_Label_MouseDown);
            this.WelcomeText_Label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WelcomeText_Label_MouseMove);
            this.WelcomeText_Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WelcomeText_Label_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Welcome_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.Welcome_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Welcome_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Welcome_Form_KeyUp);
            this.Welcome_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Welcome_panel;
        private System.Windows.Forms.Label WelcomeText_Label;
        private System.Windows.Forms.Timer timer1;
    }
}

