//-----------------------------------------------------------------------
// <copyright file="Comparison.cs" company="BridgeLabz Solutions LLP">
//     Copyright (c) Company. All rights reserved.
// </copyright>
// <author> Saksham Singh </author>
//-----------------------------------------------------------------------
namespace QuantityMeasurement
{
    using QuantityMeasurment;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// comparison class containing different comparisons
    /// Method : <see cref="CompareLength(double, double)"/>
    /// </summary>
    public class Comparison
    {
        private ConvertTo convert = new ConvertTo();

        /// <summary>
        /// method to compare inches with feet
        /// </summary>
        /// <param name="inch"> inch input given by user </param>
        /// <param name="feet"> feet input given by user </param>
        /// <returns> true is both equal else false </returns>
        public bool CompareLength(Measure quantityOne, Measure quantityTwo)
        {
            if (quantityOne.Unit == quantityTwo.Unit)
            {
                if (quantityOne.Length == quantityTwo.Length)
                {
                    return true;
                }
                return false;
            }
            else
            {
                ConvertTo convert = new ConvertTo();
                if(quantityOne.Unit == "inch" && quantityTwo.Unit == "feet")
                {
                    return convert.InchToFeet(quantityOne.Length) == quantityTwo.Length;
                }
                return convert.FeetToInch(quantityOne.Length) == quantityTwo.Length;
            }
        } //// end : public bool CompareInchWithFeet(double inch, double feet)

        public bool CompareFeetWithInch(double feet, double inch)
        {
            // cheking if inch is equal to feet, return true
            // if not : return false
            if (convert.FeetToInch(feet) == inch)
            {
                return true;
            }

            return false;
        } //// end : public bool CompareInchWithFeet(double inch, double feet)
    } //// end : class Comparison
} //// end : namespace QuantityMeasurment