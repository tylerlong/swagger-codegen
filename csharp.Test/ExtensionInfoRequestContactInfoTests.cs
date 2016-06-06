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
    ///  Class for testing ExtensionInfoRequestContactInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ExtensionInfoRequestContactInfoTests
    {
        private ExtensionInfoRequestContactInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ExtensionInfoRequestContactInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ExtensionInfoRequestContactInfo
        /// </summary>
        [Test]
        public void ExtensionInfoRequestContactInfoInstanceTest()
        {
            Assert.IsInstanceOf<ExtensionInfoRequestContactInfo> (instance, "instance is a ExtensionInfoRequestContactInfo");
        }

        
        /// <summary>
        /// Test the property 'Contact' 
        /// </summary>
        [Test]
        public void ContactTest()
        {
            // TODO: unit test for the property 'Contact' 
        }
        
        /// <summary>
        /// Test the property 'RegionalSettings' 
        /// </summary>
        [Test]
        public void RegionalSettingsTest()
        {
            // TODO: unit test for the property 'RegionalSettings' 
        }
        
        /// <summary>
        /// Test the property 'SetupWizardState' 
        /// </summary>
        [Test]
        public void SetupWizardStateTest()
        {
            // TODO: unit test for the property 'SetupWizardState' 
        }
        
        /// <summary>
        /// Test the property 'Department' 
        /// </summary>
        [Test]
        public void DepartmentTest()
        {
            // TODO: unit test for the property 'Department' 
        }
        

    }

}