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
    ///  Class for testing ResponseError
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ResponseErrorTests
    {
        // TODO uncomment below to declare an instance variable for ResponseError
        //private ResponseError instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ResponseError
            //instance = new ResponseError();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ResponseError
        /// </summary>
        [Test]
        public void ResponseErrorInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ResponseError
            //Assert.IsInstanceOfType<ResponseError> (instance, "variable 'instance' is a ResponseError");
        }


        /// <summary>
        /// Test the property 'HttpStatus'
        /// </summary>
        [Test]
        public void HttpStatusTest()
        {
            // TODO unit test for the property 'HttpStatus'
        }
        /// <summary>
        /// Test the property 'Error'
        /// </summary>
        [Test]
        public void ErrorTest()
        {
            // TODO unit test for the property 'Error'
        }

    }

}
