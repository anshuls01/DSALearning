// See https://aka.ms/new-console-template for more information
using TopologicalSort;

Console.WriteLine("Topological Sort");
TopologicalSortTemplate template = new TopologicalSortTemplate();
template.Print(template.CreateAdjency(new int[][] { new int[] { 5, 2 }, new int[] { 5, 0 }, new int[] { 4, 0 }, new int[] { 4, 1 }, new int[] { 2, 3 }, new int[] { 3, 1 } }));
