//-----------------------------------------------------------------------
// <copyright file="MeasurementTest.cs" company="BridgeLabz Solutions LLP">
//     Copyright (c) Company. All rights reserved.
// </copyright>
// <author> Saksham Singh </author>
//-----------------------------------------------------------------------
namespace QuantityMeasurement
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
    /// Test 1.23 : <see cref="Given2Inch5Cm_ForCompare_shouldReturnTrue"/>
    /// Test 1.24 : <see cref="Given2Inch2Inch_ForSum_shouldReturn4Inch"/>
    /// Test 1.25 : <see cref="Given2Inch2andhalfCm_ForSum_shouldReturn3Inch"/>
    /// Test 1.26 : <see cref="Given1Feet1Feet_ForSum_shouldReturn24Inch"/>
    /// Test 1.27 : <see cref="Given1feet2Inch_ForSum_shouldReturn14Inch"/>
    /// Test 1.28 : <see cref="Given1Literand1000Ml_ForCompare_shouldReturnTrue"/>
    /// Test 1.29 : <see cref="Given1GallonandLiter_ForCompare_shouldReturnTrue"/>
    /// Test 1.30 : <see cref="GivenGallonAndLitre_ForSum_shouldReturnSumInLitre"/>
    /// Test 1.31 : <see cref="Given1KgAnd1000Grams_ForCompare_shouldReturnTrue"/>
    /// Test 1.32 : <see cref="Given1TonAnd1000Kg_ForCompare_shouldReturnTrue"/>
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
                LengthQuantity feet = new LengthQuantity("feet");
                Assert.IsFalse(feet.Equals(null));
        } //// end : public void GivenFeetObject_CheckForNull_ShouldReturnBool()

        /// <summary>
        /// Test : if given feet object if checking for reference the should return true or false
        /// </summary>
        [Test]
        public void GivenFeetObject_CheckForReference_ShouldReturnBool()
        {
                // crating oject for FeetMeasurment class
                LengthQuantity feet = new LengthQuantity("feet");

                // creating another object for FeetMeasurment class
                LengthQuantity secondFeet = new LengthQuantity("feet");

                Assert.IsFalse(feet.Equals(secondFeet));
        } //// end : public void GivenFeetObject_CheckForReference_ShouldReturnBool()

        /// <summary>
        /// Test : if given feet object if checking for type the should return true or false
        /// </summary>
        [Test]
        public void GivenFeetObject_CheckForType_ShouldReturnBool()
        {
                // crating oject for FeetMeasurment class
                LengthQuantity feet = new LengthQuantity("feet");

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
                LengthQuantity feet = new LengthQuantity("feet");

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
                LengthQuantity inch = new LengthQuantity("inch");
                Assert.IsFalse(inch.Equals(null));
        } //// end : public void GivenInchObject_CheckForNull_ShouldReturnBool()

        /// <summary>
        /// Test : if given inch object if checking for reference the should return true or false
        /// </summary>
        [Test]
        public void GivenInchObject_CheckForReference_ShouldReturnBool()
        {
                // crating oject for FeetMeasurment class
                LengthQuantity inch = new LengthQuantity("inch");

                // creating another object for FeetMeasurment class
                LengthQuantity secondInch = new LengthQuantity("inch");

                Assert.IsFalse(inch.Equals(secondInch));
        } //// end : public void GivenInchObject_CheckForReference_ShouldReturnBool()

        /// <summary>
        /// Test : if given inch object if checking for type the should return true or false
        /// </summary>
        [Test]
        public void GivenInchObject_CheckForType_ShouldReturnBool()
        {
                // crating oject for FeetMeasurment class
                LengthQuantity inch = new LengthQuantity("inch");

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
                LengthQuantity inch = new LengthQuantity("inch");

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
            LengthQuantity inchObject = new LengthQuantity("inch", 0);
            LengthQuantity feetObject = new LengthQuantity("feet", 0);
            Assert.IsTrue(this.compare.CompareLength(inchObject, feetObject));
        } //// end : public void Given0Feet0Inch_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given feet and inch object both 1 if checking for value equality the should return false
        /// </summary>
        [Test]
        public void Given1Feet1Inch_ForCompare_shouldReturnFalse()
        {
            LengthQuantity inchObject = new LengthQuantity("inch", 1);
            LengthQuantity feetObject = new LengthQuantity("feet", 1);
            Assert.IsFalse(this.compare.CompareLength(inchObject, feetObject));
        } //// end : public void Given1Feet1Inch_ForCompare_shouldReturnFalse()

        /// <summary>
        /// Test : if given inch and feet object both 1 if checking for value equality the should return false 
        /// </summary>
        [Test]
        public void Given1Inch1Feet_ForCompare_shouldReturnFalse()
        {
            LengthQuantity inchObject = new LengthQuantity("inch", 1);
            LengthQuantity feetObject = new LengthQuantity("feet", 1);
            Assert.IsFalse(this.compare.CompareLength(inchObject, feetObject));
        } //// end : public void Given1Inch1Feet_ForCompare_shouldReturnFalse()

        /// <summary>
        /// Test : if given 1 feet and 12 inch object if checking for value equality the should return true 
        /// </summary>
        [Test]
        public void Given1Feet12Inch_ForCompare_shouldReturnTrue()
        {
            LengthQuantity inchObject = new LengthQuantity("inch", 12);
            LengthQuantity feetObject = new LengthQuantity("feet", 1);
            Assert.IsTrue(this.compare.CompareLength(inchObject, feetObject));
        } //// end : public void Given1Feet12Inch_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given 1 feet and 12 inch object if checking for value equality the should return true 
        /// </summary>
        [Test]
        public void Given12Inch1Feet_ForCompare_shouldReturnTrue()
        {
            LengthQuantity inchObject = new LengthQuantity("inch", 12);
            LengthQuantity feetObject = new LengthQuantity("feet", 1);
            Assert.IsTrue(this.compare.CompareLength(inchObject, feetObject));
        } //// end : public void Given12Inch1Feet_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given 3 feet and 1 yard object if checking for value equality the should return true 
        /// </summary>
        [Test]
        public void Given3Feet1Yard_ForCompare_shouldReturnTrue()
        {
            LengthQuantity yardObject = new LengthQuantity("yard", 1);
            LengthQuantity feetObject = new LengthQuantity("feet", 3);
            Assert.IsTrue(this.compare.CompareLength(yardObject, feetObject));
        } //// end : public void Given1Feet3Yard_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given 1 feet and 1 yard object if checking for value equality the should return false
        /// </summary>
        [Test]
        public void Given1Feet1Yard_ForCompare_shouldReturnFalse()
        {
            LengthQuantity yardObject = new LengthQuantity("yard", 1);
            LengthQuantity feetObject = new LengthQuantity("feet", 1);
            Assert.IsFalse(this.compare.CompareLength(yardObject, feetObject));
        } //// end : public void Given1Feet1Yard_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given 1 inch and 1 yard object if checking for value equality the should return false
        /// </summary>
        [Test]
        public void Given1Inch1Yard_ForCompare_shouldReturnFalse()
        {
            LengthQuantity yardObject = new LengthQuantity("yard", 1);
            LengthQuantity inchObject = new LengthQuantity("inch", 1);
            Assert.IsFalse(this.compare.CompareLength(yardObject, inchObject));
        } //// end : public void Given1Inch1Yard_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given 36 inch and 1 yard object if checking for value equality the should return true
        /// </summary>
        [Test]
        public void Given36Inch1Yard_ForCompare_shouldReturnTrue()
        {
            LengthQuantity yardObject = new LengthQuantity("yard", 1);
            LengthQuantity inchObject = new LengthQuantity("inch", 36);
            Assert.IsTrue(this.compare.CompareLength(yardObject, inchObject));
        } //// end : public void Given36Inch1Yard_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given 36 inch and 1 yard object if checking for value equality the should return true
        /// </summary>
        [Test]
        public void Given1Yard36Inch_ForCompare_shouldReturnTrue()
        {
            LengthQuantity yardObject = new LengthQuantity("yard", 1);
            LengthQuantity inchObject = new LengthQuantity("inch", 36);
            Assert.IsTrue(this.compare.CompareLength(yardObject, inchObject));
        } //// end : public void Given36Inch1Yard_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given 2 inch and 5 cm object if checking for value equality the should return true
        /// </summary>
        [Test]
        public void Given2Inch5Cm_ForCompare_shouldReturnTrue()
        {
            LengthQuantity yardObject = new LengthQuantity("cm", 5);
            LengthQuantity inchObject = new LengthQuantity("inch", 2);
            Assert.IsTrue(this.compare.CompareLength(yardObject, inchObject));
        } //// end : public void Given36Inch1Yard_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given 2 inch and inch object if adding should return 4 inch
        /// </summary>
        [Test]
        public void Given2Inch2Inch_ForSum_shouldReturn4Inch()
        {
            LengthQuantity inchObject1 = new LengthQuantity("inch", 2);
            LengthQuantity inchObject2 = new LengthQuantity("inch", 2);
            Assert.AreEqual(4, Calculate.AddToInch(inchObject2, inchObject2));
        } //// end : public void Given2Inch2Inch_ForSum_shouldReturn4Inch()

        /// <summary>
        /// Test : if given 1 feet and inch object if adding should return 14 inch
        /// </summary>
        [Test]
        public void Given1feet2Inch_ForSum_shouldReturn14Inch()
        {
            LengthQuantity feetObject = new LengthQuantity("feet", 1);
            LengthQuantity inchObject = new LengthQuantity("inch", 2);
            Assert.AreEqual(14, Calculate.AddToInch(feetObject, inchObject));
        } //// end : public void Given1feet2Inch_ForSum_shouldReturn14Inch()

        /// <summary>
        /// Test : if given 1 feet and inch object if adding should return 24 inch
        /// </summary>
        [Test]
        public void Given1Feet1Feet_ForSum_shouldReturn24Inch()
        {
            LengthQuantity feetObject1 = new LengthQuantity("feet", 1);
            LengthQuantity feetObject2 = new LengthQuantity("feet", 1);
            Assert.AreEqual(24, Calculate.AddToInch(feetObject1, feetObject2));
        } //// end : public void Given1Feet1Feet_ForSum_shouldReturn24Inch()

        /// <summary>
        /// Test : if given 2 inch and 2.5 cm object if adding should return 3 inch
        /// </summary>
        [Test]
        public void Given2Inch2andhalfCm_ForSum_shouldReturn3Inch()
        {
            LengthQuantity inchObject = new LengthQuantity("inch", 2);
            LengthQuantity cmObject = new LengthQuantity("cm", 2.5);
            Assert.AreEqual(3, Calculate.AddToInch(inchObject, cmObject));
        } //// end : public void Given1Feet1Feet_ForSum_shouldReturn24Inch()

        /// <summary>
        /// Test : if given 1 gallon and 3.78 liter object if comparing should return true
        /// </summary>
        [Test]
        public void Given1GallonandLiter_ForCompare_shouldReturnTrue()
        {
            VolumeQuantity gallonObject = new VolumeQuantity("gallon",1);
            VolumeQuantity literObject = new VolumeQuantity("liter",3.78);
            Assert.IsTrue(this.compare.CompareVolume(gallonObject, literObject));
        } //// end : public void Given1GallonandLiter_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given 1 litre and 1000 ml object if comparing should return true
        /// </summary>
        [Test]
        public void Given1Literand1000Ml_ForCompare_shouldReturnTrue()
        {
            VolumeQuantity mlObject = new VolumeQuantity("ml", 1000);
            VolumeQuantity literObject = new VolumeQuantity("liter", 1);
            Assert.IsTrue(this.compare.CompareVolume(mlObject, literObject));
        } //// end : public void Given1Literand1000Ml_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given 2 inch and 2.5 cm object if adding should return 3 inch
        /// </summary>
        [Test]
        public void GivenGallonAndLitre_ForSum_shouldReturnSumInLitre()
        {
            VolumeQuantity gallonObject = new VolumeQuantity("gallon", 1);
            VolumeQuantity literObject = new VolumeQuantity("liter", 3.78);
            Assert.AreEqual(7.57,Math.Round(Calculate.AddToLiters(gallonObject, literObject)),2);
        } //// end : public void GivenGallonAndLitre_ForSum_shouldReturnSumInLitre()

        /// <summary>
        /// Test : if given 1 kg and 1000 grams object if checking for value equality the should return true
        /// </summary>
        [Test]
        public void Given1KgAnd1000Grams_ForCompare_shouldReturnTrue()
        {
            WeightQuantity kgObject = new WeightQuantity("kg", 1);
            WeightQuantity gramObject = new WeightQuantity("gram", 1000);
            Assert.IsTrue(this.compare.CompareWeight(kgObject, gramObject));
        } //// end : public void Given1KgAnd1000Grams_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given 1 ton and 1000 kg object if checking for value equality the should return true
        /// </summary>
        [Test]
        public void Given1TonAnd1000Kg_ForCompare_shouldReturnTrue()
        {
            WeightQuantity tonObject = new WeightQuantity("ton", 1);
            WeightQuantity kgObject = new WeightQuantity("kg", 1000);
            Assert.IsTrue(this.compare.CompareWeight(tonObject, kgObject));
        } //// end : public void Given1TonAnd1000Kg_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given 1 ton and 1000 gram object if adding for should return 1001 kg
        /// </summary>
        [Test]
        public void Given1TonAnd1000Kg_ForSum_shouldReturn1001Kg()
        {
            WeightQuantity tonObject = new WeightQuantity("ton", 1);
            WeightQuantity gramObject = new WeightQuantity("gram", 1000);
            Assert.AreEqual(1001, Calculate.AddToKg(tonObject, gramObject));
        } //// end : public void Given1TonAnd1000Kg_ForCompare_shouldReturnTrue()

        /// <summary>
        /// Test : if given 1 ton and 1000 kg object if checking for value equality the should return true
        /// </summary>
        [Test]
        public void Given212FAnd100C_ForCompare_shouldReturnTrue()
        {
            TempratureQuantity fahrenheitObject = new TempratureQuantity("F", 212);
            TempratureQuantity celciusObject = new TempratureQuantity("C", 100);
            Assert.IsTrue(this.compare.CompareTemprature(fahrenheitObject, celciusObject));
        } //// end : public void Given1TonAnd1000Kg_ForCompare_shouldReturnTrue()

    } //// end : public class MeasurmentTest
} //// end : namespace QuantityMeasurmentTest