//-----------------------------------------------------------------------
// <copyright file="VolumeQuantity.cs" company="BridgeLabz Solutions LLP">
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
    /// class containing volume quantity properties
    /// Constructor : <see cref="VolumeQuantity.VolumeQuantity(string, double)"/>
    /// Property : <see cref="Volume"/>
    /// Property : <see cref="Unit"/>
    /// </summary>
    public class VolumeQuantity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeQuantity"/> class.
        /// </summary>
        /// <param name="unit"> unit of the quantity </param>
        /// <param name="volume"> volume of the quantity </param>
        public VolumeQuantity(string unit, double volume = 1)
        {
            this.Volume = volume;
            this.Unit = unit;
        } //// end : public FeetMeasurement(double inputFeet = 1)

        /// <summary>
        /// Gets or sets variable to store Volume
        /// </summary>
        public double Volume { get; set; }

        /// <summary>
        /// Gets or sets variable to store UnitsS
        /// </summary>
        public string Unit { get; set; }
    }
}
