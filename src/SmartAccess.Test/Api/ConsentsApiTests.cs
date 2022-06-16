/*
 * @ao/ah-api
 *
 * Telia Smart Access API
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using SmartAccess.Client;
using SmartAccess.Api;
// uncomment below to import models
//using SmartAccess.Model;

namespace SmartAccess.Test.Api
{
    /// <summary>
    ///  Class for testing ConsentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ConsentsApiTests : IDisposable
    {
        private ConsentsApi instance;

        public ConsentsApiTests()
        {
            instance = new ConsentsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConsentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ConsentsApi
            //Assert.IsType<ConsentsApi>(instance);
        }

        /// <summary>
        /// Test CreateAuthZTicketForConsent
        /// </summary>
        [Fact]
        public void CreateAuthZTicketForConsentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consentId = null;
            //var response = instance.CreateAuthZTicketForConsent(consentId);
            //Assert.IsType<AuthTicketDTO>(response);
        }

        /// <summary>
        /// Test FlowConsentApprovalFinalize
        /// </summary>
        [Fact]
        public void FlowConsentApprovalFinalizeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ConsentApprovalFinalizeBody consentApprovalFinalizeBody = null;
            //var response = instance.FlowConsentApprovalFinalize(consentApprovalFinalizeBody);
            //Assert.IsType<ApprovalDoneUrlDTO>(response);
        }

        /// <summary>
        /// Test FlowConsentApprovalInitialize
        /// </summary>
        [Fact]
        public void FlowConsentApprovalInitializeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ConsentApprovalInitializeBody consentApprovalInitializeBody = null;
            //var response = instance.FlowConsentApprovalInitialize(consentApprovalInitializeBody);
            //Assert.IsType<ApprovalDoneUrlDTO>(response);
        }

        /// <summary>
        /// Test GetConsent
        /// </summary>
        [Fact]
        public void GetConsentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consentId = null;
            //var response = instance.GetConsent(consentId);
            //Assert.IsType<ConsentDTO>(response);
        }

        /// <summary>
        /// Test SearchConsents
        /// </summary>
        [Fact]
        public void SearchConsentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SearchConsentsDTO searchConsentsDTO = null;
            //var response = instance.SearchConsents(searchConsentsDTO);
            //Assert.IsType<PaginationResultDTOConsentSearchResultDTO>(response);
        }
    }
}
