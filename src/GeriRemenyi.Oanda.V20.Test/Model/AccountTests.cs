/* 
 * OANDA v20 API
 *
 * The full OANDA v20 API Specification. This specification defines how to interact with v20 Accounts, Trades, Orders, Pricing and more.
 *
 * The version of the OpenAPI document: 3.0.25
 * Contact: api@oanda.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Model;
using GeriRemenyi.Oanda.V20.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace GeriRemenyi.Oanda.V20.Test
{
    /// <summary>
    ///  Class for testing Account
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AccountTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Account
        //private Account instance;

        public AccountTests()
        {
            // TODO uncomment below to create an instance of Account
            //instance = new Account();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Account
        /// </summary>
        [Fact]
        public void AccountInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Account
            //Assert.IsInstanceOfType<Account> (instance, "variable 'instance' is a Account");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Alias'
        /// </summary>
        [Fact]
        public void AliasTest()
        {
            // TODO unit test for the property 'Alias'
        }
        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Fact]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }
        /// <summary>
        /// Test the property 'Balance'
        /// </summary>
        [Fact]
        public void BalanceTest()
        {
            // TODO unit test for the property 'Balance'
        }
        /// <summary>
        /// Test the property 'CreatedByUserID'
        /// </summary>
        [Fact]
        public void CreatedByUserIDTest()
        {
            // TODO unit test for the property 'CreatedByUserID'
        }
        /// <summary>
        /// Test the property 'CreatedTime'
        /// </summary>
        [Fact]
        public void CreatedTimeTest()
        {
            // TODO unit test for the property 'CreatedTime'
        }
        /// <summary>
        /// Test the property 'GuaranteedStopLossOrderMode'
        /// </summary>
        [Fact]
        public void GuaranteedStopLossOrderModeTest()
        {
            // TODO unit test for the property 'GuaranteedStopLossOrderMode'
        }
        /// <summary>
        /// Test the property 'Pl'
        /// </summary>
        [Fact]
        public void PlTest()
        {
            // TODO unit test for the property 'Pl'
        }
        /// <summary>
        /// Test the property 'ResettablePL'
        /// </summary>
        [Fact]
        public void ResettablePLTest()
        {
            // TODO unit test for the property 'ResettablePL'
        }
        /// <summary>
        /// Test the property 'ResettablePLTime'
        /// </summary>
        [Fact]
        public void ResettablePLTimeTest()
        {
            // TODO unit test for the property 'ResettablePLTime'
        }
        /// <summary>
        /// Test the property 'Financing'
        /// </summary>
        [Fact]
        public void FinancingTest()
        {
            // TODO unit test for the property 'Financing'
        }
        /// <summary>
        /// Test the property 'Commission'
        /// </summary>
        [Fact]
        public void CommissionTest()
        {
            // TODO unit test for the property 'Commission'
        }
        /// <summary>
        /// Test the property 'GuaranteedExecutionFees'
        /// </summary>
        [Fact]
        public void GuaranteedExecutionFeesTest()
        {
            // TODO unit test for the property 'GuaranteedExecutionFees'
        }
        /// <summary>
        /// Test the property 'MarginRate'
        /// </summary>
        [Fact]
        public void MarginRateTest()
        {
            // TODO unit test for the property 'MarginRate'
        }
        /// <summary>
        /// Test the property 'MarginCallEnterTime'
        /// </summary>
        [Fact]
        public void MarginCallEnterTimeTest()
        {
            // TODO unit test for the property 'MarginCallEnterTime'
        }
        /// <summary>
        /// Test the property 'MarginCallExtensionCount'
        /// </summary>
        [Fact]
        public void MarginCallExtensionCountTest()
        {
            // TODO unit test for the property 'MarginCallExtensionCount'
        }
        /// <summary>
        /// Test the property 'LastMarginCallExtensionTime'
        /// </summary>
        [Fact]
        public void LastMarginCallExtensionTimeTest()
        {
            // TODO unit test for the property 'LastMarginCallExtensionTime'
        }
        /// <summary>
        /// Test the property 'OpenTradeCount'
        /// </summary>
        [Fact]
        public void OpenTradeCountTest()
        {
            // TODO unit test for the property 'OpenTradeCount'
        }
        /// <summary>
        /// Test the property 'OpenPositionCount'
        /// </summary>
        [Fact]
        public void OpenPositionCountTest()
        {
            // TODO unit test for the property 'OpenPositionCount'
        }
        /// <summary>
        /// Test the property 'PendingOrderCount'
        /// </summary>
        [Fact]
        public void PendingOrderCountTest()
        {
            // TODO unit test for the property 'PendingOrderCount'
        }
        /// <summary>
        /// Test the property 'HedgingEnabled'
        /// </summary>
        [Fact]
        public void HedgingEnabledTest()
        {
            // TODO unit test for the property 'HedgingEnabled'
        }
        /// <summary>
        /// Test the property 'LastOrderFillTimestamp'
        /// </summary>
        [Fact]
        public void LastOrderFillTimestampTest()
        {
            // TODO unit test for the property 'LastOrderFillTimestamp'
        }
        /// <summary>
        /// Test the property 'LastTransactionId'
        /// </summary>
        [Fact]
        public void LastTransactionIdTest()
        {
            // TODO unit test for the property 'LastTransactionId'
        }
        /// <summary>
        /// Test the property 'UnrealizedPL'
        /// </summary>
        [Fact]
        public void UnrealizedPLTest()
        {
            // TODO unit test for the property 'UnrealizedPL'
        }
        /// <summary>
        /// Test the property 'NAV'
        /// </summary>
        [Fact]
        public void NAVTest()
        {
            // TODO unit test for the property 'NAV'
        }
        /// <summary>
        /// Test the property 'MarginUsed'
        /// </summary>
        [Fact]
        public void MarginUsedTest()
        {
            // TODO unit test for the property 'MarginUsed'
        }
        /// <summary>
        /// Test the property 'MarginAvailable'
        /// </summary>
        [Fact]
        public void MarginAvailableTest()
        {
            // TODO unit test for the property 'MarginAvailable'
        }
        /// <summary>
        /// Test the property 'PositionValue'
        /// </summary>
        [Fact]
        public void PositionValueTest()
        {
            // TODO unit test for the property 'PositionValue'
        }
        /// <summary>
        /// Test the property 'MarginCloseoutUnrealizedPL'
        /// </summary>
        [Fact]
        public void MarginCloseoutUnrealizedPLTest()
        {
            // TODO unit test for the property 'MarginCloseoutUnrealizedPL'
        }
        /// <summary>
        /// Test the property 'MarginCloseoutNAV'
        /// </summary>
        [Fact]
        public void MarginCloseoutNAVTest()
        {
            // TODO unit test for the property 'MarginCloseoutNAV'
        }
        /// <summary>
        /// Test the property 'MarginCloseoutMarginUsed'
        /// </summary>
        [Fact]
        public void MarginCloseoutMarginUsedTest()
        {
            // TODO unit test for the property 'MarginCloseoutMarginUsed'
        }
        /// <summary>
        /// Test the property 'MarginCloseoutPercent'
        /// </summary>
        [Fact]
        public void MarginCloseoutPercentTest()
        {
            // TODO unit test for the property 'MarginCloseoutPercent'
        }
        /// <summary>
        /// Test the property 'MarginCloseoutPositionValue'
        /// </summary>
        [Fact]
        public void MarginCloseoutPositionValueTest()
        {
            // TODO unit test for the property 'MarginCloseoutPositionValue'
        }
        /// <summary>
        /// Test the property 'WithdrawalLimit'
        /// </summary>
        [Fact]
        public void WithdrawalLimitTest()
        {
            // TODO unit test for the property 'WithdrawalLimit'
        }
        /// <summary>
        /// Test the property 'MarginCallMarginUsed'
        /// </summary>
        [Fact]
        public void MarginCallMarginUsedTest()
        {
            // TODO unit test for the property 'MarginCallMarginUsed'
        }
        /// <summary>
        /// Test the property 'MarginCallPercent'
        /// </summary>
        [Fact]
        public void MarginCallPercentTest()
        {
            // TODO unit test for the property 'MarginCallPercent'
        }

    }

}
