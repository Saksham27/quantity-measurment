//-----------------------------------------------------------------------
// <copyright file="MeasurementTest.cs" company="BridgeLabz Solutions LLP">
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
    /// Test 1.7 : <see cref="GivenInchObject_CheckForNull_ShouldReturnBool"/>
    /// Test 1.8 : <see cref="GivenInchObject_CheckForReference_ShouldReturnBool"/>
    /// Test 1.9 : <see cref="GivenInchObject_CheckForType_ShouldReturnBool"/>
    /// Test 1.10 : <see cref="GivenInchObject_CheckEqualityOfValues_ReturnBool"/>
    /// Test 1.13 : <see cref="Given0Feet0Inch_ForCompare_shouldReturnTrue"/>
    /// Test 1.14 : <see cref="Given1Feet1Inch_ForCompare_shouldReturnFalse"/>
    /// Test 1.15 : <see cref="Given1Inch1Feet_ForCompare_shouldReturnFalse"/>
    /// Test 1.16 : <see cref="Given1Feet12Inch_ForCompare_shouldReturnTrue"/>
    /// Test 1.17 : <see cref="Given12Inch1Feet_ForCompare_shouldReturnTrue"/>
    /// Test 1.18 : <see cref="Given3Feet1Yard_ForCompare_shouldReturnTrue"/>
    /// Test 1.19 : <see cref="Given1Feet1Yard_ForCompare_shouldReturnFalse"/>
    /// Test 1.20 : <see cref="Given1Inch1Yard_ForCompare_shouldReturnFalse"/>
    /// Test 1.21 : <see cref="Given1Yard36Inch_ForCompare_shouldReturnTrue"/>
    /// Test 1.22 : <see cref="Given36Inch1Yard_ForCompare_shouldReturnTrue"/>
    /// 
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
                bool expected = true;
                bool result = this.compare.CompareFeetWithInch(0, 0);
                Assert.AreEqual(expected, result);
        } //// end : public void GivenInchAndFeet_IfEqual_ShouldReturnTrue()

        /// <summary>
        /// Test : if given inch and feet are not equal in measurement then return False
        /// </summary>
        [Test]
        public void GivenInchAndFeet_IfNotEqual_ShouldReturnFalse()
        {
                bool expected = false;
                bool result = this.compare.CompareFeetWithInch(12, 2);
                Assert.AreEqual(expected, result);
        } //// end : public void GivenInchAndFeet_IfNotEqual_ShouldReturnFalse()

        /// <summary>
        /// Test : if given feet object if checking for null the should return true or false
        /// </summary>
        [Test]
        public void GivenFeetObject_CheckForNull_ShouldReturnBool()
        {
                Measure feet = new Measure("feet");
                Assert.IsFalse(feet.Equals(null));
        } //// end : public void GivenFeetObject_CheckForNull_ShouldReturnBool()

        /// <summary>
        /// Test : if given feet object if checking for reference the should return true or false
        /// </summary>
        [Test]
        public void GivenFeetObject_CheckForReference_ShouldReturnBool()
        {
                // crating oject for FeetMeasurment class
                Measure feet = new Measure("feet");

                // creating another object for FeetMeasurment class
                Measure secondFeet = new Measure("feet");

                Assert.IsFalse(feet.Equals(secondFeet));
        } //// end : public void GivenFeetObject_CheckForReference_ShouldReturnBool()

        /// <summary>
        /// Test : if given feet object if checking for type the should return true or false
        /// </summary>
        [Test]
        public void GivenFeetObject_CheckForType_ShouldReturnBool()
        {
                // crating oject for FeetMeasurment class
                Measure feet = new Measure("feet");

                // creating oject for object class
                object obj = new object();

                Assert.IsFalse(feet.Equals(obj));
        } //// end : public void GivenFeetObject_CheckForType_ShouldReturnBool()

        /// <summary>
        /// Test : if given feet object if checking for value equality the should return true or false
        /// </summary>
        [Test]
        public void GivenFeetObject_CheckEqualityOfValues_ReturnBool()
        {
                // create object for Feet class
                Measure feet = new Measure("feet");

                // set values in feet object
                feet.Length = 20.5;
                Assert.IsTrue(feet.Equals(feet));
        } //// end : public void GivenFeetObject_CheckEqualityOfValues_ReturnBool()

        /// <summary>
        /// Test : if given inch object if checking for null the should return true or false
        /// </summary>
        [Test]
        public void GivenInchObject_CheckForNull_ShouldReturnBool()
        {
                Measure inch = new Measure("inch");
                Assert.IsFalse(inch.Equals(null));
        } //// end : public void GivenInchObject_CheckForNull_ShouldReturnBool()

        /// <summary>
        /// Test : if given inch object if checking for reference the should return true or false
        /// </summary>
        [Test]
        public void GivenInchObject_CheckForReference_ShouldReturnBool()
        {
                // crating oject for FeetMeasurment class
                Measure inch = new Measure("inch");

                // creating another object for FeetMeasurment class
                Measure secondInch = new Measure("inch");

                Assert.IsFalse(inch.Equals(secondInch));
        } //// end : public void GivenInchObject_CheckForReference_ShouldReturnBool()

        /// <summary>
        /// Test : if given inch object if checking for type the should return true or false
        /// </summary>
        [Test]
        public void GivenInchObject_CheckForType_ShouldReturnBool()
        {
                // crating oject for FeetMeasurment class
                Measure inch = new Measure("inch");

                // creating oject for object class
                object obj = new object();

                Assert.IsFalse(inch.Equals(obj));
        } //// end : public void GivenInchObject_CheckForType_ShouldReturnBool()

        /// <summary>
        /// Test : if given feet object if checking for value equality the should return true or false
        /// </summary>
        [Test]
        public void GivenInchObject_CheckEqualityOfValues_ReturnBool()
        {
                // create object for Feet class
                Measure inch = new Measure("inch");

                // set values in feet object
                inch.Length = 20.5;
                Assert.IsTrue(inch.Equals(inch));
        } //// end : public void GivenFeetObject_CheckEqualityOfValues_ReturnBool()

        /// <summary>
        /// Test : if given feet and inch object both 0 if checking for value equality the should return true 
        /// </summary>
        [Test]
        public void Given0Feet0Inch_ForCompare_shouldReturnTrue()
        {
            Measure inchObject = new Measure("inch", 0);
            Measure feetObject = new Measure("feet", 0);
            Assert.IsTrue(this.compare.CompareLength(inchObject, feetObject));
        } //// end : public void Given0Feet0Inch_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given feet and inch object both 1 if checking for value equality the should return false
        /// </summary>
        [Test]
        public void Given1Feet1Inch_ForCompare_shouldReturnFalse()
        {
            Measure inchObject = new Measure("inch", 1);
            Measure feetObject = new Measure("feet", 1);
            Assert.IsFalse(this.compare.CompareLength(inchObject, feetObject));
        } //// end : public void Given1Feet1Inch_ForCompare_shouldReturnFalse()

        /// <summary>
        /// Test : if given inch and feet object both 1 if checking for value equality the should return false 
        /// </summary>
        [Test]
        public void Given1Inch1Feet_ForCompare_shouldReturnFalse()
        {
            Measure inchObject = new Measure("inch", 1);
            Measure feetObject = new Measure("feet", 1);
            Assert.IsFalse(this.compare.CompareLength(inchObject, feetObject));
        } //// end : public void Given1Inch1Feet_ForCompare_shouldReturnFalse()

        /// <summary>
        /// Test : if given 1 feet and 12 inch object if checking for value equality the should return true 
        /// </summary>
        [Test]
        public void Given1Feet12Inch_ForCompare_shouldReturnTrue()
        {
            Measure inchObject = new Measure("inch", 12);
            Measure feetObject = new Measure("feet", 1);
            Assert.IsTrue(this.compare.CompareLength(inchObject, feetObject));
        } //// end : public void Given1Feet12Inch_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given 1 feet and 12 inch object if checking for value equality the should return true 
        /// </summary>
        [Test]
        public void Given12Inch1Feet_ForCompare_shouldReturnTrue()
        {
            Measure inchObject = new Measure("inch", 12);
            Measure feetObject = new Measure("feet", 1);
            Assert.IsTrue(this.compare.CompareLength(inchObject, feetObject));
        } //// end : public void Given12Inch1Feet_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given 3 feet and 1 yard object if checking for value equality the should return true 
        /// </summary>
        [Test]
        public void Given3Feet1Yard_ForCompare_shouldReturnTrue()
        {
            Measure yardObject = new Measure("yard", 1);
            Measure feetObject = new Measure("feet", 3);
            Assert.IsTrue(this.compare.CompareLength(yardObject, feetObject));
        } //// end : public void Given1Feet3Yard_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given 1 feet and 1 yard object if checking for value equality the should return false
        /// </summary>
        [Test]
        public void Given1Feet1Yard_ForCompare_shouldReturnFalse()
        {
            Measure yardObject = new Measure("yard", 1);
            Measure feetObject = new Measure("feet", 1);
            Assert.IsFalse(this.compare.CompareLength(yardObject, feetObject));
        } //// end : public void Given1Feet1Yard_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given 1 inch and 1 yard object if checking for value equality the should return false
        /// </summary>
        [Test]
        public void Given1Inch1Yard_ForCompare_shouldReturnFalse()
        {
            Measure yardObject = new Measure("yard", 1);
            Measure inchObject = new Measure("inch", 1);
            Assert.IsFalse(this.compare.CompareLength(yardObject, inchObject));
        } //// end : public void Given1Inch1Yard_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given 36 inch and 1 yard object if checking for value equality the should return true
        /// </summary>
        [Test]
        public void Given36Inch1Yard_ForCompare_shouldReturnTrue()
        {
            Measure yardObject = new Measure("yard", 1);
            Measure inchObject = new Measure("inch", 36);
            Assert.IsTrue(this.compare.CompareLength(yardObject, inchObject));
        } //// end : public void Given36Inch1Yard_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given 36 inch and 1 yard object if checking for value equality the should return true
        /// </summary>
        [Test]
        public void Given1Yard36Inch_ForCompare_shouldReturnTrue()
        {
            Measure yardObject = new Measure("yard", 1);
            Measure inchObject = new Measure("inch", 36);
            Assert.IsTrue(this.compare.CompareLength(yardObject, inchObject));
        } //// end : public void Given36Inch1Yard_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given 2 inch and 5 cm object if checking for value equality the should return true
        /// </summary>
        [Test]
        public void Given2Inch5Cm_ForCompare_shouldReturnTrue()
        {
            Measure yardObject = new Measure("cm", 5);
            Measure inchObject = new Measure("inch", 2);
            Assert.IsTrue(this.compare.CompareLength(yardObject, inchObject));
        } //// end : public void Given36Inch1Yard_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given 2 inch and inch object if adding should return 4 inch
        /// </summary>
        [Test]
        public void Given2Inch2Inch_ForSum_shouldReturn4Inch()
        {
            Measure inchObject1 = new Measure("inch", 2);
            Measure inchObject2 = new Measure("inch", 2);
            Assert.AreEqual(4, Calculate.AddToInch(inchObject2, inchObject2));
        } //// end : public void Given2Inch2Inch_ForSum_shouldReturn4Inch()

        /// <summary>
        /// Test : if given 1 feet and inch object if adding should return 14 inch
        /// </summary>
        [Test]
        public void Given1feet2Inch_ForSum_shouldReturn14Inch()
        {
            Measure feetObject = new Measure("feet", 1);
            Measure inchObject = new Measure("inch", 2);
            Assert.AreEqual(14, Calculate.AddToInch(feetObject, inchObject));
        } //// end : public void Given1feet2Inch_ForSum_shouldReturn14Inch()

        /// <summary>
        /// Test : if given 1 feet and inch object if adding should return 24 inch
        /// </summary>
        [Test]
        public void Given1Feet1Feet_ForSum_shouldReturn24Inch()
        {
            Measure feetObject1 = new Measure("feet", 1);
            Measure feetObject2 = new Measure("feet", 1);
            Assert.AreEqual(24, Calculate.AddToInch(feetObject1, feetObject2));
        } //// end : public void Given1Feet1Feet_ForSum_shouldReturn24Inch()

        /// <summary>
        /// Test : if given 2 inch and 2.5 cm object if adding should return 3 inch
        /// </summary>
        [Test]
        public void Given2Inch2andhalfCm_ForSum_shouldReturn3Inch()
        {
            Measure inchObject = new Measure("inch", 2);
            Measure cmObject = new Measure("cm", 2.5);
            Assert.AreEqual(3, Calculate.AddToInch(inchObject, cmObject));
        } //// end : public void Given1Feet1Feet_ForSum_shouldReturn24Inch()
    } //// end : public class MeasurmentTest
} //// end : namespace QuantityMeasurmentTest