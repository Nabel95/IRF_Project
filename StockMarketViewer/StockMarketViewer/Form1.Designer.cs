namespace StockMarketViewer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.cbStock = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btprice = new System.Windows.Forms.Button();
            this.btreturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btcsv = new System.Windows.Forms.Button();
            this.timerStocks = new System.Windows.Forms.Timer(this.components);
            this.labelStocks = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelStocks2 = new System.Windows.Forms.Label();
            this.timerStocks2 = new System.Windows.Forms.Timer(this.components);
            this.timerDelay = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stockDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.closeValueDataGridViewTextBoxColumn,
            this.Return});
            this.dataGridView1.DataSource = this.stockDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(480, 698);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(206, 841);
            this.dtStart.MaxDate = new System.DateTime(2020, 12, 15, 0, 0, 0, 0);
            this.dtStart.MinDate = new System.DateTime(2007, 1, 1, 0, 0, 0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(287, 26);
            this.dtStart.TabIndex = 1;
            this.dtStart.Value = new System.DateTime(2007, 1, 1, 0, 0, 0, 0);
            this.dtStart.ValueChanged += new System.EventHandler(this.dtStart_ValueChanged);
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(206, 889);
            this.dtEnd.MaxDate = new System.DateTime(2020, 12, 15, 0, 0, 0, 0);
            this.dtEnd.MinDate = new System.DateTime(2007, 1, 1, 0, 0, 0, 0);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(287, 26);
            this.dtEnd.TabIndex = 2;
            this.dtEnd.Value = new System.DateTime(2020, 12, 15, 0, 0, 0, 0);
            this.dtEnd.ValueChanged += new System.EventHandler(this.dtEnd_ValueChanged);
            // 
            // cbStock
            // 
            this.cbStock.FormattingEnabled = true;
            this.cbStock.Location = new System.Drawing.Point(610, 887);
            this.cbStock.Name = "cbStock";
            this.cbStock.Size = new System.Drawing.Size(121, 28);
            this.cbStock.TabIndex = 3;
            this.cbStock.SelectedIndexChanged += new System.EventHandler(this.cbStock_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(499, 124);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1076, 698);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // btprice
            // 
            this.btprice.Location = new System.Drawing.Point(872, 841);
            this.btprice.Name = "btprice";
            this.btprice.Size = new System.Drawing.Size(123, 74);
            this.btprice.TabIndex = 5;
            this.btprice.Text = "Árfolyam";
            this.btprice.UseVisualStyleBackColor = true;
            this.btprice.Click += new System.EventHandler(this.btprice_Click);
            // 
            // btreturn
            // 
            this.btreturn.Location = new System.Drawing.Point(1024, 841);
            this.btreturn.Name = "btreturn";
            this.btreturn.Size = new System.Drawing.Size(123, 74);
            this.btreturn.TabIndex = 6;
            this.btreturn.Text = "Hozam";
            this.btreturn.UseVisualStyleBackColor = true;
            this.btreturn.Click += new System.EventHandler(this.btreturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 846);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vizsgált időszak kezdete:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 894);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vizsgált időszak vége:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 846);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Részvény:";
            // 
            // btcsv
            // 
            this.btcsv.Location = new System.Drawing.Point(1239, 841);
            this.btcsv.Name = "btcsv";
            this.btcsv.Size = new System.Drawing.Size(123, 74);
            this.btcsv.TabIndex = 10;
            this.btcsv.Text = "Export CSV";
            this.btcsv.UseVisualStyleBackColor = true;
            this.btcsv.Click += new System.EventHandler(this.btcsv_Click);
            // 
            // timerStocks
            // 
            this.timerStocks.Interval = 50;
            this.timerStocks.Tick += new System.EventHandler(this.timerStocks_Tick);
            // 
            // labelStocks
            // 
            this.labelStocks.AutoSize = true;
            this.labelStocks.Location = new System.Drawing.Point(337, 51);
            this.labelStocks.Name = "labelStocks";
            this.labelStocks.Size = new System.Drawing.Size(42, 20);
            this.labelStocks.TabIndex = 11;
            this.labelStocks.Text = "label";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelStocks2);
            this.panel1.Controls.Add(this.labelStocks);
            this.panel1.Location = new System.Drawing.Point(499, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 100);
            this.panel1.TabIndex = 12;
            // 
            // labelStocks2
            // 
            this.labelStocks2.AutoSize = true;
            this.labelStocks2.Location = new System.Drawing.Point(442, 51);
            this.labelStocks2.Name = "labelStocks2";
            this.labelStocks2.Size = new System.Drawing.Size(51, 20);
            this.labelStocks2.TabIndex = 12;
            this.labelStocks2.Text = "label4";
            // 
            // timerStocks2
            // 
            this.timerStocks2.Tick += new System.EventHandler(this.timerStocks2_Tick);
            // 
            // timerDelay
            // 
            this.timerDelay.Enabled = true;
            this.timerDelay.Interval = 9000;
            this.timerDelay.Tick += new System.EventHandler(this.timerDelay_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // stockDataBindingSource
            // 
            this.stockDataBindingSource.DataSource = typeof(StockMarketViewer.Entities.StockData);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 90;
            // 
            // closeValueDataGridViewTextBoxColumn
            // 
            this.closeValueDataGridViewTextBoxColumn.DataPropertyName = "CloseValue";
            this.closeValueDataGridViewTextBoxColumn.HeaderText = "CloseValue ($)";
            this.closeValueDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.closeValueDataGridViewTextBoxColumn.Name = "closeValueDataGridViewTextBoxColumn";
            this.closeValueDataGridViewTextBoxColumn.Width = 80;
            // 
            // Return
            // 
            this.Return.DataPropertyName = "Return";
            this.Return.HeaderText = "Return (%)";
            this.Return.MinimumWidth = 67;
            this.Return.Name = "Return";
            this.Return.Width = 67;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 941);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btcsv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btreturn);
            this.Controls.Add(this.btprice);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.cbStock);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "SunDixi - StockMarketViewer v0.9";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource stockDataBindingSource;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.ComboBox cbStock;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btprice;
        private System.Windows.Forms.Button btreturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btcsv;
        private System.Windows.Forms.Timer timerStocks;
        private System.Windows.Forms.Label labelStocks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerStocks2;
        private System.Windows.Forms.Timer timerDelay;
        private System.Windows.Forms.Label labelStocks2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Return;
    }
}

