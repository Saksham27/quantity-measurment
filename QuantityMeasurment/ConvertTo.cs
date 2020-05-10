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
    /// Method : <see cref="ConvertVolume(string)"/>
    /// Method : <see cref="InchToFeet(double)"/>
    /// Method : <see cref="FeetToInch(double)"/>
    /// </summary>
    public class ConvertTo
    {
        /// <summary>
        /// method to convert volume
        /// </summary>
        /// <param name="unit"> volume unit in string </param>
        /// <returns> value according to unit </returns>
        public static double ConvertVolume(string unit)
        {
            try
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
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        } //// end : public static double ConvertVolume(string unit)

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
    } //// end : public class ConvertTo
} //// end : namespace QuantityMeasurement