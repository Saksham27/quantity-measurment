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
    /// class containing different calculations
    /// Method : <see cref="AddToInch(LengthQuantity, LengthQuantity)"/>
    /// Method : <see cref="AddToLiters(VolumeQuantity, VolumeQuantity)"/>
    /// Method : <see cref="AddToKg(WeightQuantity, WeightQuantity)"/>
    /// </summary>
    public class Calculate
    {
        /// <summary>
        /// method to add two length quantities
        /// </summary>
        /// <param name="quantityOne"> first value </param>
        /// <param name="quantityTwo"> second value </param>
        /// <returns> sum in inches </returns>
        public static double AddToInch(LengthQuantity quantityOne, LengthQuantity quantityTwo)
        {
            try
            {
                if (quantityOne.Unit != 0 && quantityTwo.Unit != 0)
                {
                    return (((double)quantityOne.Unit / (double)LengthUnits.inch) * quantityOne.Length) + (((double)quantityTwo.Unit / (double)LengthUnits.inch) * quantityTwo.Length);
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        } //// end  : public static double AddToInch(LengthQuantity quantityOne, LengthQuantity quantityTwo)

        /// <summary>
        /// method to add two volume quantities
        /// </summary>
        /// <param name="quantityOne"> first value </param>
        /// <param name="quantityTwo"> second value </param>
        /// <returns> sum in inches </returns>
        public static double AddToLiters(VolumeQuantity quantityOne, VolumeQuantity quantityTwo)
        {
            try
            {
                if (quantityOne.Unit != null && quantityTwo.Unit != null)
                {
                    return ((ConvertTo.ConvertVolume(quantityOne.Unit) * quantityOne.Volume) + (ConvertTo.ConvertVolume(quantityTwo.Unit) * quantityTwo.Volume)) / ConvertTo.ConvertVolume("liter");
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        } //// end  : public static double AddToLiters(VolumeQuantity quantityOne, VolumeQuantity quantityTwo)

        /// <summary>
        /// method to add two Weight quantities
        /// </summary>
        /// <param name="quantityOne"> first value </param>
        /// <param name="quantityTwo"> second value </param>
        /// <returns> sum in kg </returns>
        public static double AddToKg(WeightQuantity quantityOne, WeightQuantity quantityTwo)
        {
            try
            {
                if (quantityOne.Unit != 0 && quantityTwo.Unit != 0)
                {
                    return (((double)quantityOne.Unit / (double)WeightUnits.kg) * quantityOne.Weight) + (((double)quantityTwo.Unit / (double)WeightUnits.kg) * quantityTwo.Weight);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        } //// end  : public static double AddToKg(WeightQuantity quantityOne, WeightQuantity quantityTwo)
    } //// end  : class Calculate
} //// end : namespace QuantityMeasurment
