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
    ///  Class for testing RecipientInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class RecipientInfoTests
    {
        private RecipientInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RecipientInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of RecipientInfo
        /// </summary>
        [Test]
        public void RecipientInfoInstanceTest()
        {
            Assert.IsInstanceOf<RecipientInfo> (instance, "instance is a RecipientInfo");
        }

        
        /// <summary>
        /// Test the property 'Uri' 
        /// </summary>
        [Test]
        public void UriTest()
        {
            // TODO: unit test for the property 'Uri' 
        }
        
        /// <summary>
        /// Test the property 'Id' 
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id' 
        }
        

    }

}
