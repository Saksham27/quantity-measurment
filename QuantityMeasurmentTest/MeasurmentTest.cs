//-----------------------------------------------------------------------
// <copyright file="MeasurmentTest.cs" company="BridgeLabz Solutions LLP">
//     Copyright (c) Company. All rights reserved.
// </copyright>
// <author> Saksham Singh </author>
//-----------------------------------------------------------------------
namespace QuantityMeasurmentTest
{
    using System;
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
            try
            {
                bool expected = true;
                bool result = this.compare.CompareInchWithFeet(0, 0);
                Assert.AreEqual(expected, result);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        } //// end : public void GivenInchAndFeet_IfEqual_ShouldReturnTrue()

        /// <summary>
        /// Test : if given inch and feet are not equal in measurement then return False
        /// </summary>
        [Test]
        public void GivenInchAndFeet_IfNotEqual_ShouldReturnFalse()
        {
            try
            {
                bool expected = false;
                bool result = this.compare.CompareInchWithFeet(12, 2);
                Assert.AreEqual(expected, result);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        } //// end : public void GivenInchAndFeet_IfNotEqual_ShouldReturnFalse()

        /// <summary>
        /// Test : if given feet object if checing for null the should return bool
        /// </summary>
        [Test]
        public void GivenFeetObject_CheckForNull_ShouldReturnBool()
        {
            try
            {
                FeetMesurment feet = new FeetMesurment();
                Assert.IsFalse(feet.Equals(null));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        } //// end : public void GivenInchAndFeet_IfNotEqual_ShouldReturnFalse()
    } //// end : public class MeasurmentTest
} //// end : namespace QuantityMeasurmentTest