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
    ///  Class for testing RingOutRequestFrom
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class RingOutRequestFromTests
    {
        private RingOutRequestFrom instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RingOutRequestFrom();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of RingOutRequestFrom
        /// </summary>
        [Test]
        public void RingOutRequestFromInstanceTest()
        {
            Assert.IsInstanceOf<RingOutRequestFrom> (instance, "instance is a RingOutRequestFrom");
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
        /// Test the property 'ForwardingNumberId' 
        /// </summary>
        [Test]
        public void ForwardingNumberIdTest()
        {
            // TODO: unit test for the property 'ForwardingNumberId' 
        }
        

    }

}
