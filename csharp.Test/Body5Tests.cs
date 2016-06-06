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
    ///  Class for testing Body5
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class Body5Tests
    {
        private Body5 instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Body5();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Body5
        /// </summary>
        [Test]
        public void Body5InstanceTest()
        {
            Assert.IsInstanceOf<Body5> (instance, "instance is a Body5");
        }

        
        /// <summary>
        /// Test the property 'ReadStatus' 
        /// </summary>
        [Test]
        public void ReadStatusTest()
        {
            // TODO: unit test for the property 'ReadStatus' 
        }
        

    }

}