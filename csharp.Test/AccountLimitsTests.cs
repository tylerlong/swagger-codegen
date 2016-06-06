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
    ///  Class for testing AccountLimits
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AccountLimitsTests
    {
        private AccountLimits instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AccountLimits();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of AccountLimits
        /// </summary>
        [Test]
        public void AccountLimitsInstanceTest()
        {
            Assert.IsInstanceOf<AccountLimits> (instance, "instance is a AccountLimits");
        }

        
        /// <summary>
        /// Test the property 'FreeSoftPhoneLinesPerExtension' 
        /// </summary>
        [Test]
        public void FreeSoftPhoneLinesPerExtensionTest()
        {
            // TODO: unit test for the property 'FreeSoftPhoneLinesPerExtension' 
        }
        
        /// <summary>
        /// Test the property 'MeetingSize' 
        /// </summary>
        [Test]
        public void MeetingSizeTest()
        {
            // TODO: unit test for the property 'MeetingSize' 
        }
        
        /// <summary>
        /// Test the property 'MaxMonitoredExtensionsPerUser' 
        /// </summary>
        [Test]
        public void MaxMonitoredExtensionsPerUserTest()
        {
            // TODO: unit test for the property 'MaxMonitoredExtensionsPerUser' 
        }
        

    }

}
