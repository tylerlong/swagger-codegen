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
    ///  Class for testing ExtensionInfoRequestPartnerId
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ExtensionInfoRequestPartnerIdTests
    {
        private ExtensionInfoRequestPartnerId instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ExtensionInfoRequestPartnerId();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ExtensionInfoRequestPartnerId
        /// </summary>
        [Test]
        public void ExtensionInfoRequestPartnerIdInstanceTest()
        {
            Assert.IsInstanceOf<ExtensionInfoRequestPartnerId> (instance, "instance is a ExtensionInfoRequestPartnerId");
        }

        
        /// <summary>
        /// Test the property 'PartnerId' 
        /// </summary>
        [Test]
        public void PartnerIdTest()
        {
            // TODO: unit test for the property 'PartnerId' 
        }
        

    }

}
