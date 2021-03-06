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
    ///  Class for testing PhoneNumberInfoExtensionInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PhoneNumberInfoExtensionInfoTests
    {
        private PhoneNumberInfoExtensionInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PhoneNumberInfoExtensionInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of PhoneNumberInfoExtensionInfo
        /// </summary>
        [Test]
        public void PhoneNumberInfoExtensionInfoInstanceTest()
        {
            Assert.IsInstanceOf<PhoneNumberInfoExtensionInfo> (instance, "instance is a PhoneNumberInfoExtensionInfo");
        }

        
        /// <summary>
        /// Test the property 'Id' 
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id' 
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
        /// Test the property 'ExtensionNumber' 
        /// </summary>
        [Test]
        public void ExtensionNumberTest()
        {
            // TODO: unit test for the property 'ExtensionNumber' 
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
