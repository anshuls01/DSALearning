namespace LeetCode75.ArrayStrings
{
    public class BuySellStocks1
    {
        public void Solve(int[] prices)
        {
            if (prices == null || prices.Length < 2)
            {
                Console.WriteLine(0);
            }

            int mbp = prices[0];
            int max_profit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                int sellPrice = prices[i];
                int profit = sellPrice - mbp;
                if (profit > max_profit)
                {
                    max_profit = profit;
                }
                if (mbp > sellPrice)
                {
                    mbp = sellPrice;
                }
            }
            Console.WriteLine(max_profit);
        }
    }
}
