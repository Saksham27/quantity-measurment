//-----------------------------------------------------------------------
// <copyright file="FeetMeasurement.cs" company="BridgeLabz Solutions LLP">
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
    /// Property : <see cref="Feet"/>
    /// Method : <see cref="Equals(object)"/>
    /// </summary>
    public class FeetMeasurement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeetMeasurement"/> class.
        /// </summary>
        /// <param name="inputFeet"> input by user </param>
        public FeetMeasurement(double inputFeet = 1)
        {
            this.Feet = inputFeet;
        } //// end : public FeetMeasurement(double inputFeet = 1)

        /// <summary>
        /// Gets or sets variable to store feet
        /// </summary>
        public double Feet { get; set; }

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
                return ((FeetMeasurement)inputObject).Feet == this.Feet;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        } //// end :  public override bool Equals(object inputObject)
    } //// end : public class FeetMeasurement
} //// end : namespace QuantityMeasurement
