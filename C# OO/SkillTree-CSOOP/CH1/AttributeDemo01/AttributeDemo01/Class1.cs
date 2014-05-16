using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo01
{
    // 建立自訂 Attribute 類別
    internal class BoundaryAttribute : Attribute
    {
        internal Double Max
        { get; set; }

        internal Double Min
        { get; set; }

        // 建構函式, 以便在套用 attribute 時初始化 Min, Max
        public BoundaryAttribute(int min, int max)
        {
            Max = max;
            Min = min;
        }
    }

    // 在列舉值中套用 attribute
    public enum GenderType
    {
        [Boundary(20, 25)]
        Man = 1,
        [Boundary(18, 22)]
        Woman = 2
    }

    // 取得列舉值的 attribute
    internal class EnumValueBoundryHelper
    {
        internal Double Max
        { get; private set; }

        internal Double Min
        { get; private set; }

        public EnumValueBoundryHelper(GenderType gender)
        {
            FieldInfo data = typeof(GenderType).GetField(gender.ToString());
            Attribute attribute = Attribute.GetCustomAttribute(data, typeof(BoundaryAttribute));
            BoundaryAttribute boundaryattribute = (BoundaryAttribute)attribute;
            Min = boundaryattribute.Min;
            Max = boundaryattribute.Max;
        }
    }




    //在類別上套用 attribute
    [BoundaryAttribute(0, 100)]
    public class BoundryClass
    {

    }


    internal class ClassBoundryHelper
    {
        internal Double Max
        { get; private set; }

        internal Double Min
        { get; private set; }

        public void GetBoundry(Type type)
        {
            // 確認型別帶有 BoundaryAttribute
            if (type.IsDefined(typeof(BoundaryAttribute)))
            {
                Attribute attribute = type.GetCustomAttribute(typeof(BoundaryAttribute), true);
                BoundaryAttribute boundaryattribute = (BoundaryAttribute)attribute;
                Min = boundaryattribute.Min;
                Max = boundaryattribute.Max;
            }
        }
    }
}
