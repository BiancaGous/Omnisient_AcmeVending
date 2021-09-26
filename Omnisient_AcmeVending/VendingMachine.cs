using System;
using System.Linq;

namespace Omnisient_AcmeVending
{
    public class VendingMachine
    {
		private int[] _coinDenominations;

		public VendingMachine(int[] coinDenominations)
		{
			_coinDenominations = coinDenominations;
			//Sort array descending
			Array.Sort(_coinDenominations);
			Array.Reverse(_coinDenominations);
		}

		public int[] CalculateChange(decimal purchaseAmount, decimal tenderAmount)
		{
            if (_coinDenominations != null && _coinDenominations.Length <= 0)
            {
				throw new Exception("Coin Denomination is invailid");
            }
			var change = new int[] { };
			var changeAmount = (tenderAmount - purchaseAmount) * 100 ;

			foreach (var coin in _coinDenominations)
			{
                if (changeAmount <= 0)
                {
					break;
                }
				var value = (int)(changeAmount / coin);
                for (int i = 0; i < value; i++)
                {
					change = change.Concat(new int[] { coin }).ToArray();
                }
				changeAmount = changeAmount - (coin * value);
			}
			return change;
		}
	}
}
