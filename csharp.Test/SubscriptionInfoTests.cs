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
    ///  Class for testing SubscriptionInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SubscriptionInfoTests
    {
        private SubscriptionInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SubscriptionInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of SubscriptionInfo
        /// </summary>
        [Test]
        public void SubscriptionInfoInstanceTest()
        {
            Assert.IsInstanceOf<SubscriptionInfo> (instance, "instance is a SubscriptionInfo");
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
        /// Test the property 'EventFilters' 
        /// </summary>
        [Test]
        public void EventFiltersTest()
        {
            // TODO: unit test for the property 'EventFilters' 
        }
        
        /// <summary>
        /// Test the property 'ExpirationTime' 
        /// </summary>
        [Test]
        public void ExpirationTimeTest()
        {
            // TODO: unit test for the property 'ExpirationTime' 
        }
        
        /// <summary>
        /// Test the property 'ExpiresIn' 
        /// </summary>
        [Test]
        public void ExpiresInTest()
        {
            // TODO: unit test for the property 'ExpiresIn' 
        }
        
        /// <summary>
        /// Test the property 'Status' 
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO: unit test for the property 'Status' 
        }
        
        /// <summary>
        /// Test the property 'CreationTime' 
        /// </summary>
        [Test]
        public void CreationTimeTest()
        {
            // TODO: unit test for the property 'CreationTime' 
        }
        
        /// <summary>
        /// Test the property 'DeliveryMode' 
        /// </summary>
        [Test]
        public void DeliveryModeTest()
        {
            // TODO: unit test for the property 'DeliveryMode' 
        }
        

    }

}