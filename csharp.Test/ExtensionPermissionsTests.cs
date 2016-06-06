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
    ///  Class for testing ExtensionPermissions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ExtensionPermissionsTests
    {
        private ExtensionPermissions instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ExtensionPermissions();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ExtensionPermissions
        /// </summary>
        [Test]
        public void ExtensionPermissionsInstanceTest()
        {
            Assert.IsInstanceOf<ExtensionPermissions> (instance, "instance is a ExtensionPermissions");
        }

        
        /// <summary>
        /// Test the property 'Admin' 
        /// </summary>
        [Test]
        public void AdminTest()
        {
            // TODO: unit test for the property 'Admin' 
        }
        
        /// <summary>
        /// Test the property 'InternationalCalling' 
        /// </summary>
        [Test]
        public void InternationalCallingTest()
        {
            // TODO: unit test for the property 'InternationalCalling' 
        }
        

    }

}