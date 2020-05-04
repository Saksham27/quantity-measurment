//-----------------------------------------------------------------------
// <copyright file="MeasurmentTest.cs" company="BridgeLabz Solutions LLP">
//     Copyright (c) Company. All rights reserved.
// </copyright>
// <author> Saksham Singh </author>
//-----------------------------------------------------------------------
namespace QuantityMeasurmentTest
{
    using NUnit.Framework;
    using QuantityMeasurment;

    /// <summary>
    /// class containing all measurement tests
    /// property : <see cref="compare"/>
    /// Test 1 : <see cref="GivenInchAndFeet_IfEqual_ShouldReturnTrue"/>
    /// Test 2 : <see cref="GivenInchAndFeet_IfNotEqual_ShouldReturnFalse"/>
    /// </summary>
    public class MeasurmentTest
    {
        /// <summary>
        /// creating object of compare class
        /// </summary>
        private readonly Comparison compare = new Comparison();

        /// <summary>
        /// Test : if given inch and feet are equal in measurement then return True
        /// </summary>
        [Test]
        public void GivenInchAndFeet_IfEqual_ShouldReturnTrue()
        {
            bool expected = true;
            bool result = this.compare.CompareInchWithFeet(24, 2);
            Assert.AreEqual(expected, result);
        } //// end : public void GivenInchAndFeet_IfEqual_ShouldReturnTrue()

        /// <summary>
        /// Test : if given inch and feet are not equal in measurement then return False
        /// </summary>
        [Test]
        public void GivenInchAndFeet_IfNotEqual_ShouldReturnFalse()
        {
            bool expected = false;
            bool result = this.compare.CompareInchWithFeet(12, 2);
            Assert.AreEqual(expected, result);
        } //// end : public void GivenInchAndFeet_IfNotEqual_ShouldReturnFalse()
    } //// end : public class MeasurmentTest
} //// end : namespace QuantityMeasurmentTest