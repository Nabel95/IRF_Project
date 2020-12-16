using StockMarketViewer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace StockMarketViewer
{
    public partial class Form1 : Form
    {
        BindingList<StockData> Stocks = new BindingList<StockData>();
        public Form1()
        {
            InitializeComponent();

            string charttype = "CloseValue";
            XmlDocument xmldata = new XmlDocument();
            xmldata.Load("Data/teszt03.xml");
            int j = -1;
            foreach (XmlElement element in xmldata.DocumentElement)
            {
                
                for (int i = 1; i < 11; i++)
                {
                    j++;
                    var stock = new StockData();
                    Stocks.Add(stock);

                    var childElement = (XmlElement)element.ChildNodes[0];
                    stock.Date = DateTime.Parse(childElement.InnerText);
                    childElement = (XmlElement)element.ChildNodes[i];
                    stock.Stock = childElement.Name;
                    if (!cbStock.Items.Contains(childElement.Name))
                    {
                        cbStock.Items.Add(childElement.Name);
                    }
                    cbStock.SelectedIndex = 0;
                    stock.CloseValue = double.Parse(childElement.InnerText, CultureInfo.InvariantCulture);
                    try
                    {
                        stock.Return = Math.Round(((Math.Log(Stocks[j].CloseValue / Stocks[j - 10].CloseValue)) * 100),2);
                        
                    }
                    catch (Exception)
                    {

                        continue;
                    }
                }
                
            }
            
            RefreshData(charttype);            
        }

        private void RefreshData(string charttype)
        {
            dataGridView1.DataSource = (from i in Stocks
                                        where i.Date >= dtStart.Value && i.Date <= dtEnd.Value && i.Stock == cbStock.SelectedItem.ToString()
                                        select i).ToList();
            
            chart1.DataSource = dataGridView1.DataSource;
            ChartShow(charttype);
        }

        private void ChartShow(string charttype)
        {
            var series = chart1.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = charttype;
            series.BorderWidth = 1;
            var legend = chart1.Legends[0];
            legend.Enabled = false;
            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisY.IsStartedFromZero = false;
        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            RefreshData(chart1.Series[0].YValueMembers);
        }

        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {
            RefreshData(chart1.Series[0].YValueMembers);
        }

        private void cbStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData(chart1.Series[0].YValueMembers);
        }

        private void btprice_Click(object sender, EventArgs e)
        {
            string charttype = "CloseValue";
            RefreshData(charttype);
        }

        private void btreturn_Click(object sender, EventArgs e)
        {
            string charttype = "Return";
            RefreshData(charttype);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btcsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = cbStock.SelectedItem.ToString()+".csv";
            bool fileError = false;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                    }
                    catch (IOException ex)
                    {
                        fileError = true;
                        MessageBox.Show("Ez valamiért nem igazán jáú :/." + ex.Message);
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        int columnCount = dataGridView1.Columns.Count;
                        string columnNames = "";
                        string[] outputCsv = new string[dataGridView1.Rows.Count + 1];
                        for (int i = 0; i < columnCount; i++)
                        {
                            columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ";";
                        }
                        outputCsv[0] += columnNames;

                        for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < columnCount; j++)
                            {
                                outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ";";
                            }
                        }

                        File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                        MessageBox.Show("Sikeres exportálás!", "Info");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hiba :" + ex.Message);
                    }
                }
            }
        }
        int x1 = 750, y1 = 25;
        int x2 = 750, y2 = 25;
        private void timerStocks_Tick(object sender, EventArgs e)
        {
            labelStocks.Visible = true;
            labelStocks.SetBounds(x1, y1, 1, 1);
            x1--;
            if (x1<=-300)
            {
                x1 = 750;
            }
        }

        private void timerDelay_Tick(object sender, EventArgs e)
        {
            timerStocks2.Start();
            labelStocks2.Visible = true;
        }

        private void timerStocks2_Tick(object sender, EventArgs e)
        {
            labelStocks2.SetBounds(x2, y2, 1, 1);
            x2--;
            if (x2 <= -300)
            {
                x2 = 750;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelStocks.Visible = false;
            labelStocks2.Visible = false;
            labelStocks.Text = "SunDixi Consulting Kft.";
            labelStocks.Font = new Font(" ", 16, FontStyle.Bold);
            labelStocks2.Text = labelStocks.Text;
            labelStocks2.Font = labelStocks.Font;
            timerStocks.Interval = 1;
            timerStocks.Start();
            
            timerStocks2.Interval = 1;
            timerDelay.Start();
            panel1.Controls.Add(labelStocks);
            panel1.Controls.Add(labelStocks2);
            
        }
    }
}
