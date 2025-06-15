namespace LeetCode75.ArrayStrings
{
    public class BestTimeToFlightTickets
    {
        public void Solve(int[] DeparturePrice, int[] ReturnPrice)
        {
            if (DeparturePrice == null || DeparturePrice.Length <= 1)
            {
                Console.WriteLine(0);
                return;
            }
            if (ReturnPrice == null || ReturnPrice.Length <= 2)
            {
                Console.WriteLine(0);
                return;
            }

            int dp = DeparturePrice[0];
            int minCost = int.MaxValue;
            for (int i =1; i < ReturnPrice.Length; i++)
            {
                int rp = ReturnPrice[i];
                int cost = dp+rp;
                minCost = Math.Min(minCost, cost);
                dp = Math.Min(dp, DeparturePrice[i]);
            }
            Console.WriteLine(minCost);
        }
    }
}
