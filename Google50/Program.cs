// See https://aka.ms/new-console-template for more information

using Google50;
using Google50.Easy;

Console.WriteLine("Google 50!");

//Console.WriteLine("Add Binary");
//AddBInary addBInary = new AddBInary();
//Console.WriteLine(addBInary.BinarySum("10110", "10101"));
//Console.WriteLine(addBInary.BinarySum("1", "111"));
//AddBinary addBinary =new AddBinary();
// Console.WriteLine(addBinary.Solve("10110","10101"));
//Console.WriteLine(addBinary.Solve("1","111"));

ValidMountain mountain = new ValidMountain();
Console.WriteLine(mountain.find(new int[] { 4, 5, 6, 7, 8, 7, 6, 5 }));
Console.WriteLine(mountain.find(new int[] { 1, 2, 3, 4, 5 }));
Console.WriteLine(mountain.find(new int[] { 9, 8, 7, 6, 5 }));

//Console.WriteLine("Binary tree all paths");
//BinaryTreeReturnAllPath binaryTreeReturnAllPath = new BinaryTreeReturnAllPath();
//List<string> paths = binaryTreeReturnAllPath.binaryTreePaths(binaryTreeReturnAllPath.buildTree());
//Console.WriteLine(string.Join(",", paths));
