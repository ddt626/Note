using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod02
{
    public class InstanceClass
    {
        public int Width
        { get; set; }
        public int Height
        { get; set; }

        // 取消註解再 run 一次
        public string GetArea()
        {
            return "執行個體方法";
        }
    }
}
