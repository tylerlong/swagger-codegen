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
    ///  Class for testing DeliveryMode
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DeliveryModeTests
    {
        private DeliveryMode instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DeliveryMode();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DeliveryMode
        /// </summary>
        [Test]
        public void DeliveryModeInstanceTest()
        {
            Assert.IsInstanceOf<DeliveryMode> (instance, "instance is a DeliveryMode");
        }

        
        /// <summary>
        /// Test the property 'TransportType' 
        /// </summary>
        [Test]
        public void TransportTypeTest()
        {
            // TODO: unit test for the property 'TransportType' 
        }
        
        /// <summary>
        /// Test the property 'Encryption' 
        /// </summary>
        [Test]
        public void EncryptionTest()
        {
            // TODO: unit test for the property 'Encryption' 
        }
        
        /// <summary>
        /// Test the property 'Address' 
        /// </summary>
        [Test]
        public void AddressTest()
        {
            // TODO: unit test for the property 'Address' 
        }
        
        /// <summary>
        /// Test the property 'SubscriberKey' 
        /// </summary>
        [Test]
        public void SubscriberKeyTest()
        {
            // TODO: unit test for the property 'SubscriberKey' 
        }
        
        /// <summary>
        /// Test the property 'SecretKey' 
        /// </summary>
        [Test]
        public void SecretKeyTest()
        {
            // TODO: unit test for the property 'SecretKey' 
        }
        
        /// <summary>
        /// Test the property 'EncryptionAlgorithm' 
        /// </summary>
        [Test]
        public void EncryptionAlgorithmTest()
        {
            // TODO: unit test for the property 'EncryptionAlgorithm' 
        }
        
        /// <summary>
        /// Test the property 'EncryptionKey' 
        /// </summary>
        [Test]
        public void EncryptionKeyTest()
        {
            // TODO: unit test for the property 'EncryptionKey' 
        }
        

    }

}
