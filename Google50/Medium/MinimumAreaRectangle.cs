using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Medium
{
    internal class MinimumAreaRectangle
    {

        public int find(int[][] coords)
        {
            if (coords.Length < 4)
            {
                return 0;
            }
            int minArea = int.MaxValue;

            HashSet<string> set = new HashSet<string>();
            foreach (int[] coord in coords)
            {
                set.Add($"{coord[0]}_{coord[1]}");
            }

            for(int i = 0;i<coords.Length;i++)
            {
                for (int j = 0; j < coords.Length; j++)
                {
                    if (i != j)
                    {
                        int[] p1 = coords[i];
                        int[] p2 = coords[j];
                        if (p1[0] != p2[0] && p1[1] != p2[1])
                        {
                            //can form a rectangle
                            string s1 = $"{p1[0]}_{p2[1]}";
                            string s2 = $"{p2[0]}_{p1[1]}";
                            if (set.Contains(s1) && set.Contains(s2))
                            {
                                //rectangle can be formed, now calculate area
                                int area = Math.Abs(p1[0] - p2[0]) * Math.Abs(p1[1] - p2[1]);
                                minArea = Math.Min(minArea, area);
                            }
                        }
                    }
                }
            }
            return minArea == int.MaxValue ? 0 : minArea;
        }
        //using hashset and comparing all the pairs,
        //there could be a possibility all relevent points are not nextr to each other
        //public int find(int[][] coords)
        //{
        //    if (coords.Length < 4)
        //    {
        //        return 0;
        //    }
        //    //Array.Sort(coords, (x, y) => x[0].CompareTo(y[0]));//nlogn
        //    // no need to sort - algo become O(n)
        //    int minArea = int.MaxValue;
        //    for (int i = 0; i < coords.Length - 3; i++)
        //    {
        //        point a = new point(coords[i][0], coords[i][1]);
        //        point b = new point(coords[i + 1][0], coords[i + 1][1]);
        //        point c = new point(coords[i + 2][0], coords[i + 2][1]);
        //        point d = new point(coords[i + 3][0], coords[i + 3][1]);

        //        if ((a.x == b.x && c.x == d.x) && (a.y == c.y && b.y == d.y))
        //        {
        //            //valid rectangle
        //            minArea = Math.Min(minArea, (b.y - a.y) * (c.x - a.x));
        //        }
        //    }
        //    return minArea== int.MaxValue?0:minArea;
        //}
        public class point
        {
            public int x;
            public int y;
            public point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
