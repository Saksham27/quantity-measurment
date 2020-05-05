using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurment
{
    public class FeetMesurment
    {
        public double Feet { get; set; }

        public FeetMesurment(double inputFeet =1)
        {
            this.Feet = inputFeet;
        }
        public override bool Equals(object inputObject)
        {
            
        }
    }
}
