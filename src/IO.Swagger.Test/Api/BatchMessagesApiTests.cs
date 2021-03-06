/* 
 * The SMS Works API
 *
 * The SMS Works provides a low-cost, reliable SMS API for developers. Pay only for delivered texts, all failed messages are refunded.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing BatchMessagesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BatchMessagesApiTests
    {
        private BatchMessagesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BatchMessagesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BatchMessagesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BatchMessagesApi
            //Assert.IsInstanceOfType(typeof(BatchMessagesApi), instance, "instance is a BatchMessagesApi");
        }

        
        /// <summary>
        /// Test CancelScheduledBatchJob
        /// </summary>
        [Test]
        public void CancelScheduledBatchJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string batchid = null;
            //var response = instance.CancelScheduledBatchJob(batchid);
            //Assert.IsInstanceOf<CancelledMessageResponse> (response, "response is CancelledMessageResponse");
        }
        
        /// <summary>
        /// Test GetBatchById
        /// </summary>
        [Test]
        public void GetBatchByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string batchid = null;
            //var response = instance.GetBatchById(batchid);
            //Assert.IsInstanceOf<MessagesResponse> (response, "response is MessagesResponse");
        }
        
        /// <summary>
        /// Test ScheduleBatch
        /// </summary>
        [Test]
        public void ScheduleBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchMessage smsMessage = null;
            //var response = instance.ScheduleBatch(smsMessage);
            //Assert.IsInstanceOf<ScheduledBatchResponse> (response, "response is ScheduledBatchResponse");
        }
        
        /// <summary>
        /// Test SendBatch
        /// </summary>
        [Test]
        public void SendBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchMessage smsMessage = null;
            //var response = instance.SendBatch(smsMessage);
            //Assert.IsInstanceOf<BatchMessageResponse> (response, "response is BatchMessageResponse");
        }
        
    }

}
