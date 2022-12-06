namespace distribution
{
    partial class FormResult
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBoxInverse = new System.Windows.Forms.CheckBox();
            this.checkBoxMetropolis = new System.Windows.Forms.CheckBox();
            this.checkBoxNeymon = new System.Windows.Forms.CheckBox();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disperse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sigm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(311, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Absolute";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series2.Legend = "Legend1";
            series2.Name = "Neymann";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series3.Legend = "Legend1";
            series3.Name = "Metropolis";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Inverse";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(811, 550);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // checkBoxInverse
            // 
            this.checkBoxInverse.AutoSize = true;
            this.checkBoxInverse.Checked = true;
            this.checkBoxInverse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInverse.Location = new System.Drawing.Point(220, 379);
            this.checkBoxInverse.Name = "checkBoxInverse";
            this.checkBoxInverse.Size = new System.Drawing.Size(61, 17);
            this.checkBoxInverse.TabIndex = 16;
            this.checkBoxInverse.Text = "Inverse";
            this.checkBoxInverse.UseVisualStyleBackColor = true;
            this.checkBoxInverse.CheckedChanged += new System.EventHandler(this.checkBoxInverse_CheckedChanged);
            // 
            // checkBoxMetropolis
            // 
            this.checkBoxMetropolis.AutoSize = true;
            this.checkBoxMetropolis.Checked = true;
            this.checkBoxMetropolis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMetropolis.Location = new System.Drawing.Point(120, 379);
            this.checkBoxMetropolis.Name = "checkBoxMetropolis";
            this.checkBoxMetropolis.Size = new System.Drawing.Size(74, 17);
            this.checkBoxMetropolis.TabIndex = 15;
            this.checkBoxMetropolis.Text = "Metropolis";
            this.checkBoxMetropolis.UseVisualStyleBackColor = true;
            this.checkBoxMetropolis.CheckedChanged += new System.EventHandler(this.checkBoxMetropolis_CheckedChanged);
            // 
            // checkBoxNeymon
            // 
            this.checkBoxNeymon.AutoSize = true;
            this.checkBoxNeymon.Checked = true;
            this.checkBoxNeymon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNeymon.Location = new System.Drawing.Point(33, 379);
            this.checkBoxNeymon.Name = "checkBoxNeymon";
            this.checkBoxNeymon.Size = new System.Drawing.Size(71, 17);
            this.checkBoxNeymon.TabIndex = 14;
            this.checkBoxNeymon.Text = "Neymann";
            this.checkBoxNeymon.UseVisualStyleBackColor = true;
            this.checkBoxNeymon.CheckedChanged += new System.EventHandler(this.checkBoxNeymon_CheckedChanged);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Enabled = false;
            this.textBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxAnswer.Location = new System.Drawing.Point(4, 2);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(301, 168);
            this.textBoxAnswer.TabIndex = 17;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Method,
            this.Mean,
            this.Disperse,
            this.Sigm});
            this.dataGrid.Location = new System.Drawing.Point(4, 176);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(301, 188);
            this.dataGrid.TabIndex = 25;
            // 
            // Method
            // 
            this.Method.HeaderText = "Method";
            this.Method.Name = "Method";
            this.Method.ReadOnly = true;
            // 
            // Mean
            // 
            this.Mean.HeaderText = "Mean";
            this.Mean.Name = "Mean";
            this.Mean.ReadOnly = true;
            // 
            // Disperse
            // 
            this.Disperse.HeaderText = "Dispers";
            this.Disperse.Name = "Disperse";
            this.Disperse.ReadOnly = true;
            // 
            // Sigm
            // 
            this.Sigm.HeaderText = "Sigma";
            this.Sigm.Name = "Sigm";
            this.Sigm.ReadOnly = true;
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 564);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.checkBoxInverse);
            this.Controls.Add(this.checkBoxMetropolis);
            this.Controls.Add(this.checkBoxNeymon);
            this.Controls.Add(this.chart1);
            this.MaximizeBox = false;
            this.Name = "FormResult";
            this.Text = "Result";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox checkBoxInverse;
        private System.Windows.Forms.CheckBox checkBoxMetropolis;
        private System.Windows.Forms.CheckBox checkBoxNeymon;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mean;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disperse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigm;
    }
}