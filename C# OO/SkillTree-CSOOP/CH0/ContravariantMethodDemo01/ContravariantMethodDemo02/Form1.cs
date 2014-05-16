using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContravariantMethodDemo02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SortedSet<Circle> circlesByArea = new SortedSet<Circle>(new ShapeAreaComparer()) { new Circle(5), new Circle(10), new Circle(2) };
            foreach (var c in circlesByArea )
            {
                MessageBox.Show(c.Area.ToString()); 
            }

        }
    }
}
