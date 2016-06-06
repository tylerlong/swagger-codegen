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
    ///  Class for testing LocationInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LocationInfoTests
    {
        private LocationInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LocationInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of LocationInfo
        /// </summary>
        [Test]
        public void LocationInfoInstanceTest()
        {
            Assert.IsInstanceOf<LocationInfo> (instance, "instance is a LocationInfo");
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
        /// Test the property 'AreaCode' 
        /// </summary>
        [Test]
        public void AreaCodeTest()
        {
            // TODO: unit test for the property 'AreaCode' 
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
        /// Test the property 'Npa' 
        /// </summary>
        [Test]
        public void NpaTest()
        {
            // TODO: unit test for the property 'Npa' 
        }
        
        /// <summary>
        /// Test the property 'Nxx' 
        /// </summary>
        [Test]
        public void NxxTest()
        {
            // TODO: unit test for the property 'Nxx' 
        }
        
        /// <summary>
        /// Test the property 'State' 
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO: unit test for the property 'State' 
        }
        

    }

}
