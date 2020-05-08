//-----------------------------------------------------------------------
// <copyright file="LengthQuantity.cs" company="BridgeLabz Solutions LLP">
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
    /// Property : <see cref="Length"/>
    /// Method : <see cref="Equals(object)"/>
    /// </summary>
    public class LengthQuantity
    {        
        /// <summary>
        /// Initializes a new instance of the <see cref="LengthQuantity"/> class.
        /// </summary>
        /// <param name="unit"> unit of the quantity </param>
        /// <param name="length">length of the quantity </param>
        public LengthQuantity(string unit, double length = 1)
        {
            Units parsedUnit;
            this.Length = length;
            if (Enum.TryParse(unit.Trim().ToLower(), true, out parsedUnit))
            {
                this.Unit = parsedUnit;
            }
        } //// end : public FeetMeasurement(double inputFeet = 1)

        /// <summary>
        /// Gets or sets variable to store inch
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Gets or sets variable to store Unit
        /// </summary>
        public Units Unit { get; set; }

       

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
                return ((LengthQuantity)inputObject).Length == this.Length && ((LengthQuantity)inputObject).Unit == this.Unit;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        } //// end : public override bool Equals(object inputObject)
    } //// end : class InchMeasurement
} //// end : namespace QuantityMeasurment
