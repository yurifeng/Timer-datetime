using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

       
        /// <summary>
        /// 每隔一秒钟就把当前的时间赋值给label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //将datetime的现在时间转换成string,再赋值给label2.text
            label2.Text = DateTime.Now.ToString();
        }


        /// <summary>
        /// 窗体的初始化先加载tostring过后的时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            ////将datetime的现在时间转换成string,再赋值给label2.text
            label2.Text = DateTime.Now.ToString();
        }
    }
}
