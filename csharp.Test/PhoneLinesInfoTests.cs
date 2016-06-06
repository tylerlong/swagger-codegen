using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing PhoneLinesInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PhoneLinesInfoTests
    {
        private PhoneLinesInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PhoneLinesInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of PhoneLinesInfo
        /// </summary>
        [Test]
        public void PhoneLinesInfoInstanceTest()
        {
            Assert.IsInstanceOf<PhoneLinesInfo> (instance, "instance is a PhoneLinesInfo");
        }

        
        /// <summary>
        /// Test the property 'LineType' 
        /// </summary>
        [Test]
        public void LineTypeTest()
        {
            // TODO: unit test for the property 'LineType' 
        }
        
        /// <summary>
        /// Test the property 'PhoneInfo' 
        /// </summary>
        [Test]
        public void PhoneInfoTest()
        {
            // TODO: unit test for the property 'PhoneInfo' 
        }
        

    }

}