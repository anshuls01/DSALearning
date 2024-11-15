using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DP.Knapsack0_1
{
    internal class MaxProfit
    {
        public int find(int[] profit, int[] weight, int capacity)
        {
            if (profit == null || profit.Length == 0 || weight == null || weight.Length == 0 || capacity == 0)
            {
                return 0;
            }

            if (weight.Sum() <= capacity)
            {
                return profit.Sum();
            }

            return calculate(profit, weight, capacity, 0);

        }

        internal int find_BottomUP(int[] profit, int[] weight, int capacity)
        {
            if (profit == null || profit.Length == 0 || weight == null || weight.Length == 0 || capacity == 0)
            {
                return 0;
            }

            if (weight.Sum() <= capacity)
            {
                return profit.Sum();
            }

            int n = profit.Length;
            int[,] dp = new int[n + 1, capacity + 1];
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= capacity; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 0;
                    }
                }
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= capacity; j++)
                {
                    int pi = 0;
                    if (weight[i - 1] <= j)
                    {
                        pi = profit[i - 1] + dp[i - 1, j - weight[i - 1]];
                    }

                    int pe = dp[i - 1, j];
                    dp[i, j] = Math.Max(pi, pe);
                }
            }

            return dp[n, capacity];
        }

        internal int find_BottomUP_Space_C_Reverse(int[] profit, int[] weight, int capacity)
        {
            if (profit == null || profit.Length == 0 || weight == null || weight.Length == 0 || capacity == 0)
            {
                return 0;
            }

            if (weight.Sum() <= capacity)
            {
                return profit.Sum();
            }


            int[] dp = new int[capacity + 1];
            for (int i = 0; i <= capacity; i++)
            {
                if (weight[0] <= i)
                {
                    dp[i] = profit[0];
                }
            }
            int n = profit.Length;
            // process all sub-arrays for all the capacities
            for (int i = 1; i < n; i++)
            {
                for (int c = capacity; c >= 0; c--)
                {
                    int profit1 = 0, profit2 = 0;
                    // include the item, if it is not more than the capacity
                    if (weight[i] <= c)
                        profit1 = profit[i] + dp[c - weight[i]];
                    // exclude the item
                    profit2 = dp[c];
                    // take maximum
                    dp[c] = Math.Max(profit1, profit2);
                }
            }

            return dp[capacity];
        }
        internal int find_BottomUP_Space_C(int[] profits, int[] weights, int capacity)
        {
            otherfunction(profits, weights,capacity);
            // basic checks
            if (capacity <= 0 || profits.Length == 0 || weights.Length != profits.Length)
                return 0;

            int n = profits.Length;
            // we only need one previous row to find the optimal solution, overall we need '2' rows
            // the above solution is similar to the previous solution, the only difference is that 
            // we use `i%2` instead if `i` and `(i-1)%2` instead if `i-1`
            int[,] dp = new int[2, capacity + 1];

            // if we have only one weight, we will take it if it is not more than the capacity
            for (int c = 0; c <= capacity; c++)
            {
                if (weights[0] <= c)
                    dp[0, c] = dp[1, c] = profits[0];
            }

            // process all sub-arrays for all the capacities
            for (int i = 1; i < n; i++)
            {
                for (int c = 0; c <= capacity; c++)
                {
                    int profit1 = 0, profit2 = 0;
                    // include the item, if it is not more than the capacity
                    if (weights[i] <= c)
                        profit1 = profits[i] + dp[(i - 1) % 2, c - weights[i]];
                    // exclude the item
                    profit2 = dp[(i - 1) % 2, c];
                    // take maximum
                    dp[i % 2, c] = Math.Max(profit1, profit2);
                }
                printMatrix(0, capacity, dp, i);
            }

            return dp[(n - 1) % 2, capacity];
        }

        private static void printMatrix(int start,  int capacity, int[,] dp, int i)
        {
            for (int j = start; j < capacity; j++)
            {
                Console.Write(dp[i, j] + ",");
            }
            Console.WriteLine();
        }

        private int otherfunction(int[] profit, int[] weight, int capacity)
        {
            if (profit == null || profit.Length == 0 || weight == null || weight.Length == 0 || capacity == 0)
            {
                return 0;
            }

            if (weight.Sum() <= capacity)
            {
                return profit.Sum();
            }

            int n = 2;
            int[,] dp = new int[2, capacity + 1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= capacity; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 0;
                    }
                }
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= capacity; j++)
                {
                    int pi = 0;
                    if (weight[i - 1] <= j)
                    {
                        pi = profit[i - 1] + dp[(i - 1) % 2, j - weight[i - 1]];
                    }

                    int pe = dp[(i - 1) % 2, j];
                    dp[i % 2, j] = Math.Max(pi, pe);
                }
                printMatrix(1,capacity, dp, i%2);

            }

            return dp[(n-1)%2, capacity];
        }

        internal int find_memo(int[] profit, int[] weight, int capacity, Dictionary<string, int> memo)
        {
            if (profit == null || profit.Length == 0 || weight == null || weight.Length == 0 || capacity == 0)
            {
                return 0;
            }

            if (weight.Sum() <= capacity)
            {
                return profit.Sum();
            }

            return calculate_memo(profit, weight, capacity, 0, memo);

        }

        private int calculate_memo(int[] profit, int[] weight, int capacity, int i, Dictionary<string, int> memo)
        {
            string key = $"{i}_{capacity}";
            if (memo.ContainsKey(key))
            {
                return memo[key];
            }

            if (capacity <= 0 || i >= profit.Length)
            {
                return 0;
            }

            int pi = 0;
            if (weight[i] <= capacity)
            {
                pi = profit[i] + calculate_memo(profit, weight, capacity - weight[i], i + 1, memo);
            }

            int pe = calculate_memo(profit, weight, capacity, i + 1, memo);

            memo[key] = Math.Max(pi, pe);
            return memo[key];
        }

        private int calculate(int[] profit, int[] weight, int capacity, int i)
        {
            if (capacity <= 0 || i >= profit.Length)
            {
                return 0;
            }

            int pi = 0;
            if (weight[i] <= capacity)
            {
                pi = profit[i] + calculate(profit, weight, capacity - weight[i], i + 1);
            }

            int pe = calculate(profit, weight, capacity, i + 1);

            return Math.Max(pi, pe);
        }
    }
}
