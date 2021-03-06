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
    ///  Class for testing ExtensionInfoRequestContactInfoRegionalSettingsLanguage
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ExtensionInfoRequestContactInfoRegionalSettingsLanguageTests
    {
        private ExtensionInfoRequestContactInfoRegionalSettingsLanguage instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ExtensionInfoRequestContactInfoRegionalSettingsLanguage();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ExtensionInfoRequestContactInfoRegionalSettingsLanguage
        /// </summary>
        [Test]
        public void ExtensionInfoRequestContactInfoRegionalSettingsLanguageInstanceTest()
        {
            Assert.IsInstanceOf<ExtensionInfoRequestContactInfoRegionalSettingsLanguage> (instance, "instance is a ExtensionInfoRequestContactInfoRegionalSettingsLanguage");
        }

        
        /// <summary>
        /// Test the property 'Id' 
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id' 
        }
        

    }

}
