// See https://aka.ms/new-console-template for more information

using Graph;

Console.WriteLine("Graph");
TraverseNodes traverseNodes = new TraverseNodes();
traverseNodes.print(traverseNodes.BuildAdjency(),'a');
Console.WriteLine("---------------");
traverseNodes.print_recursive(traverseNodes.BuildAdjency(),'a');