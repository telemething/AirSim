//*****************************************************************************
//* Project: Firefly (Microsoft Hackaton 2020)
//* Description: AOLUSS REST Client
//* Author: Mark West (mark.west@microsoft.com)
//*****************************************************************************

/* 
 * NASA AOLUSS Operator interface
 *
 * this OAS document describes the operator interface for the AOLUSS.
 *
 * OpenAPI spec version: 2.1.8
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using AolussClientLib.Api;
using AolussClientLib.Model;
using AolussClientLib.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace AolussClientLib.Test
{
    /// <summary>
    ///  Class for testing ModelUasRegistrations
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ModelUasRegistrationsTests
    {
        // TODO uncomment below to declare an instance variable for ModelUasRegistrations
        //private ModelUasRegistrations instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ModelUasRegistrations
            //instance = new ModelUasRegistrations();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ModelUasRegistrations
        /// </summary>
        [Test]
        public void ModelUasRegistrationsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ModelUasRegistrations
            //Assert.IsInstanceOfType<ModelUasRegistrations> (instance, "variable 'instance' is a ModelUasRegistrations");
        }


        /// <summary>
        /// Test the property 'RegistrationId'
        /// </summary>
        [Test]
        public void RegistrationIdTest()
        {
            // TODO unit test for the property 'RegistrationId'
        }
        /// <summary>
        /// Test the property 'RegistrationLocation'
        /// </summary>
        [Test]
        public void RegistrationLocationTest()
        {
            // TODO unit test for the property 'RegistrationLocation'
        }

    }

}
