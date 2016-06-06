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
    ///  Class for testing PersonalContactInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PersonalContactInfoTests
    {
        private PersonalContactInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PersonalContactInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of PersonalContactInfo
        /// </summary>
        [Test]
        public void PersonalContactInfoInstanceTest()
        {
            Assert.IsInstanceOf<PersonalContactInfo> (instance, "instance is a PersonalContactInfo");
        }

        
        /// <summary>
        /// Test the property 'Id' 
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id' 
        }
        
        /// <summary>
        /// Test the property 'Url' 
        /// </summary>
        [Test]
        public void UrlTest()
        {
            // TODO: unit test for the property 'Url' 
        }
        
        /// <summary>
        /// Test the property 'Availability' 
        /// </summary>
        [Test]
        public void AvailabilityTest()
        {
            // TODO: unit test for the property 'Availability' 
        }
        
        /// <summary>
        /// Test the property 'FirstName' 
        /// </summary>
        [Test]
        public void FirstNameTest()
        {
            // TODO: unit test for the property 'FirstName' 
        }
        
        /// <summary>
        /// Test the property 'LastName' 
        /// </summary>
        [Test]
        public void LastNameTest()
        {
            // TODO: unit test for the property 'LastName' 
        }
        
        /// <summary>
        /// Test the property 'MiddleName' 
        /// </summary>
        [Test]
        public void MiddleNameTest()
        {
            // TODO: unit test for the property 'MiddleName' 
        }
        
        /// <summary>
        /// Test the property 'NickName' 
        /// </summary>
        [Test]
        public void NickNameTest()
        {
            // TODO: unit test for the property 'NickName' 
        }
        
        /// <summary>
        /// Test the property 'Company' 
        /// </summary>
        [Test]
        public void CompanyTest()
        {
            // TODO: unit test for the property 'Company' 
        }
        
        /// <summary>
        /// Test the property 'JobTitle' 
        /// </summary>
        [Test]
        public void JobTitleTest()
        {
            // TODO: unit test for the property 'JobTitle' 
        }
        
        /// <summary>
        /// Test the property 'HomePhone' 
        /// </summary>
        [Test]
        public void HomePhoneTest()
        {
            // TODO: unit test for the property 'HomePhone' 
        }
        
        /// <summary>
        /// Test the property 'HomePhone2' 
        /// </summary>
        [Test]
        public void HomePhone2Test()
        {
            // TODO: unit test for the property 'HomePhone2' 
        }
        
        /// <summary>
        /// Test the property 'BusinessPhone' 
        /// </summary>
        [Test]
        public void BusinessPhoneTest()
        {
            // TODO: unit test for the property 'BusinessPhone' 
        }
        
        /// <summary>
        /// Test the property 'BusinessPhone2' 
        /// </summary>
        [Test]
        public void BusinessPhone2Test()
        {
            // TODO: unit test for the property 'BusinessPhone2' 
        }
        
        /// <summary>
        /// Test the property 'MobilePhone' 
        /// </summary>
        [Test]
        public void MobilePhoneTest()
        {
            // TODO: unit test for the property 'MobilePhone' 
        }
        
        /// <summary>
        /// Test the property 'BusinessFax' 
        /// </summary>
        [Test]
        public void BusinessFaxTest()
        {
            // TODO: unit test for the property 'BusinessFax' 
        }
        
        /// <summary>
        /// Test the property 'CompanyPhone' 
        /// </summary>
        [Test]
        public void CompanyPhoneTest()
        {
            // TODO: unit test for the property 'CompanyPhone' 
        }
        
        /// <summary>
        /// Test the property 'AssistantPhone' 
        /// </summary>
        [Test]
        public void AssistantPhoneTest()
        {
            // TODO: unit test for the property 'AssistantPhone' 
        }
        
        /// <summary>
        /// Test the property 'CarPhone' 
        /// </summary>
        [Test]
        public void CarPhoneTest()
        {
            // TODO: unit test for the property 'CarPhone' 
        }
        
        /// <summary>
        /// Test the property 'OtherPhone' 
        /// </summary>
        [Test]
        public void OtherPhoneTest()
        {
            // TODO: unit test for the property 'OtherPhone' 
        }
        
        /// <summary>
        /// Test the property 'OtherFax' 
        /// </summary>
        [Test]
        public void OtherFaxTest()
        {
            // TODO: unit test for the property 'OtherFax' 
        }
        
        /// <summary>
        /// Test the property 'CallbackPhone' 
        /// </summary>
        [Test]
        public void CallbackPhoneTest()
        {
            // TODO: unit test for the property 'CallbackPhone' 
        }
        
        /// <summary>
        /// Test the property 'Email' 
        /// </summary>
        [Test]
        public void EmailTest()
        {
            // TODO: unit test for the property 'Email' 
        }
        
        /// <summary>
        /// Test the property 'Email2' 
        /// </summary>
        [Test]
        public void Email2Test()
        {
            // TODO: unit test for the property 'Email2' 
        }
        
        /// <summary>
        /// Test the property 'Email3' 
        /// </summary>
        [Test]
        public void Email3Test()
        {
            // TODO: unit test for the property 'Email3' 
        }
        
        /// <summary>
        /// Test the property 'HomeAddress' 
        /// </summary>
        [Test]
        public void HomeAddressTest()
        {
            // TODO: unit test for the property 'HomeAddress' 
        }
        
        /// <summary>
        /// Test the property 'BusinessAddress' 
        /// </summary>
        [Test]
        public void BusinessAddressTest()
        {
            // TODO: unit test for the property 'BusinessAddress' 
        }
        
        /// <summary>
        /// Test the property 'OtherAddress' 
        /// </summary>
        [Test]
        public void OtherAddressTest()
        {
            // TODO: unit test for the property 'OtherAddress' 
        }
        
        /// <summary>
        /// Test the property 'Birthday' 
        /// </summary>
        [Test]
        public void BirthdayTest()
        {
            // TODO: unit test for the property 'Birthday' 
        }
        
        /// <summary>
        /// Test the property 'WebPage' 
        /// </summary>
        [Test]
        public void WebPageTest()
        {
            // TODO: unit test for the property 'WebPage' 
        }
        
        /// <summary>
        /// Test the property 'Notes' 
        /// </summary>
        [Test]
        public void NotesTest()
        {
            // TODO: unit test for the property 'Notes' 
        }
        

    }

}