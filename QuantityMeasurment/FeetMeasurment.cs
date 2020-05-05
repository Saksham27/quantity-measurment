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
            try
            {
                // cheking if inputObject is null, if yes then return false
                if (inputObject == null)
                {
                    return false;
                }

                // refrence check
                if (!(inputObject == this))
                {
                    return false;
                }

                // tpye check
                if(!(inputObject.GetType() == this.GetType()))
                {
                    return false;
                }

                // value equality check
                return (((FeetMesurment)inputObject).Feet == this.Feet);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
