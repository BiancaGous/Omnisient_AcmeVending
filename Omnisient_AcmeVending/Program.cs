using System;

namespace Omnisient_AcmeVending
{
    class Program
    {
        static void Main(string[] args)
        {
            var coinDenominations = new int[] { 1, 5, 10, 25 }; // coin denominations – US Dollar
            var machine = new VendingMachine(coinDenominations);
            var purchaseAmount = 1.35; // amount the item cost
            var tenderAmount = 2.00; // amount the user input for the purchase
            var change = machine.CalculateChange((decimal)purchaseAmount, (decimal)tenderAmount); // expect 65 cents
            for (int i = 0; i < change.Length; i++)
            {
                Console.WriteLine("change[" + i + "] = " + change[i]); 
            }
        }
    }
}
