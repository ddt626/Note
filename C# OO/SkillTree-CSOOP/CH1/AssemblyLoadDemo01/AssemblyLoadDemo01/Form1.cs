using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace AssemblyLoadDemo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // load by Assembly name
            AssemblyName name = new AssemblyName("TestLibrary01");
            Assembly asm = Assembly.Load(name);
            MessageBox.Show(asm.FullName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //load by assembly string
            Assembly asm = Assembly.Load("TestLibrary02");      
            MessageBox.Show(asm.FullName);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
                   

        }
    }
}
