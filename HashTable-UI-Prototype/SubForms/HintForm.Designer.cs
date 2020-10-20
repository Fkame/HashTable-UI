namespace HashTable_UI_Prototype.SubForms
{
    partial class HintForm
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
            this.HindTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // HindTextBox
            // 
            this.HindTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.HindTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HindTextBox.Font = new System.Drawing.Font("Ubuntu", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HindTextBox.ForeColor = System.Drawing.Color.Beige;
            this.HindTextBox.Location = new System.Drawing.Point(12, 12);
            this.HindTextBox.Name = "HindTextBox";
            this.HindTextBox.ReadOnly = true;
            this.HindTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.HindTextBox.Size = new System.Drawing.Size(332, 355);
            this.HindTextBox.TabIndex = 0;
            this.HindTextBox.Text = "";
            // 
            // HintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(356, 379);
            this.Controls.Add(this.HindTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HintForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox HindTextBox;
    }
}