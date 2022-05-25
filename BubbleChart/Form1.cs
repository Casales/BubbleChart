using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BubbleChart
{
    public partial class Form1 : Form
    {
        Dictionary<int, ChartData> data = new Dictionary<int, ChartData>();
        public Form1()
        {
            InitializeComponent();
            var width = 1000;
            var height = 1000;
            var bmp = new Bitmap(width, height);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if ((double)x / (double)width * (double)height < height - y) bmp.SetPixel(x, y, Color.FromArgb(127, 219, 238, 244));
                    else bmp.SetPixel(x, y, Color.FromArgb(255, 219, 238, 244));
                }
            }
            bmp.Save("background");
            chart1.PostPaint += new EventHandler<ChartPaintEventArgs>(PostPaintEventHandler);

        }

        void PostPaintEventHandler(object sender, ChartPaintEventArgs e)
        {
            using (System.Drawing.Pen pen = new Pen(Color.Black, 3))
            {
                int pad = 25;
                e.ChartGraphics.Graphics.DrawRectangle(pen, new System.Drawing.Rectangle(pad,pad, chart1.Width - 2 * pad, chart1.Height - 2 * pad));
            }
            int medium = 2;
            if (checkBox_Web.Checked) medium = 1;
            foreach (var dataPoint in data.Values)
            {
                if (dataPoint.Media == medium)
                {
                    using (System.Drawing.Font font = new System.Drawing.Font("Courier New", 36, FontStyle.Bold, GraphicsUnit.Pixel))
                    {
                        int offset = 17;
                        if (dataPoint.Count >= 10) offset += 10;
                        if (dataPoint.Count >= 100) offset += 10;
                        int x = (int)chart1.ChartAreas[0].AxisX.ValueToPixelPosition(dataPoint.Before) - offset;
                        int y = (int)chart1.ChartAreas[0].AxisY.ValueToPixelPosition(dataPoint.After) - 18;
                        //x += chart1.Location.X;
                        //y += chart1.Location.Y;
                        System.Drawing.Point point1 = new System.Drawing.Point(x, y);
                        TextRenderer.DrawText(e.ChartGraphics.Graphics, dataPoint.Count.ToString(), font, point1, Color.White);
                    }
                }
            }

            
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                openExcel(openFileDialog.FileName);
            }
        }

        private void openExcel(string path)
        {
            Microsoft.Office.Interop.Excel.Application oXL;
            Microsoft.Office.Interop.Excel._Workbook oWB;
            Microsoft.Office.Interop.Excel._Worksheet oSheet;

            try
            {
                oXL = new Microsoft.Office.Interop.Excel.Application();
                oWB = oXL.Workbooks.Add(path);
                oSheet = oWB.ActiveSheet;
                oXL.Visible = false;
                int mediaIndex = getColumnIndex(oSheet, "Media");
                int beforeIndex = getColumnIndex(oSheet, textBox_Before.Text);
                int afterIndex = getColumnIndex(oSheet, textBox_After.Text);

                extractData(oSheet, mediaIndex, beforeIndex, afterIndex);

                BeginInvoke(new System.Action(() =>
                {
                    int medium = 2;
                    if (checkBox_Web.Checked) medium = 1;
                    chart1.ChartAreas[0].BackImage = "background";
                    chart1.Series[0].Points.Clear();
                    chart1.ChartAreas[0].AxisX.Title = textBox_XAxis.Text;
                    chart1.ChartAreas[0].AxisY.Title = textBox_YAxis.Text;
                    chart1.Titles[0].Text = textBox_Title.Text;

                    int total = 0;
                    foreach (var dataPoint in data.Values)
                    {
                        if (dataPoint.Media == medium)
                        {
                            total += dataPoint.Count;
                        }
                    }

                    foreach (var dataPoint in data.Values)
                    {
                        if (dataPoint.Media == medium)
                        {
                            chart1.Series[0].Points.AddXY(dataPoint.Before, dataPoint.After);
                            int percentage = (int)Math.Round((double)dataPoint.Count / (double)total * 100);
                            chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].MarkerSize = 25 + (int)Math.Sqrt(percentage * 300);
                            //chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].Label = dataPoint.Count.ToString();
                            chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].Color = Color.FromArgb(160, 35, 88, 104);
                        }
                    }
                }));
                

                oWB.Close();
                oXL.Quit();
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }
        }

        private Dictionary<int, ChartData> extractData(_Worksheet oSheet, int mediaIndex, int beforeIndex, int afterIndex)
        {
            data = new Dictionary<int, ChartData>();
            for(int i = 2; i < 10000; i++)
            {
                try
                {
                    var dataPoint = new ChartData();
                    dataPoint.Media = (int)oSheet.Cells[i, mediaIndex].Value;
                    dataPoint.Before = (int)oSheet.Cells[i, beforeIndex].Value;
                    dataPoint.After = (int)oSheet.Cells[i, afterIndex].Value;
                    dataPoint.Count = 1;
                    if(data.ContainsKey(dataPoint.GetHashCode())) data[dataPoint.GetHashCode()].Count++;
                    else data[dataPoint.GetHashCode()] = dataPoint;
                }
                catch
                {
                    break;
                }
                
            }
            return data;
        }

        private int getColumnIndex(_Worksheet oSheet, string text)
        {
            for (int index = 1; index < 1000; index++)
            {
                var cellContent = (string)oSheet.Cells[1, index].Value;
                Debug.WriteLine(cellContent);
                if (cellContent == null) continue;
                if (cellContent.Contains(text)) return index;
            }

            throw new Exception($"Column {text} not found!");
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog choofdlog = new SaveFileDialog()
            {
                FileName = $"{textBox_Title.Text.Replace(":", "_").Replace(" ", "_")}.png",
                Filter = "PNG Files (*.png)|*.png|All Files (*.*)|*.*",
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = true,
            };
            if (choofdlog.ShowDialog() != DialogResult.OK) return;
            chart1.SaveImage(choofdlog.FileName, ChartImageFormat.Png);
        }
    }
}
