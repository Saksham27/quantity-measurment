//-----------------------------------------------------------------------
// <copyright file="Calculate.cs" company="BridgeLabz Solutions LLP">
//     Copyright (c) Company. All rights reserved.
// </copyright>
// <author> Saksham Singh </author>
//-----------------------------------------------------------------------
namespace QuantityMeasurement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class containing diffrent calculations
    /// </summary>
    public class Calculate
    {
        /// <summary>
        /// method to add two length quantiities
        /// </summary>
        /// <param name="quantityOne"> first value </param>
        /// <param name="quantityTwo"> second value </param>
        /// <returns> sum in inches </returns>
        public static double AddToInch(LengthQuantity quantityOne, LengthQuantity quantityTwo)
        {
            if (quantityOne.Unit != 0 && quantityTwo.Unit != 0)
            {
                return (double)quantityOne.Unit/(double)Units.inch * quantityOne.Length + (double)quantityTwo.Unit/(double)Units.inch * quantityTwo.Length;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        } //// end  : public static double AddToInch(LengthQuantity quantityOne, LengthQuantity quantityTwo)

      
    } //// end  : class Calculate
} //// end : namespace QuantityMeasurment
