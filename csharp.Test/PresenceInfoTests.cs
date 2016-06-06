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
    ///  Class for testing PresenceInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PresenceInfoTests
    {
        private PresenceInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PresenceInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of PresenceInfo
        /// </summary>
        [Test]
        public void PresenceInfoInstanceTest()
        {
            Assert.IsInstanceOf<PresenceInfo> (instance, "instance is a PresenceInfo");
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
        /// Test the property 'AllowSeeMyPresence' 
        /// </summary>
        [Test]
        public void AllowSeeMyPresenceTest()
        {
            // TODO: unit test for the property 'AllowSeeMyPresence' 
        }
        
        /// <summary>
        /// Test the property 'DndStatus' 
        /// </summary>
        [Test]
        public void DndStatusTest()
        {
            // TODO: unit test for the property 'DndStatus' 
        }
        
        /// <summary>
        /// Test the property 'Extension' 
        /// </summary>
        [Test]
        public void ExtensionTest()
        {
            // TODO: unit test for the property 'Extension' 
        }
        
        /// <summary>
        /// Test the property 'Message' 
        /// </summary>
        [Test]
        public void MessageTest()
        {
            // TODO: unit test for the property 'Message' 
        }
        
        /// <summary>
        /// Test the property 'PickUpCallsOnHold' 
        /// </summary>
        [Test]
        public void PickUpCallsOnHoldTest()
        {
            // TODO: unit test for the property 'PickUpCallsOnHold' 
        }
        
        /// <summary>
        /// Test the property 'PresenceStatus' 
        /// </summary>
        [Test]
        public void PresenceStatusTest()
        {
            // TODO: unit test for the property 'PresenceStatus' 
        }
        
        /// <summary>
        /// Test the property 'RingOnMonitoredCall' 
        /// </summary>
        [Test]
        public void RingOnMonitoredCallTest()
        {
            // TODO: unit test for the property 'RingOnMonitoredCall' 
        }
        
        /// <summary>
        /// Test the property 'TelephonyStatus' 
        /// </summary>
        [Test]
        public void TelephonyStatusTest()
        {
            // TODO: unit test for the property 'TelephonyStatus' 
        }
        
        /// <summary>
        /// Test the property 'UserStatus' 
        /// </summary>
        [Test]
        public void UserStatusTest()
        {
            // TODO: unit test for the property 'UserStatus' 
        }
        

    }

}