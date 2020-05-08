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

    public class VolumeQuantity
    {
        public VolumeQuantity(string unit, double volume = 1)
        {
            this.Volume = volume;
            this.Unit = unit;
        } //// end : public FeetMeasurement(double inputFeet = 1)

        public double Volume { get; set; }
        public string Unit { get; set; }
    }
}
