using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendingMachine_UnitTest
{
    [TestClass]
    public class CoinChangeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var coinDenominations = new int[] { 1, 5, 10, 25 }; // coin denominations – US Dollar
            var machine = new VendingMachine(coinDenominations);
            var purchaseAmount = 1.35; // amount the item cost
            var tenderAmount = 2.00; // amount the user input for the purchase
            var change = machine.CalculateChange((decimal)purchaseAmount, (decimal)tenderAmount);
        }
    }
}
