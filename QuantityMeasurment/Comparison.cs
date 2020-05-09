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
        public bool CompareLength(LengthQuantity quantityOne, LengthQuantity quantityTwo)
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

        public bool CompareVolume(VolumeQuantity quantityOne, VolumeQuantity quantityTwo)
        {
            return ConvertTo.ConvertVolume(quantityOne.Unit)*quantityOne.Volume == ConvertTo.ConvertVolume(quantityTwo.Unit)*quantityTwo.Volume;
        } //// end : public bool CompareVolume(VolumeQuantity quantityOne, VolumeQuantity quantityTwo)

        public bool CompareWeight(WeightQuantity quantityOne, WeightQuantity quantityTwo)
        {
            if (quantityOne.Unit != 0 && quantityTwo.Unit != 0)
            {
                return (int)quantityOne.Unit * quantityOne.Weight == (int)quantityTwo.Unit * quantityTwo.Weight;
            }
            else
            {
                return false;
            }
        }

        public bool CompareTemprature(TempratureQuantity quantityOne, TempratureQuantity quantityTwo)
        {
            if (quantityOne.Unit != null && quantityTwo.Unit != null)
            {
                double celcius, fahrenheit;
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

                return celcius * 9 / 5 + 32 == fahrenheit;
            }
            else
            {
                return false;
            }
        }

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