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
    ///  Class for testing ReservePhoneNumberResponseReserveRecord
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ReservePhoneNumberResponseReserveRecordTests
    {
        private ReservePhoneNumberResponseReserveRecord instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReservePhoneNumberResponseReserveRecord();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ReservePhoneNumberResponseReserveRecord
        /// </summary>
        [Test]
        public void ReservePhoneNumberResponseReserveRecordInstanceTest()
        {
            Assert.IsInstanceOf<ReservePhoneNumberResponseReserveRecord> (instance, "instance is a ReservePhoneNumberResponseReserveRecord");
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
        /// Test the property 'FormattedNumber' 
        /// </summary>
        [Test]
        public void FormattedNumberTest()
        {
            // TODO: unit test for the property 'FormattedNumber' 
        }
        
        /// <summary>
        /// Test the property 'ReservedTill' 
        /// </summary>
        [Test]
        public void ReservedTillTest()
        {
            // TODO: unit test for the property 'ReservedTill' 
        }
        
        /// <summary>
        /// Test the property 'ReservationId' 
        /// </summary>
        [Test]
        public void ReservationIdTest()
        {
            // TODO: unit test for the property 'ReservationId' 
        }
        
        /// <summary>
        /// Test the property 'Status' 
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO: unit test for the property 'Status' 
        }
        
        /// <summary>
        /// Test the property 'Error' 
        /// </summary>
        [Test]
        public void ErrorTest()
        {
            // TODO: unit test for the property 'Error' 
        }
        

    }

}
