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
    ///  Class for testing ServerInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ServerInfoTests
    {
        private ServerInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ServerInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ServerInfo
        /// </summary>
        [Test]
        public void ServerInfoInstanceTest()
        {
            Assert.IsInstanceOf<ServerInfo> (instance, "instance is a ServerInfo");
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
        /// Test the property 'ApiVersions' 
        /// </summary>
        [Test]
        public void ApiVersionsTest()
        {
            // TODO: unit test for the property 'ApiVersions' 
        }
        
        /// <summary>
        /// Test the property 'ServerVersion' 
        /// </summary>
        [Test]
        public void ServerVersionTest()
        {
            // TODO: unit test for the property 'ServerVersion' 
        }
        
        /// <summary>
        /// Test the property 'ServerRevision' 
        /// </summary>
        [Test]
        public void ServerRevisionTest()
        {
            // TODO: unit test for the property 'ServerRevision' 
        }
        

    }

}
