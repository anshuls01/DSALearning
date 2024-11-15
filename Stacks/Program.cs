// See https://aka.ms/new-console-template for more information

using Stack;

Console.WriteLine("Stack");
//StockSpan stockSpan = new StockSpan();
//Console.WriteLine(string.Join(",", stockSpan.Solution(new int[] { 100, 80, 60, 70, 60, 75, 85 }) ?? new int[] { }));
//Console.WriteLine(string.Join(",", stockSpan.Solution(new int[] { 100 }) ?? new int[] { }));

//StockSpan1 stockSpan1 = new StockSpan1();
//Console.WriteLine(string.Join(",", stockSpan1.find(new int[] { 100, 80, 60, 70, 60, 75, 85 }) ?? new int[] { }));
//Console.WriteLine(string.Join(",", stockSpan1.find(new int[] { 100 }) ?? new int[] { }));

MaxAreaOfHistogram maxAreaOfHistogram = new MaxAreaOfHistogram();
Console.WriteLine(maxAreaOfHistogram.Solution(new int[] { 6, 2, 5, 4, 5, 1, 6 }));

MaxAreaHistogram1 maxAreaHistogram1 = new MaxAreaHistogram1();
Console.WriteLine(maxAreaHistogram1.find(new int[] { 6, 2, 5, 4, 5, 1, 6 }));

//RainWaterTrapping rainWaterTrapping = new RainWaterTrapping();
//Console.WriteLine(rainWaterTrapping.Solution(new int[] { 3, 0, 0, 2, 0, 4 }));
//Console.WriteLine(rainWaterTrapping.Solution(new int[] { 0,1,0,2,1,0,1,3,2,1,2,1 }));