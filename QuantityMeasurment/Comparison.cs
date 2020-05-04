//-----------------------------------------------------------------------
// <copyright file="Comparison.cs" company="BridgeLabz Solutions LLP">
//     Copyright (c) Company. All rights reserved.
// </copyright>
// <author> Saksham Singh </author>
//-----------------------------------------------------------------------
namespace QuantityMeasurment
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// comparison class containing different comparisons
    /// Method : <see cref="CompareInchWithFeet(double, double)"/>
    /// </summary>
    public class Comparison
    {
        /// <summary>
        /// method to compare inches with feet
        /// </summary>
        /// <param name="inch"> inch input given by user </param>
        /// <param name="feet"> feet input given by user </param>
        /// <returns> true is both equal else false </returns>
        public bool CompareInchWithFeet(double inch, double feet)
        {
            // cheking if inch is equal to feet, return true
            // if not : return false
            if (inch / 12 == feet)
            {
                return true;
            }

            return false;
        } //// end : public bool CompareInchWithFeet(double inch, double feet)
    } //// end : class Comparison
} //// end : namespace QuantityMeasurment