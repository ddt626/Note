using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovariantMethodDemo01
{
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    //共變
    private void button1_Click(object sender, EventArgs e)
    {
        //Gen1 obj = OutMethodx();
        Gen0 obj = OutMethodx();
    }

    private Gen0 OutMethod()
    { return new Gen0(); }

    private Gen1 OutMethodx()
    { return new Gen1(); }
}

    public class Gen0
    { public int x;    }

    public class Gen1 : Gen0
    { }
}
