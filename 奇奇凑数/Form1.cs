﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace 奇奇凑数
{
    public partial class form1 : Form
    {
        FigureData figuredata = new FigureData();
        private float x;//定义当前窗体的宽度
        private float y;//定义当前窗体的高度
        List<List<double>> resultList = new List<List<double>>();

        public form1()
        {
            InitializeComponent();
            x = this.Width;
            y = this.Height;
            setTag(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //region 控件大小随窗体大小等比例缩放

        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ";" + con.Height + ";" + con.Left + ";" + con.Top + ";" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    setTag(con);
                }
            }
        }
        private void setControls(float newx, float newy, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control con in cons.Controls)
            {
                //获取控件的Tag属性值，并分割后存储字符串数组
                if (con.Tag != null)
                {
                    string[] mytag = con.Tag.ToString().Split(new char[] { ';' });
                    //根据窗体缩放的比例确定控件的值
                    con.Width = Convert.ToInt32(System.Convert.ToSingle(mytag[0]) * newx);//宽度
                    con.Height = Convert.ToInt32(System.Convert.ToSingle(mytag[1]) * newy);//高度
                    con.Left = Convert.ToInt32(System.Convert.ToSingle(mytag[2]) * newx);//左边距
                    con.Top = Convert.ToInt32(System.Convert.ToSingle(mytag[3]) * newy);//顶边距
                    Single currentSize = System.Convert.ToSingle(mytag[4]) * newy;//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    if (con.Controls.Count > 0)
                    {
                        setControls(newx, newy, con);
                    }
                }
            }
        }


        static private bool click_enable = true;
        private void dataHandleButton_Click(object sender, EventArgs e)
        {
            if (click_enable == false)
            {
                MessageBox.Show("o(╥﹏╥)o  已经很努力在计算了");
                return;
            }
            click_enable = false;
            resultGridView.Rows.Clear();
            resultGridView.Columns.Clear();
            drawThread = new Thread(new ThreadStart(GetResult));
            drawThread.IsBackground = true;
            drawThread.Start();

            Console.ReadLine();
        }

        private void initGridView()
        {
            DataGridViewTextBoxColumn acCode = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn acCode2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn acCode0 = new DataGridViewTextBoxColumn();
            acCode0.Name = "Index";
            acCode0.DataPropertyName = "Index";
            acCode0.HeaderText = "序号";

            acCode.Name = "datawant";
            acCode.DataPropertyName = "datawant";
            acCode.HeaderText = "凑数值";

            acCode2.Name = "combination";
            acCode2.DataPropertyName = "combination";
            acCode2.HeaderText = "组合";

            resultGridView.Columns.Add(acCode0);
            resultGridView.Columns.Add(acCode);
            resultGridView.Columns.Add(acCode2);
        }
        public void updateGridViewResult(List<List<double>> resultList,string datawant)
        {
            if(resultList.Count <= 0)
            {
                return;
            }
            if (resultGridView.Columns.Count <= 0)
            {
                initGridView();
            }

            resultGridView.Rows.Add(resultList.Count);
            for (int i = 0; i < resultList.Count; i++)
            {
                resultGridView.Rows[i].Cells["Index"].Value = i + 1;
                for (int j =0; j < resultList[i].Count; j ++)
                {
                    resultGridView.Rows[i].Cells["datawant"].Value = datawant;

                    if (j == 0)
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


        private void roundDataHandleButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("没有奇的鼓励，不想写了~~");
        }

        private void form1_Resize_1(object sender, EventArgs e)
        {
            float newx = (this.Width) / x;
            float newy = (this.Height) / y;
            setControls(newx, newy, this);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        Thread drawThread = null;
        public delegate void Action2<in T,in T1>(T t, T1 t1);
        delegate void drawDelegate(int i);

        private void GetResult()
        {
            List<double> srcData = new List<double>();
            resultList.Clear();
            Stopwatch sw = new Stopwatch();
            sw.Start();

            foreach (var value in srcInputTextbox.Lines)
            {
                if (value == "")
                {
                    continue;
                }
                srcData.Add(Convert.ToDouble(value));
            }
            figuredata.GetGatherResult(srcData, ref resultList, Convert.ToDouble(dataWant.Text), Convert.ToDouble(rangeTextbox.Text));
            Action2< List< List<double> >,string> a = new Action2<List<List<double>>, string>(updateGridViewResult);
            Invoke(a, resultList, dataWant.Text.ToString());
            sw.Stop();
            TimeSpan dt = sw.Elapsed;
            Console.WriteLine("程序耗时:'{0}'秒", dt);
            double time = dt.TotalSeconds;
            MessageBox.Show("程序耗时：" + time.ToString() + "s，一共找到 " +
                resultList.Count.ToString() + " 个组合");
            click_enable = true;
        }
    }
}
