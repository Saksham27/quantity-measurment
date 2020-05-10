//-----------------------------------------------------------------------
// <copyright file="Units.cs" company="BridgeLabz Solutions LLP">
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
    /// Enumeration constants for Length Units
    /// </summary>
    public enum LengthUnits 
    {
        /// <summary>
        /// setting base value for inch 
        /// </summary>
        inch = 5,

        /// <summary>
        /// setting base value for feet
        /// </summary>
        feet = 60,

        /// <summary>
        /// setting base value for yard
        /// </summary>
        yard = 180,

        /// <summary>
        /// setting base value for cm
        /// </summary>
        cm = 2
    } //// end : public enum Units

    /// <summary>
    /// Enumeration constants for Weight Units
    /// </summary>
    public enum WeightUnits
    {
        /// <summary>
        /// setting base value for gram
        /// </summary>
        gram = 1,

        /// <summary>
        /// setting base value for kg
        /// </summary>
        kg = 1000,

        /// <summary>
        /// setting base value for ton
        /// </summary>
        ton = 1000000
    } //// end : public enum WeightUnits
} //// end : namespace QuantityMeasurement
