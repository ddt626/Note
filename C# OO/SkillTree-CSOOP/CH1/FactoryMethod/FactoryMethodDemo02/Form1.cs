using FactoryMethodLibrary02;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethodDemo02
{
    public partial class Form1 : Form
    {
        private IDbOperation op = DBHelper.GetDBOperation();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           textBox1 .Text +=op.ConnectDB() + Environment.NewLine ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += op.Query() + Environment.NewLine;
        }
    }
}
