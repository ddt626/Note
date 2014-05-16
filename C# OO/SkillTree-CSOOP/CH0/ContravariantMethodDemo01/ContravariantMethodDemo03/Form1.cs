using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContravariantMethodDemo03
{
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        button1.MouseClick += button1_Click;
    }

    void button1_MouseClick(object sender, MouseEventArgs e)
    {
        MessageBox.Show("Mouse Click");
    }

    void button1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Click");
    }
}
}
