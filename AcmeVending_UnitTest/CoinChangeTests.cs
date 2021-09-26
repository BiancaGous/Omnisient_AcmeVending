using Microsoft.VisualStudio.TestTools.UnitTesting;
using Omnisient_AcmeVending;
using System;

namespace AcmeVending_UnitTest
{
    [TestClass]
    public class CoinChangeTests
    {
        [TestMethod]
        public void CalculateChange_WithValidUSDollarCoinDenomination_CorrectChange()
        {
            // Arrange
            var coinDenominations = new int[] { 1, 5, 10, 25 };
            var purchaseAmount = 1.35;
            var tenderAmount = 2.00;
            var machine = new VendingMachine(coinDenominations);

            // Act
            var change = machine.CalculateChange((decimal)purchaseAmount, (decimal)tenderAmount);

            // Assert
            CollectionAssert.AreEqual(new int[]{25, 25, 10, 5}, change, "Change is incorrect");
        }

        [TestMethod]
        public void CalculateChange_WithValidBritishPondCoinDenomination_CorrectChange()
        {
            // Arrange
            var coinDenominations = new int[] { 1, 2, 5, 10, 20, 50 };
            var purchaseAmount = 1.43; 
            var tenderAmount = 2.00; 
            var machine = new VendingMachine(coinDenominations);

            // Act
            var change = machine.CalculateChange((decimal)purchaseAmount, (decimal)tenderAmount);

            // Assert
            CollectionAssert.AreEqual(new int[] { 50, 5, 2}, change, "Change is incorrect");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CalculateChange_WithEmptyCoinDenomination_()
        {
            // Arrange
            var coinDenominations = new int[] { };
            var purchaseAmount = 1.35;
            var tenderAmount = 2.00;
            var machine = new VendingMachine(coinDenominations);

            // Act
            var change = machine.CalculateChange((decimal)purchaseAmount, (decimal)tenderAmount);
        }
    }
}
