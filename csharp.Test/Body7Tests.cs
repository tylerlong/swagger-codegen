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
    ///  Class for testing Body7
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class Body7Tests
    {
        private Body7 instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Body7();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Body7
        /// </summary>
        [Test]
        public void Body7InstanceTest()
        {
            Assert.IsInstanceOf<Body7> (instance, "instance is a Body7");
        }

        
        /// <summary>
        /// Test the property 'From' 
        /// </summary>
        [Test]
        public void FromTest()
        {
            // TODO: unit test for the property 'From' 
        }
        
        /// <summary>
        /// Test the property 'To' 
        /// </summary>
        [Test]
        public void ToTest()
        {
            // TODO: unit test for the property 'To' 
        }
        
        /// <summary>
        /// Test the property 'Text' 
        /// </summary>
        [Test]
        public void TextTest()
        {
            // TODO: unit test for the property 'Text' 
        }
        

    }

}
