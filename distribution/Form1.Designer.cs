namespace distribution
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.openResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.formA = new System.Windows.Forms.NumericUpDown();
            this.formNiter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.formLeft = new System.Windows.Forms.NumericUpDown();
            this.formRight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxNeymon = new System.Windows.Forms.CheckBox();
            this.checkBoxMetropolis = new System.Windows.Forms.CheckBox();
            this.checkBoxInverse = new System.Windows.Forms.CheckBox();
            this.formStep = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBarMetropolis = new System.Windows.Forms.ProgressBar();
            this.progressBarNeymon = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBarInverse = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.Sigm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disperse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Save = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formNiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Absolute";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series2.Legend = "Legend1";
            series2.Name = "Neymon";
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
            this.chart1.Size = new System.Drawing.Size(770, 532);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1083, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openResultToolStripMenuItem,
            this.saveResultToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "File";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // openResultToolStripMenuItem
            // 
            this.openResultToolStripMenuItem.Name = "openResultToolStripMenuItem";
            this.openResultToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.openResultToolStripMenuItem.Text = "Open result";
            this.openResultToolStripMenuItem.Click += new System.EventHandler(this.openResultToolStripMenuItem_Click);
            // 
            // saveResultToolStripMenuItem
            // 
            this.saveResultToolStripMenuItem.Enabled = false;
            this.saveResultToolStripMenuItem.Name = "saveResultToolStripMenuItem";
            this.saveResultToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.saveResultToolStripMenuItem.Text = "Save result";
            this.saveResultToolStripMenuItem.Click += new System.EventHandler(this.saveResultToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton1.Text = "Distribution";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton2.Text = "About";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "Help";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // formA
            // 
            this.formA.DecimalPlaces = 4;
            this.formA.Location = new System.Drawing.Point(104, 11);
            this.formA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.formA.Name = "formA";
            this.formA.Size = new System.Drawing.Size(120, 20);
            this.formA.TabIndex = 1;
            this.formA.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.formA.ValueChanged += new System.EventHandler(this.formA_ValueChanged);
            // 
            // formNiter
            // 
            this.formNiter.Location = new System.Drawing.Point(104, 37);
            this.formNiter.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.formNiter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.formNiter.Name = "formNiter";
            this.formNiter.Size = new System.Drawing.Size(120, 20);
            this.formNiter.TabIndex = 2;
            this.formNiter.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "constant A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "nIter";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(20, 123);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(95, 23);
            this.Start.TabIndex = 5;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // formLeft
            // 
            this.formLeft.DecimalPlaces = 4;
            this.formLeft.Location = new System.Drawing.Point(92, 63);
            this.formLeft.Name = "formLeft";
            this.formLeft.Size = new System.Drawing.Size(59, 20);
            this.formLeft.TabIndex = 7;
            // 
            // formRight
            // 
            this.formRight.DecimalPlaces = 4;
            this.formRight.Location = new System.Drawing.Point(179, 63);
            this.formRight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.formRight.Name = "formRight";
            this.formRight.Size = new System.Drawing.Size(64, 20);
            this.formRight.TabIndex = 8;
            this.formRight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "X from";
            // 
            // checkBoxNeymon
            // 
            this.checkBoxNeymon.AutoSize = true;
            this.checkBoxNeymon.Checked = true;
            this.checkBoxNeymon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNeymon.Location = new System.Drawing.Point(37, 442);
            this.checkBoxNeymon.Name = "checkBoxNeymon";
            this.checkBoxNeymon.Size = new System.Drawing.Size(65, 17);
            this.checkBoxNeymon.TabIndex = 11;
            this.checkBoxNeymon.Text = "Neymon";
            this.checkBoxNeymon.UseVisualStyleBackColor = true;
            this.checkBoxNeymon.Visible = false;
            this.checkBoxNeymon.CheckedChanged += new System.EventHandler(this.checkBoxNeymon_CheckedChanged);
            // 
            // checkBoxMetropolis
            // 
            this.checkBoxMetropolis.AutoSize = true;
            this.checkBoxMetropolis.Checked = true;
            this.checkBoxMetropolis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMetropolis.Location = new System.Drawing.Point(123, 442);
            this.checkBoxMetropolis.Name = "checkBoxMetropolis";
            this.checkBoxMetropolis.Size = new System.Drawing.Size(74, 17);
            this.checkBoxMetropolis.TabIndex = 12;
            this.checkBoxMetropolis.Text = "Metropolis";
            this.checkBoxMetropolis.UseVisualStyleBackColor = true;
            this.checkBoxMetropolis.Visible = false;
            this.checkBoxMetropolis.CheckedChanged += new System.EventHandler(this.checkBoxMetropolis_CheckedChanged);
            // 
            // checkBoxInverse
            // 
            this.checkBoxInverse.AutoSize = true;
            this.checkBoxInverse.Checked = true;
            this.checkBoxInverse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInverse.Location = new System.Drawing.Point(225, 442);
            this.checkBoxInverse.Name = "checkBoxInverse";
            this.checkBoxInverse.Size = new System.Drawing.Size(61, 17);
            this.checkBoxInverse.TabIndex = 13;
            this.checkBoxInverse.Text = "Inverse";
            this.checkBoxInverse.UseVisualStyleBackColor = true;
            this.checkBoxInverse.Visible = false;
            this.checkBoxInverse.CheckedChanged += new System.EventHandler(this.checkBoxInverse_CheckedChanged);
            // 
            // formStep
            // 
            this.formStep.Location = new System.Drawing.Point(104, 89);
            this.formStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.formStep.Name = "formStep";
            this.formStep.Size = new System.Drawing.Size(120, 20);
            this.formStep.TabIndex = 14;
            this.formStep.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Steps";
            // 
            // progressBarMetropolis
            // 
            this.progressBarMetropolis.Location = new System.Drawing.Point(13, 214);
            this.progressBarMetropolis.Name = "progressBarMetropolis";
            this.progressBarMetropolis.Size = new System.Drawing.Size(283, 10);
            this.progressBarMetropolis.TabIndex = 16;
            // 
            // progressBarNeymon
            // 
            this.progressBarNeymon.Location = new System.Drawing.Point(13, 182);
            this.progressBarNeymon.Name = "progressBarNeymon";
            this.progressBarNeymon.Size = new System.Drawing.Size(283, 10);
            this.progressBarNeymon.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Neymann";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Metropolis";
            // 
            // progressBarInverse
            // 
            this.progressBarInverse.Location = new System.Drawing.Point(13, 245);
            this.progressBarInverse.Name = "progressBarInverse";
            this.progressBarInverse.Size = new System.Drawing.Size(283, 10);
            this.progressBarInverse.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Inverse";
            // 
            // Sigm
            // 
            this.Sigm.HeaderText = "Sigma";
            this.Sigm.Name = "Sigm";
            this.Sigm.ReadOnly = true;
            // 
            // Disperse
            // 
            this.Disperse.HeaderText = "Dispers";
            this.Disperse.Name = "Disperse";
            this.Disperse.ReadOnly = true;
            // 
            // Mean
            // 
            this.Mean.HeaderText = "Mean";
            this.Mean.Name = "Mean";
            this.Mean.ReadOnly = true;
            // 
            // Method
            // 
            this.Method.HeaderText = "Method";
            this.Method.Name = "Method";
            this.Method.ReadOnly = true;
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
            this.dataGrid.Location = new System.Drawing.Point(12, 261);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(289, 161);
            this.dataGrid.TabIndex = 24;
            this.dataGrid.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Save);
            this.splitContainer1.Panel1.Controls.Add(this.Open);
            this.splitContainer1.Panel1.Controls.Add(this.StopButton);
            this.splitContainer1.Panel1.Controls.Add(this.PauseButton);
            this.splitContainer1.Panel1.Controls.Add(this.formA);
            this.splitContainer1.Panel1.Controls.Add(this.dataGrid);
            this.splitContainer1.Panel1.Controls.Add(this.formNiter);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.progressBarInverse);
            this.splitContainer1.Panel1.Controls.Add(this.Start);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.formLeft);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.formRight);
            this.splitContainer1.Panel1.Controls.Add(this.progressBarNeymon);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.progressBarMetropolis);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxNeymon);
            this.splitContainer1.Panel1.Controls.Add(this.formStep);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxMetropolis);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxInverse);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(1083, 532);
            this.splitContainer1.SplitterDistance = 309;
            this.splitContainer1.TabIndex = 0;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(160, 480);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(141, 23);
            this.Save.TabIndex = 28;
            this.Save.Text = "Save result";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Visible = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(13, 480);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(138, 23);
            this.Open.TabIndex = 27;
            this.Open.Text = "Open in new window";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Visible = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(192, 123);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(95, 23);
            this.StopButton.TabIndex = 26;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Enabled = false;
            this.PauseButton.Location = new System.Drawing.Point(121, 123);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(65, 23);
            this.PauseButton.TabIndex = 25;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 557);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Maxwell-Boltsman distribution";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formNiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem openResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.NumericUpDown formA;
        private System.Windows.Forms.NumericUpDown formNiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.NumericUpDown formLeft;
        private System.Windows.Forms.NumericUpDown formRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxNeymon;
        private System.Windows.Forms.CheckBox checkBoxMetropolis;
        private System.Windows.Forms.CheckBox checkBoxInverse;
        private System.Windows.Forms.NumericUpDown formStep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBarMetropolis;
        private System.Windows.Forms.ProgressBar progressBarNeymon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBarInverse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disperse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mean;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

