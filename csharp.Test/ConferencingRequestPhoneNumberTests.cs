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
    ///  Class for testing ConferencingRequestPhoneNumber
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ConferencingRequestPhoneNumberTests
    {
        private ConferencingRequestPhoneNumber instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConferencingRequestPhoneNumber();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ConferencingRequestPhoneNumber
        /// </summary>
        [Test]
        public void ConferencingRequestPhoneNumberInstanceTest()
        {
            Assert.IsInstanceOf<ConferencingRequestPhoneNumber> (instance, "instance is a ConferencingRequestPhoneNumber");
        }

        
        /// <summary>
        /// Test the property 'PhoneNumber' 
        /// </summary>
        [Test]
        public void PhoneNumberTest()
        {
            // TODO: unit test for the property 'PhoneNumber' 
        }
        
        /// <summary>
        /// Test the property '_Default' 
        /// </summary>
        [Test]
        public void _DefaultTest()
        {
            // TODO: unit test for the property '_Default' 
        }
        

    }

}
