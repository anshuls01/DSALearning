// See https://aka.ms/new-console-template for more information

using Stack;

Console.WriteLine("Stack");
StockSpan stockSpan = new StockSpan();
Console.WriteLine(string.Join(",", stockSpan.Solution(new int[]{100,80,60,70,60,75,85})??new int[]{}));