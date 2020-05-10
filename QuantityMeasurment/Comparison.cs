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
    /// Method : <see cref="CompareLength(LengthQuantity, LengthQuantity)"/>
    /// Method : <see cref="CompareVolume(VolumeQuantity, VolumeQuantity)"/>
    /// Method : <see cref="CompareWeight(WeightQuantity, WeightQuantity)"/>
    /// Method : <see cref="CompareTemprature(TemperatureQuantity, TemperatureQuantity)"/>
    /// Method : <see cref="CompareFeetWithInch(double, double)"/>
    /// </summary>
    public class Comparison
    {
        /// <summary>
        /// creating object of ConvertTo class
        /// </summary>
        private ConvertTo convert = new ConvertTo();

        /// <summary>
        /// method to compare two length quantities
        /// </summary>
        /// <param name="quantityOne"> quantity one to compare </param>
        /// <param name="quantityTwo"> quantity two to compare </param>
        /// <returns> true or false </returns>
        public bool CompareLength(LengthQuantity quantityOne, LengthQuantity quantityTwo)
        {
            try
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
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        } //// end : public bool CompareLength(Measure quantityOne, Measure quantityTwo)

        /// <summary>
        /// method to compare two volume quantities
        /// </summary>
        /// <param name="quantityOne"> quantity one to compare </param>
        /// <param name="quantityTwo"> quantity two to compare </param>
        /// <returns> true or false </returns>
        public bool CompareVolume(VolumeQuantity quantityOne, VolumeQuantity quantityTwo)
        {
            return ConvertTo.ConvertVolume(quantityOne.Unit) * quantityOne.Volume == ConvertTo.ConvertVolume(quantityTwo.Unit) * quantityTwo.Volume;
        } //// end : public bool CompareVolume(VolumeQuantity quantityOne, VolumeQuantity quantityTwo)

        /// <summary>
        /// method to compare two volume quantities
        /// </summary>
        /// <param name="quantityOne"> quantity one to compare </param>
        /// <param name="quantityTwo"> quantity two to compare </param>
        /// <returns> true or false </returns>
        public bool CompareWeight(WeightQuantity quantityOne, WeightQuantity quantityTwo)
        {
            try
            {
                // checking if quantity unit is not 0, if yes return the inner statement
                // if not : return false
                if (quantityOne.Unit != 0 && quantityTwo.Unit != 0)
                {
                    return (int)quantityOne.Unit * quantityOne.Weight == (int)quantityTwo.Unit * quantityTwo.Weight;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        } //// end : public bool CompareWeight(WeightQuantity quantityOne, WeightQuantity quantityTwo)

        /// <summary>
        /// method to compare two volume quantities
        /// </summary>
        /// <param name="quantityOne"> quantity one to compare </param>
        /// <param name="quantityTwo"> quantity two to compare </param>
        /// <returns> true or false </returns>
        public bool CompareTemprature(TemperatureQuantity quantityOne, TemperatureQuantity quantityTwo)
        {
            try
            {
                // checking if quantity unit is not null
                // if not : return false
                if (quantityOne.Unit != null && quantityTwo.Unit != null)
                {
                    double celcius, fahrenheit;

                    // checking if quantity one is celcius, set quantity one to celcius and two to fahrenhiet
                    // if not : do reverse
                    if (quantityOne.Unit == "C")
                    {
                        celcius = quantityOne.Temp;
                        fahrenheit = quantityTwo.Temp;
                    }
                    else
                    {
                        celcius = quantityTwo.Temp;
                        fahrenheit = quantityOne.Temp;
                    }

                    return (celcius * 9 / 5) + 32 == fahrenheit;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        } //// end :  public bool CompareTemprature(TempratureQuantity quantityOne, TempratureQuantity quantityTwo)

        /// <summary>
        /// method to compare feet with inches
        /// </summary>
        /// <param name="feet"> feet input given by user </param>
        /// <param name="inch"> inch input given by user </param>
        /// <returns> true or false </returns>
        public bool CompareFeetWithInch(double feet, double inch)
        {
            try
            {
                // cheking if inch is equal to feet, return true
                // if not : return false
                if (this.convert.FeetToInch(feet) == inch)
                {
                    return true;
                }

                return false;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        } //// end : public bool CompareInchWithFeet(double inch, double feet)
    } //// end : class Comparison
} //// end : namespace QuantityMeasurment