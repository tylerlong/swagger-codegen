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
    ///  Class for testing ReservePhoneNumberRequestReserveRecord
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ReservePhoneNumberRequestReserveRecordTests
    {
        private ReservePhoneNumberRequestReserveRecord instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReservePhoneNumberRequestReserveRecord();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ReservePhoneNumberRequestReserveRecord
        /// </summary>
        [Test]
        public void ReservePhoneNumberRequestReserveRecordInstanceTest()
        {
            Assert.IsInstanceOf<ReservePhoneNumberRequestReserveRecord> (instance, "instance is a ReservePhoneNumberRequestReserveRecord");
        }

        
        /// <summary>
        /// Test the property 'PhoneNumber' 
        /// </summary>
        [Test]
        public void PhoneNumberTest()
        {
            // TODO: unit test for the property 'PhoneNumber' 
        }
        
        /// <summary>
        /// Test the property 'ReservedTill' 
        /// </summary>
        [Test]
        public void ReservedTillTest()
        {
            // TODO: unit test for the property 'ReservedTill' 
        }
        

    }

}