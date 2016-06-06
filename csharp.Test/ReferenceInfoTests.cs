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
    ///  Class for testing ReferenceInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ReferenceInfoTests
    {
        private ReferenceInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReferenceInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ReferenceInfo
        /// </summary>
        [Test]
        public void ReferenceInfoInstanceTest()
        {
            Assert.IsInstanceOf<ReferenceInfo> (instance, "instance is a ReferenceInfo");
        }

        
        /// <summary>
        /// Test the property '_Ref' 
        /// </summary>
        [Test]
        public void _RefTest()
        {
            // TODO: unit test for the property '_Ref' 
        }
        
        /// <summary>
        /// Test the property 'Type' 
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO: unit test for the property 'Type' 
        }
        

    }

}