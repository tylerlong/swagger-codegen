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
    ///  Class for testing ShippingAddress
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ShippingAddressTests
    {
        private ShippingAddress instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ShippingAddress();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ShippingAddress
        /// </summary>
        [Test]
        public void ShippingAddressInstanceTest()
        {
            Assert.IsInstanceOf<ShippingAddress> (instance, "instance is a ShippingAddress");
        }

        
        /// <summary>
        /// Test the property 'CustomerName' 
        /// </summary>
        [Test]
        public void CustomerNameTest()
        {
            // TODO: unit test for the property 'CustomerName' 
        }
        
        /// <summary>
        /// Test the property 'Street' 
        /// </summary>
        [Test]
        public void StreetTest()
        {
            // TODO: unit test for the property 'Street' 
        }
        
        /// <summary>
        /// Test the property 'Street2' 
        /// </summary>
        [Test]
        public void Street2Test()
        {
            // TODO: unit test for the property 'Street2' 
        }
        
        /// <summary>
        /// Test the property 'City' 
        /// </summary>
        [Test]
        public void CityTest()
        {
            // TODO: unit test for the property 'City' 
        }
        
        /// <summary>
        /// Test the property 'State' 
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO: unit test for the property 'State' 
        }
        
        /// <summary>
        /// Test the property 'Zip' 
        /// </summary>
        [Test]
        public void ZipTest()
        {
            // TODO: unit test for the property 'Zip' 
        }
        
        /// <summary>
        /// Test the property 'Country' 
        /// </summary>
        [Test]
        public void CountryTest()
        {
            // TODO: unit test for the property 'Country' 
        }
        

    }

}
