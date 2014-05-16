using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDemo01
{
    public interface IMeasurementValue
    {
        Double Weight
        { get; set; }
        Double Height
        { get; set; }
    }

    public class Human : IMeasurementValue 
    {

        public double Weight
        { get; set; }

        public double Height
        { get; set; }

        public int Age
        { get; set; }        
    }

    public class Pig : IMeasurementValue
    {

        public double Weight
        { get; set; }

        public double Height
        { get; set; }

        public string Kind
        { get; set; }
    }
}
