using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SingletonDemo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 呼叫端無法直接建立執行個體
            // SingletonClass obj = new SingletonClass();

            //透過靜態屬性存取
            SingletonClass.SingletonObject.Show();
            
        }
    }
}
