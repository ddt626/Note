using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeDemo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class MyRefClass
        { public int x; }

        public struct MyValStruct
        { public int x; }

        private void CreatInstance()
        {
            MyRefClass v1 = new MyRefClass();
            MyValStruct v2 = new MyValStruct();
            v1.x = 10;
            v2.x = 20;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreatInstance();
        }
    }
}
