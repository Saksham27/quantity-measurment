//-----------------------------------------------------------------------
// <copyright file="ConvertTo.cs" company="BridgeLabz Solutions LLP">
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
    /// class convertTo containing method to convert from one type to another
    /// </summary>
    public class ConvertTo
    {
        /// <summary>
        /// Method to convert inch to feet
        /// </summary>
        /// <param name="inch"> value in inch </param>
        /// <returns> value in feet </returns>
        public double InchToFeet(double inch)
        {
            return inch / 12;
        } //// end : public double InchToFeet(double inch)

        /// <summary>
        /// Method to Convert feet to inch
        /// </summary>
        /// <param name="feet"> value in feet </param>
        /// <returns> value in inch </returns>
        public double FeetToInch(double feet)
        {
            return feet * 12;
        } //// end  : public double FeetToInch(double feet)

        /// <summary>
        /// method to convert 
        /// </summary>
        /// <param name="inputobj"></param>
        /// <returns></returns>
        public static double ConvertVolume(string unit)
        {
            switch (unit)
            {
                case "ml":
                    return 1;
                case "liter":
                    return 1000;
                case "gallon":
                    return 1000 * 3.78;
                default:
                    return 1; 
            }
        }
    } //// end : class ConvertTo
} //// end : namespace QuantityMeasurement