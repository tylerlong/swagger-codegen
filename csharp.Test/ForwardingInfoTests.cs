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
    ///  Class for testing ForwardingInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ForwardingInfoTests
    {
        private ForwardingInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ForwardingInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ForwardingInfo
        /// </summary>
        [Test]
        public void ForwardingInfoInstanceTest()
        {
            Assert.IsInstanceOf<ForwardingInfo> (instance, "instance is a ForwardingInfo");
        }

        
        /// <summary>
        /// Test the property 'NotifyMySoftPhones' 
        /// </summary>
        [Test]
        public void NotifyMySoftPhonesTest()
        {
            // TODO: unit test for the property 'NotifyMySoftPhones' 
        }
        
        /// <summary>
        /// Test the property 'NotifyAdminSoftPhones' 
        /// </summary>
        [Test]
        public void NotifyAdminSoftPhonesTest()
        {
            // TODO: unit test for the property 'NotifyAdminSoftPhones' 
        }
        
        /// <summary>
        /// Test the property 'SoftPhonesRingCount' 
        /// </summary>
        [Test]
        public void SoftPhonesRingCountTest()
        {
            // TODO: unit test for the property 'SoftPhonesRingCount' 
        }
        
        /// <summary>
        /// Test the property 'RingingMode' 
        /// </summary>
        [Test]
        public void RingingModeTest()
        {
            // TODO: unit test for the property 'RingingMode' 
        }
        
        /// <summary>
        /// Test the property 'Rules' 
        /// </summary>
        [Test]
        public void RulesTest()
        {
            // TODO: unit test for the property 'Rules' 
        }
        

    }

}
