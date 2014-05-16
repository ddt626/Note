using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDemo01
{
    // 分離 BMI 的值計算與字串結果

    public interface IBMIValue
    {
        Double GetBMIValue(Double weight, Double height);
    }

    public class BMIValue : IBMIValue
    {
        public double GetBMIValue(double weight, double height)
        {
            return weight / Math.Pow(height, 2);
        }
    }


    public interface IBMIComment
    {
        Double Min
        { get; }

        Double Max
        { get; }

        String GetBMIComment(Double bmi);
    }



    public sealed class ManBMIComment : IBMIComment
    {

        public double Min
        {
            get { return 20; }
        }

        public double Max
        {
            get { return 25; }
        }

        public string GetBMIComment(double bmi)
        {
            if (bmi > Max)
            {
                return "你是個胖子";
            }
            else if (bmi < Min)
            {
                return "男生這麼瘦不好喔";
            }
            else
            {
                return "太棒了, 繼續維持";
            }

        }
    }

    public sealed class WomanBMIComment : IBMIComment
    {

        public double Min
        {
            get { return 18; }
        }

        public double Max
        {
            get { return 22; }
        }

        public string GetBMIComment(double bmi)
        {
            if (bmi > Max)
            {
                return "該減肥了";
            }
            else if (bmi < Min)
            {
                return "瘦成這樣, 沒人說你是竹竿嗎?";
            }
            else
            {
                return "身材好好喔";
            }
        }
    }

    public sealed class PigBMIComment : IBMIComment
    {

        public double Min
        {
            get { return 30; }
        }

        public double Max
        {
            get { return 50; }
        }

        public string GetBMIComment(double bmi)
        {
            if (bmi > Max)
            {
                return "這條豬肥肉太多";
            }
            else if (bmi < Min)
            {
                return "這麼瘦的豬要賣誰";
            }
            else
            {
                return "品質很好的豬肉";
            }
        }
    }



}
