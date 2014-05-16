using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDemo01
{
    public class BMIBridge
    {
        private Double _bmi;
        
        public IMeasurementValue Measurement
        { get; set; }

        public IBMIValue BMIValue
        { get; set; }

        public IBMIComment Comment
        { get; set; }



        public Double GetBMI()
        {
           _bmi =  BMIValue.GetBMIValue(Measurement.Weight , Measurement .Height  );
           return _bmi;
        }

        public string GetComment()
        {
            return Comment.GetBMIComment(_bmi);
        }
    }
}
