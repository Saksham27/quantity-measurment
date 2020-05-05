//-----------------------------------------------------------------------
// <copyright file="MeasurmentTest.cs" company="BridgeLabz Solutions LLP">
//     Copyright (c) Company. All rights reserved.
// </copyright>
// <author> Saksham Singh </author>
//-----------------------------------------------------------------------
namespace QuantityMeasurementTest
{
    using System;
    using NUnit.Framework;
    using QuantityMeasurement;

    /// <summary>
    /// class containing all measurement tests
    /// property : <see cref="compare"/>
    /// Test 1.1 : <see cref="GivenInchAndFeet_IfEqual_ShouldReturnTrue"/>
    /// Test : <see cref="GivenInchAndFeet_IfNotEqual_ShouldReturnFalse"/>
    /// Test 1.2 : <see cref="GivenFeetObject_CheckForNull_ShouldReturnBool"/>
    /// Test 1.3 : <see cref="GivenFeetObject_CheckForReference_ShouldReturnBool"/>
    /// Test 1.4 : <see cref="GivenFeetObject_CheckForType_ShouldReturnBool"/>
    /// Test 1.5 : <see cref="GivenFeetObject_CheckEqualityOfValues_ReturnBool"/>
    /// </summary>
    public class MeasurementTest
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
                FeetMeasurement feet = new FeetMeasurement();
                Assert.IsFalse(feet.Equals(null));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        } //// end : public void GivenFeetObject_CheckForNull_ShouldReturnBool()

        /// <summary>
        /// Test : if given feet object if checing for reference the should return bool
        /// </summary>
        [Test]
        public void GivenFeetObject_CheckForReference_ShouldReturnBool()
        {
            try
            {
                // crating oject for FeetMeasurment class
                FeetMeasurement feet = new FeetMeasurement();

                // creating another object for FeetMeasurment class
                FeetMeasurement secondFeet = new FeetMeasurement();

                Assert.IsFalse(feet.Equals(secondFeet));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        } //// end : public void GivenFeetObject_CheckForReference_ShouldReturnBool()

        /// <summary>
        /// Test : if given feet object if checing for type the should return bool
        /// </summary>
        [Test]
        public void GivenFeetObject_CheckForType_ShouldReturnBool()
        {
            try
            {
                // crating oject for FeetMeasurment class
                FeetMeasurement feet = new FeetMeasurement();

                // creating oject for object class
                object obj = new object();

                Assert.IsFalse(feet.Equals(obj));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        } //// end : public void GivenFeetObject_CheckForType_ShouldReturnBool()

        /// <summary>
        /// Test : if given feet object if checing for value equality the should return bool
        /// </summary>
        [Test]
        public void GivenFeetObject_CheckEqualityOfValues_ReturnBool()
        {
            try
            {
                // create object for Feet class
                FeetMeasurement feet = new FeetMeasurement();
                // set values in feet object
                feet.Feet = 20.5;
                Assert.IsTrue(feet.Equals(feet));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        } //// end : public void GivenFeetObject_CheckEqualityOfValues_ReturnBool()

        /// <summary>
        /// Test : if given inch object if checing for null the should return bool
        /// </summary>
        [Test]
        public void GivenInchObject_CheckForNull_ShouldReturnBool()
        {
            try
            {
                InchMeasurement inch = new InchMeasurement();
                Assert.IsFalse(inch.Equals(null));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        } //// end : public void GivenInchObject_CheckForNull_ShouldReturnBool()
    } //// end : public class MeasurmentTest
} //// end : namespace QuantityMeasurmentTest