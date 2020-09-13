/* 
 * OANDA v20 API
 *
 * The full OANDA v20 API Specification. This specification defines how to interact with v20 Accounts, Trades, Orders, Pricing and more.
 *
 * The version of the OpenAPI document: 3.0.25
 * Contact: api@oanda.com
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

using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace GeriRemenyi.Oanda.V20.Client.Test
{
    /// <summary>
    ///  Class for testing AccountApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AccountApiTests : IDisposable
    {
        private AccountApi instance;

        public AccountApiTests()
        {
            instance = new AccountApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AccountApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AccountApi
            //Assert.IsType(typeof(AccountApi), instance, "instance is a AccountApi");
        }

        
        /// <summary>
        /// Test ConfigureAccount
        /// </summary>
        [Fact]
        public void ConfigureAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountID = null;
            //DateTimeFormat? acceptDatetimeFormat = null;
            //AccountConfigurationRequest accountConfigurationRequest = null;
            //var response = instance.ConfigureAccount(accountID, acceptDatetimeFormat, accountConfigurationRequest);
            //Assert.IsType<AccountConfigurationResponse> (response, "response is AccountConfigurationResponse");
        }
        
        /// <summary>
        /// Test GetAccount
        /// </summary>
        [Fact]
        public void GetAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountID = null;
            //DateTimeFormat? acceptDatetimeFormat = null;
            //var response = instance.GetAccount(accountID, acceptDatetimeFormat);
            //Assert.IsType<AccountResponse> (response, "response is AccountResponse");
        }
        
        /// <summary>
        /// Test GetAccountChanges
        /// </summary>
        [Fact]
        public void GetAccountChangesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountID = null;
            //DateTimeFormat? acceptDatetimeFormat = null;
            //int? sinceTransactionID = null;
            //var response = instance.GetAccountChanges(accountID, acceptDatetimeFormat, sinceTransactionID);
            //Assert.IsType<AccountChangesResponse> (response, "response is AccountChangesResponse");
        }
        
        /// <summary>
        /// Test GetAccountInstruments
        /// </summary>
        [Fact]
        public void GetAccountInstrumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountID = null;
            //List<InstrumentName> instruments = null;
            //var response = instance.GetAccountInstruments(accountID, instruments);
            //Assert.IsType<AccountInstrumentsResponse> (response, "response is AccountInstrumentsResponse");
        }
        
        /// <summary>
        /// Test GetAccountSummary
        /// </summary>
        [Fact]
        public void GetAccountSummaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountID = null;
            //DateTimeFormat? acceptDatetimeFormat = null;
            //var response = instance.GetAccountSummary(accountID, acceptDatetimeFormat);
            //Assert.IsType<AccountSummaryResponse> (response, "response is AccountSummaryResponse");
        }
        
        /// <summary>
        /// Test GetAccounts
        /// </summary>
        [Fact]
        public void GetAccountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAccounts();
            //Assert.IsType<AccountsResponse> (response, "response is AccountsResponse");
        }
        
    }

}
