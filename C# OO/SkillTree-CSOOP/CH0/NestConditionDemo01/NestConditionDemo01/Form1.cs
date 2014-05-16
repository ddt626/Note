using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestConditionDemo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       // 這兩個是來源
        List<string> strlist = new List<string>() { "Dog", "Cat", "Apple", "House", "Car", "Taxi" };
        List<int> intlist = new List<int> { 1, 4, 8, 90, 77 };

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = false;
            if (strlist[0] == "Dog")
            {
                if (strlist[1] == "Cat")
                {
                    if (strlist[2] == "Apple")
                    {
                        if (strlist[3] == "House")
                        {
                            if (strlist[4] == "Car")
                            {
                                if (strlist[5] == "Taxi")
                                {
                                    if (intlist[0] == 1)
                                    {
                                        if (intlist[1] == 4)
                                        {
                                            if (intlist[2] == 8)
                                            {
                                                if (intlist[3] == 90)
                                                {
                                                    if (intlist[4] == 77)
                                                    {
                                                        result = true;
                                                    }
                                                    else
                                                    {
                                                        result = false;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            MessageBox.Show(" 結果是 :" + result.ToString());
        }
    }
}
