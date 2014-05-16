using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContravariantMethodDemo01
{
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    // 逆變           
    private void button1_Click(object sender, EventArgs e)
    {
        //InMethod(new Gen0());
        InMethod(new Gen1());
    }

    private void InMethod(Gen0 obj)
    { }

    private void InMethodx(Gen1 obj)
    { }
}

    public class Gen0
    { public int x;    }

    public class Gen1 : Gen0
    { }
}
