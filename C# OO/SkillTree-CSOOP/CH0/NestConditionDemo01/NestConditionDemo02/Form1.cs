using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestConditionDemo02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> strlist = new List<string>() { "Dog", "Cat", "Apple", "House", "Car", "Taxi" };
        List<int> intlist = new List<int> { 1, 4, 8, 90, 77 };
        private void button1_Click(object sender, EventArgs e)
        {
            List<ICheckData> checklist = BuildTestingData();
            bool result = true;
            int i = 0;
            foreach (ICheckData r in checklist)
            {
                if (r.GetResult() == false)
                {
                    result = false;
                    break;
                }
                i++;
                if (i == checklist.Count)
                { i = -1; }
            }
            MessageBox.Show(" 結果是 :" + result.ToString() + " ; 位置:" + i.ToString());
        }

        private List<ICheckData> BuildTestingData()
        {
            List<ICheckData> checklist = new List<ICheckData>();
            checklist.Add(new CheckData<string>("Dog", strlist[0]));
            checklist.Add(new CheckData<string>("Cat", strlist[1]));
            checklist.Add(new CheckData<string>("Apple", strlist[2]));
            checklist.Add(new CheckData<string>("House", strlist[3]));
            checklist.Add(new CheckData<string>("Car", strlist[4]));
            checklist.Add(new CheckData<string>("Taxi", strlist[5]));
            checklist.Add(new CheckData<int>(1, intlist[0]));
            checklist.Add(new CheckData<int>(4, intlist[1]));
            checklist.Add(new CheckData<int>(8, intlist[2]));
            checklist.Add(new CheckData<int>(90, intlist[3]));
            checklist.Add(new CheckData<int>(77, intlist[4]));
            return checklist;
        }
    }



public interface ICheckData
{
    Boolean GetResult();
}

public class CheckData<T> : ICheckData
{
    private T _source;
    private T _target;

    public CheckData(T source, T target)
    {
        _source = source;
        _target = target;
    }
    public bool GetResult()
    {
        return (_source.Equals(_target));
    }
}
}
