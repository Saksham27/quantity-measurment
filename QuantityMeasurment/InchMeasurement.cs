//-----------------------------------------------------------------------
// <copyright file="InchMeasurement.cs" company="BridgeLabz Solutions LLP">
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
    /// class containing feet measurement checks
    /// constructor : <see cref="FeetMeasurement.FeetMeasurement(double)"/>
    /// Property : <see cref="Inch"/>
    /// Method : <see cref="Equals(object)"/>
    /// </summary>
    public class InchMeasurement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InchMeasurement"/> class.
        /// </summary>
        /// <param name="inputInch"> input by user </param>
        public InchMeasurement(double inputInch = 1)
        {
            this.Inch = inputInch;
        } //// end : public FeetMeasurement(double inputFeet = 1)

        /// <summary>
        /// Gets or sets variable to store inch
        /// </summary>
        public double Inch { get; set; }

        /// <summary>
        /// override method Equals to check null, reference, type and value equality
        /// </summary>
        /// <param name="inputObject"> input object</param>
        /// <returns> true or false </returns>
        public override bool Equals(object inputObject)
        {
            try
            {
                // cheking if inputObject is null, if yes then return false
                if (inputObject == null)
                {
                    return false;
                }

                // refrence check
                if (!(inputObject == this))
                {
                    return false;
                }

                // tpye check
                if (!(inputObject.GetType() == this.GetType()))
                {
                    return false;
                }

                // value equality check
                return ((InchMeasurement)inputObject).Inch == this.Inch;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        } //// end : public override bool Equals(object inputObject)
    } //// end : class InchMeasurement
} //// end : namespace QuantityMeasurment
