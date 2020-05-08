using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurment
{
    public class ConvertTo
    {
        /// <summary>
        /// Method to convert inch to feet
        /// </summary>
        /// <param name="inch"></param>
        /// <returns></returns>
        public double InchToFeet(double inch)
        {
            return inch / 12;
        }

        /// <summary>
        /// Method to Convert feet to inch
        /// </summary>
        /// <param name="feet"></param>
        /// <returns></returns>
        public double FeetToInch(double feet)
        {
            return feet * 12;
        }
    }//end:class Convert
}

