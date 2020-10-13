namespace HashTable_UI_Prototype.SubForms
{
    partial class VisualisationForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.VisualCells_PB = new System.Windows.Forms.PictureBox();
            this.Char_Panel = new System.Windows.Forms.Panel();
            this.Circular_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Statistic = new System.Windows.Forms.RichTextBox();
            this.PictureBox_Background_Panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.VisualCells_PB)).BeginInit();
            this.Char_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Circular_Chart)).BeginInit();
            this.PictureBox_Background_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // VisualCells_PB
            // 
            this.VisualCells_PB.Location = new System.Drawing.Point(3, 3);
            this.VisualCells_PB.Name = "VisualCells_PB";
            this.VisualCells_PB.Size = new System.Drawing.Size(330, 380);
            this.VisualCells_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.VisualCells_PB.TabIndex = 0;
            this.VisualCells_PB.TabStop = false;
            // 
            // Char_Panel
            // 
            this.Char_Panel.Controls.Add(this.Circular_Chart);
            this.Char_Panel.Location = new System.Drawing.Point(388, 12);
            this.Char_Panel.Name = "Char_Panel";
            this.Char_Panel.Size = new System.Drawing.Size(350, 222);
            this.Char_Panel.TabIndex = 1;
            // 
            // Circular_Chart
            // 
            chartArea2.Name = "ChartArea1";
            this.Circular_Chart.ChartAreas.Add(chartArea2);
            this.Circular_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.Circular_Chart.Legends.Add(legend2);
            this.Circular_Chart.Location = new System.Drawing.Point(0, 0);
            this.Circular_Chart.Name = "Circular_Chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Circular_Chart.Series.Add(series2);
            this.Circular_Chart.Size = new System.Drawing.Size(350, 222);
            this.Circular_Chart.TabIndex = 0;
            this.Circular_Chart.Text = "chart1";
            // 
            // Statistic
            // 
            this.Statistic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Statistic.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.Statistic.Location = new System.Drawing.Point(388, 266);
            this.Statistic.Name = "Statistic";
            this.Statistic.ReadOnly = true;
            this.Statistic.Size = new System.Drawing.Size(350, 152);
            this.Statistic.TabIndex = 2;
            this.Statistic.Text = "";
            // 
            // PictureBox_Background_Panel
            // 
            this.PictureBox_Background_Panel.AutoScroll = true;
            this.PictureBox_Background_Panel.BackColor = System.Drawing.Color.Beige;
            this.PictureBox_Background_Panel.Controls.Add(this.VisualCells_PB);
            this.PictureBox_Background_Panel.Location = new System.Drawing.Point(12, 12);
            this.PictureBox_Background_Panel.Name = "PictureBox_Background_Panel";
            this.PictureBox_Background_Panel.Size = new System.Drawing.Size(350, 406);
            this.PictureBox_Background_Panel.TabIndex = 3;
            // 
            // VisualisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(750, 430);
            this.Controls.Add(this.PictureBox_Background_Panel);
            this.Controls.Add(this.Statistic);
            this.Controls.Add(this.Char_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisualisationForm";
            this.Text = "VisualisationForm";
            this.Shown += new System.EventHandler(this.VisualisationForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.VisualCells_PB)).EndInit();
            this.Char_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Circular_Chart)).EndInit();
            this.PictureBox_Background_Panel.ResumeLayout(false);
            this.PictureBox_Background_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox VisualCells_PB;
        private System.Windows.Forms.Panel Char_Panel;
        private System.Windows.Forms.RichTextBox Statistic;
        private System.Windows.Forms.DataVisualization.Charting.Chart Circular_Chart;
        private System.Windows.Forms.Panel PictureBox_Background_Panel;
    }
}