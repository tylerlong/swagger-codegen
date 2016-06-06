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
    ///  Class for testing ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguageTests
    {
        private ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage
        /// </summary>
        [Test]
        public void ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguageInstanceTest()
        {
            Assert.IsInstanceOf<ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage> (instance, "instance is a ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage");
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
