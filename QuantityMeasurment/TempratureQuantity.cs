//-----------------------------------------------------------------------
// <copyright file="TempratureQuantity.cs" company="BridgeLabz Solutions LLP">
//     Copyright (c) Company. All rights reserved.
// </copyright>
// <author> Saksham Singh </author>
//-----------------------------------------------------------------------
namespace QuantityMeasurement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TempratureQuantity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeightQuantity"/> class.
        /// </summary>
        /// <param name="unit"> unit of the quantity </param>
        /// <param name="temp"> weight of the quantity </param>
        public TempratureQuantity(string unit, int temp = 1)
        {
            this.Temp = temp;
            this.Unit = unit;
        } //// end : public WeightQuantity(string unit, int weight =  1) 

        /// <summary>
        /// Gets or sets variable to store Weight
        /// </summary>
        public double Temp { get; set; }

        /// <summary>
        /// Gets or sets variable to store Unit
        /// </summary>
        public string Unit { get; set; }
    } //// end : class WeightQuantity
}

