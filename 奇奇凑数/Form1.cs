using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 奇奇凑数
{
    public partial class form1 : Form
    {
        FigureData figuredata = new FigureData();


        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

  
     

        private void dataHandleButton_Click(object sender, EventArgs e)
        {
            List<double> srcData = new List<double>();
            List<List<double>> resultList = new List<List<double>>();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            resultGridView.Rows.Clear();

            foreach (var value in srcInputTextbox.Lines)
            {
                if (value == "")
                {
                    continue;
                }
                srcData.Add(Convert.ToDouble(value));
            }
            resultList = figuredata.GetGatherResult(srcData, Convert.ToDouble(dataWant.Text), Convert.ToDouble(rangeTextbox.Text));
            updateGridViewResult(resultList, dataWant.Text.ToString());
            sw.Stop();
            TimeSpan dt = sw.Elapsed;
            Console.WriteLine("程序耗时:'{0}'秒", dt);
            double time = dt.TotalSeconds;
            MessageBox.Show("程序耗时："+ time.ToString() + "s，一共找到 " +
                resultList.Count.ToString()+ " 个组合");
            Console.ReadLine();
        }

        public void updateGridViewResult(List<List<double>> resultList,string datawant)
        {
            DataGridViewTextBoxColumn acCode = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn acCode2 = new DataGridViewTextBoxColumn();
            acCode.Name = "datawant";
            acCode.DataPropertyName = "datawant";
            acCode.HeaderText = "凑数值";
            acCode2.Name = "combination";
            acCode2.DataPropertyName = "combination";
            acCode2.HeaderText = "组合";


            resultGridView.Columns.Add(acCode);
            resultGridView.Columns.Add(acCode2);
            resultGridView.Rows.Add(resultList.Count);
            for (int i = 0; i < resultList.Count; i++)
            {
                for (int j =0; j < resultList[i].Count; j ++)
                {
                    
                    resultGridView.Rows[i].Cells["datawant"].Value = datawant;
                    
                    if(j == 0)
                    {
                        resultGridView.Rows[i].Cells["combination"].Value = resultList[i][j].ToString();
                    }
                    else
                    {
                        resultGridView.Rows[i].Cells["combination"].Value = resultGridView.Rows[i].Cells["combination"].Value + 
                            " + " + resultList[i][j].ToString();
                    }
                }

            }
        }

        private void srcInputTextbox_TextChanged(object sender, EventArgs e)
        {
            srcInputTextbox.Text = srcInputTextbox.Text.Replace("RMB ","").Replace(",","");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void roundDataHandleButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("没有奇的鼓励，不想写了~~");
        }
    }
}
