//-----------------------------------------------------------------------
// <copyright file="WeightQuantity.cs" company="BridgeLabz Solutions LLP">
//     Copyright (c) Company. All rights reserved.
// </copyright>
// <author> Saksham Singh </author>
//-----------------------------------------------------------------------
namespace QuantityMeasurement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class WeightQuantity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeightQuantity"/> class.
        /// </summary>
        /// <param name="unit"> unit of the quantity </param>
        /// <param name="weight"> weight of the quantity </param>
        public WeightQuantity(string unit, int weight = 1)
        {
            this.Weight = weight;

            // checking if unit 
            if (Enum.TryParse(unit, true, out WeightUnits parsedUnit))
            {
                this.Unit = parsedUnit;
            }
        } //// end : public WeightQuantity(string unit, int weight =  1) 

        /// <summary>
        /// Gets or sets variable to store Weight
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Gets or sets variable to store Unit
        /// </summary>
        public WeightUnits Unit { get; set; }
    } //// end : class WeightQuantity
} //// end : namespace QuantityMeasurement