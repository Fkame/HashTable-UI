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
            this.Welcome_BackPanel = new System.Windows.Forms.Panel();
            this.Welcome_ScreenForMoveControl = new System.Windows.Forms.Label();
            this.WelcomeText_Label = new System.Windows.Forms.Label();
            this.Welcome_PhraseControl_Timer = new System.Windows.Forms.Timer(this.components);
            this.Welcome_BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcome_BackPanel
            // 
            this.Welcome_BackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Welcome_BackPanel.Controls.Add(this.Welcome_ScreenForMoveControl);
            this.Welcome_BackPanel.Controls.Add(this.WelcomeText_Label);
            this.Welcome_BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Welcome_BackPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Welcome_BackPanel.Location = new System.Drawing.Point(0, 0);
            this.Welcome_BackPanel.Name = "Welcome_BackPanel";
            this.Welcome_BackPanel.Size = new System.Drawing.Size(900, 500);
            this.Welcome_BackPanel.TabIndex = 0;
            // 
            // Welcome_ScreenForMoveControl
            // 
            this.Welcome_ScreenForMoveControl.BackColor = System.Drawing.Color.Transparent;
            this.Welcome_ScreenForMoveControl.ForeColor = System.Drawing.Color.Transparent;
            this.Welcome_ScreenForMoveControl.Location = new System.Drawing.Point(-6, 0);
            this.Welcome_ScreenForMoveControl.Name = "Welcome_ScreenForMoveControl";
            this.Welcome_ScreenForMoveControl.Size = new System.Drawing.Size(903, 500);
            this.Welcome_ScreenForMoveControl.TabIndex = 1;
            this.Welcome_ScreenForMoveControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Welcome_ScreenForMoveControl_MouseDown);
            this.Welcome_ScreenForMoveControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Welcome_ScreenForMoveControl_MouseMove);
            this.Welcome_ScreenForMoveControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Welcome_ScreenForMoveControl_MouseUp);
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
            // 
            // Welcome_PhraseControl_Timer
            // 
            this.Welcome_PhraseControl_Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Welcome_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.Welcome_BackPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Welcome_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Welcome_Form_KeyUp);
            this.Welcome_BackPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Welcome_BackPanel;
        private System.Windows.Forms.Label WelcomeText_Label;
        private System.Windows.Forms.Timer Welcome_PhraseControl_Timer;
        private System.Windows.Forms.Label Welcome_ScreenForMoveControl;
    }
}

