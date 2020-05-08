//-----------------------------------------------------------------------
// <copyright file="Comparison.cs" company="BridgeLabz Solutions LLP">
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
    /// comparison class containing different comparisons
    /// Method : <see cref="CompareLength(double, double)"/>
    /// </summary>
    public class Comparison
    {
        /// <summary>
        /// creating object of ConvertTo class
        /// </summary>
        private ConvertTo convert = new ConvertTo();

        /// <summary>
        /// method to compare inches with feet
        /// </summary>
        /// <param name="quantityOne"> quantity one to compare </param>
        /// <param name="quantityTwo"> quantity two to compare </param>
        /// <returns> true or false </returns>
        public bool CompareLength(Measure quantityOne, Measure quantityTwo)
        {
            // checking if quantity unit is not 0, if yes return the inner statement
            // if not : return false
            if (quantityOne.Unit != 0 && quantityTwo.Unit != 0)
            {
                return (int)quantityOne.Unit * quantityOne.Length == (int)quantityTwo.Unit * quantityTwo.Length;
            }
            else
            {
                return false;
            }
        } //// end : public bool CompareLength(Measure quantityOne, Measure quantityTwo)

        /// <summary>
        /// method to compare feet with inches
        /// </summary>
        /// <param name="feet"> feet input given by user </param>
        /// <param name="inch"> inch input given by user </param>
        /// <returns> true or false </returns>
        public bool CompareFeetWithInch(double feet, double inch)
        {
            // cheking if inch is equal to feet, return true
            // if not : return false
            if (this.convert.FeetToInch(feet) == inch)
            {
                return true;
            }

            return false;
        } //// end : public bool CompareInchWithFeet(double inch, double feet)
    } //// end : class Comparison
} //// end : namespace QuantityMeasurment