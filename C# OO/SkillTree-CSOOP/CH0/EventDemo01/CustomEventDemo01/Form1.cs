using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomEventDemo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomEvent obj = new CustomEvent();
            obj.X = 9;
            obj.XChanged += obj_XChanged;
            obj.XChanged += obj_XChanged2;
            obj.X = 10;
        }



        private void obj_XChanged(object sender, CustomEventArgs e)
        {
            MessageBox.Show("Old Value : " + e.OldValue);
        }

        private void obj_XChanged2(object sender, CustomEventArgs e)
        {
            MessageBox.Show("New Value : " + e.NewValue);
        }
    }
}
