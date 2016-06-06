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
    ///  Class for testing StatusInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class StatusInfoTests
    {
        private StatusInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StatusInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of StatusInfo
        /// </summary>
        [Test]
        public void StatusInfoInstanceTest()
        {
            Assert.IsInstanceOf<StatusInfo> (instance, "instance is a StatusInfo");
        }

        
        /// <summary>
        /// Test the property 'Comment' 
        /// </summary>
        [Test]
        public void CommentTest()
        {
            // TODO: unit test for the property 'Comment' 
        }
        
        /// <summary>
        /// Test the property 'Reason' 
        /// </summary>
        [Test]
        public void ReasonTest()
        {
            // TODO: unit test for the property 'Reason' 
        }
        

    }

}