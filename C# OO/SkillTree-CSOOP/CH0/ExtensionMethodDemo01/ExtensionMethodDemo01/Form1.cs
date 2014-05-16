using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionMethodDemo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExtensionClass.Splitline("ABC"); 
            String str = "ABC" + Environment.NewLine + " " + Environment.NewLine + "CDE";
            var result = str.Splitline();
            str.
            foreach (var s in result)
            {
                MessageBox.Show(s);
            }
        }
    }
}
