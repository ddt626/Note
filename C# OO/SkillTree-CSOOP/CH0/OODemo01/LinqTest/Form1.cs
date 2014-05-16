using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[]  target = new string[] { "1", "2", "4" };

            List<string[]> sources = new List<string[]>();
            sources.Add(new string[] { "1", "2", "3" });
            sources.Add(new string[] { "1", "2", "4" });
            sources.Add(new string[] { "1", "2", "3", "4" });
            sources.Add(new string[] { "1", "2", "3", "5" });
            sources.Add(new string[] { "1", "2", "3", "4", "5","6" });
            sources.Add(new string[] { "1", "2" });
            sources.Add(new string[] { "1", "2", "3","4","8" });

            var results = sources.Where((x) => target.Except(x).Count() == 0);
            
            //以下為顯示結果用
            foreach (var item in results )
            {
                string result = string.Empty;
                foreach (var s in item)
                {
                    result += s + ",";
                }
                MessageBox.Show("元素中含有 " + result + "包含了 1,2,4");
            }

            //foreach (var item in sources)
            //{
            //    // 這是為了要顯示結果做的
            //    string result = string.Empty;
            //    foreach (var s in item)
            //    {
            //        result += s + ",";
            //    }
            //    //====


            //    if  ( target.Except (item).Count() == 0 )
            //    {
                    
            //        MessageBox.Show("元素中含有 " + result + "包含了 1,2,4");
            //    }
            //    else
            //    {
            //        MessageBox.Show("元素中含有 " + result + "不包含 1,2,4");
            //    }
            //}

            //string[] s2 = new string[] { "1", "2","3" };
            //var s3 = s2.Where((x) => s1.Where((y) => x == y).FirstOrDefault() != null);
            //var s4 = s2.Except(s1);
            //MessageBox.Show((s4 == null).ToString());

            //int x1 = 32769;
            //Object obj = x1;
          
            //short y1 = (short)(int)obj;
            //MessageBox.Show(y1.ToString());
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            string[] target = new string[] { "1", "2", "4" };
            string[] source = new string[] { "1", "2", "4", "5" };

            MessageBox.Show("target.Except (source).Count() = " + target.Except(source).Count().ToString());
            MessageBox.Show("source.Except (target).Count() = " + source.Except(target).Count().ToString());
        }
    }
}
