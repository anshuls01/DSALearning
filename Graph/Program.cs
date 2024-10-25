// See https://aka.ms/new-console-template for more information

using Graph;
using Graph.revision;

//T O:(e) or O(n^2)   S: O(n)
// n=> no of nodes, e => no of edgea
Console.WriteLine("Graph");
// TraverseNodes traverseNodes = new TraverseNodes();
// traverseNodes.print(traverseNodes.BuildAdjency(),'a');
// Console.WriteLine("---------------");
// traverseNodes.print_recursive(traverseNodes.BuildAdjency(),'a');
// HasPath hasPath = new HasPath();
// Dictionary<char, List<char>> adj = hasPath.BuildAdjancy(new List<char[]>
// {
//     new char[]{'f','g'},
//     new char[]{'f','i'},
//     new char[]{'g','h'},
//     new char[]{'i','g'},
//     new char[]{'i','k'},
//     new char[]{'j','i'}
//     
// });
// Console.WriteLine(hasPath.exist(adj,'f','k'));
// Console.WriteLine(hasPath.exist(adj,'j','f'));

// UndirectedPath undirectedPath = new UndirectedPath();
// Console.WriteLine( undirectedPath.ValidatePathBetweenSourceAndDestination(undirectedPath.BuildAdjancey(new List<char[]>
// {
//     new char[]{'i','j'},
//     new char[]{'k','i'},
//     new char[]{'m','k'},
//     new char[]{'k','l'},
//     new char[]{'o','n'},
//     }), 'j','m'));


// ConnectedComponentCount coneConnectedComponentCount = new ConnectedComponentCount();
// Console.WriteLine(coneConnectedComponentCount.Solve(coneConnectedComponentCount.BuildAdjancey(new List<int[]>
// {
//     new int[]{1,2},
//     new int[]{4,6},
//     new int[]{5,6},
//     new int[]{6,8},
//     new int[]{6,7},
//     new int[]{3}
// })));

// LargestComponent largestComponent = new LargestComponent();
// Console.WriteLine(largestComponent.Solve(largestComponent.BuildAdjancey(new List<int[]>
// {
//     new int[]{0,8},
//     new int[]{0,5},
//     new int[]{0,1},
//     new int[]{1,0},
//     new int[]{5,0},
//     new int[]{5,8},
//     new int[]{8,0},
//     new int[]{8,5},
//     new int[]{2,3},
//     new int[]{3,4},
//     new int[]{2,4},
//     new int[]{3,2},
//     new int[]{4,3},
//     new int[]{4,2}
//     
//     // new int[]{1,2},
//     // new int[]{4,6},
//     // new int[]{5,6},
//     // new int[]{6,8},
//     // new int[]{6,7},
//     // new int[]{3}
// })));

// ShortestPath shortestPath = new ShortestPath();
// Console.WriteLine(shortestPath.Solve_BFS(shortestPath.BuildAdjancy(new List<char[]>()
// {
//     new char[]{'a','c'},
//     new char[]{'a','b'},
//     new char[]{'c','b'},
//     new char[]{'c','d'},
//     new char[]{'b','d'},
//     new char[]{'e','d'},
//     new char[]{'g','f'}
// }), 'b','e'));
// Console.WriteLine(shortestPath.Solve_BFS(shortestPath.BuildAdjancy(new List<char[]>()
// {
//     new char[]{'w','x'},
//     new char[]{'x','y'},
//     new char[]{'z','y'},
//     new char[]{'z','v'},
//     new char[]{'w','v'}
// }), 'x','z'));


// IslandCount islandCount = new IslandCount();
// Console.WriteLine(islandCount.Solve(new char[,]
// {
//     {'W','L','W','W','L','W',},
//     {'L','L','W','W','L','W',},
//     {'W','L','W','W','W','W',},
//     {'W','W','W','L','L','W',},
//     {'W','L','W','L','L','W',},
//     {'W','W','W','W','W','W',},
// }));

// MatrixIslandCount matrixIslandCount = new MatrixIslandCount();
// matrixIslandCount.Solution(new int[][]
// {
//     new int[]{1,1,0},
//     new int[]{1,1,0}, 
//     new int[]{0,0,1}
// });
// FindDistinctShapeIsLand findDistinctShapeIsLand = new FindDistinctShapeIsLand();
// findDistinctShapeIsLand.find(new int[][]
// {
//     new int[] { 1, 1, 0, 1, 1 },
//     new int[] { 1, 1, 0, 1, 1 },
//     new int[] { 0, 0, 0, 0, 0 },
//     new int[] { 0, 1, 1, 0, 1 },
//     new int[] { 0, 1, 1, 0, 1 }
// });
//
//
// MatrixHasCycle matrixHasCycle = new MatrixHasCycle();
// matrixHasCycle.hasCycle(new char[][]
// {
//     new char[] { 'a', 'b', 'e', 'b' },
//     new char[] { 'b', 'b', 'b', 'b' }, 
//     new char[] { 'b', 'c', 'c', 'd' },
//     new char[] { 'c', 'c', 'd', 'd' }
// });


//MutualFriends mutualFriends = new MutualFriends();
//Console.WriteLine(string.Join(",",mutualFriends.findMutualFriends( mutualFriends.CreateAdjencyList(
//    new List<char[]>
//{
//    new char[]{'a','b'},
//    new char[]{'a','c'},
//    new char[]{'b','d'},
//    new char[]{'b','g'},
//    new char[]{'d','p'},
//    new char[]{'d','q'},
//    new char[]{'l','x'},
//    new char[]{'l','y'}
//}), 'a')));

// revision start
CreateAdjency createAdjency = new CreateAdjency();
//Dictionary<char,List<char>> adj =  createAdjency.CreateGraphAdjencyList(new char[][] { new char[] {'f','g' },
//                                                    new char[] {'f','i' },
//                                                    new char[] {'i','k' },
//                                                    new char[] {'i','g' },
//                                                    new char[] {'g','h' },
//                                                    new char[] {'j','i' }
//                                                    }, true);



//n -> no of nodes 
//e -> no of edges or e = n^2 (worst case no of edge will be n^2, where n is no of nodes)
//T: O(e) or O(n^2) each edge has to be travel between the nodes
//S: O(n) recursive calls - max depth of recursive calls
//Graph.revision.HasPath hasPath = new Graph.revision.HasPath();
//Console.WriteLine(hasPath.find(adj, 'f', 'g'));
//Console.WriteLine(hasPath.find(adj, 'f', 'k'));
//Console.WriteLine(hasPath.find(adj, 'j', 'f'));

//Dictionary<char, List<char>> adj = createAdjency.CreateGraphAdjencyList(new char[][] {
//                                                    new char[] {'i','j' },
//                                                    new char[] {'k','i' },
//                                                    new char[] {'m','k' },
//                                                    new char[] {'k','l' },
//                                                    new char[] {'o','n' }
//                                                    }, false);

//Graph.revision.HasPath hasPath = new Graph.revision.HasPath();
//Console.WriteLine(hasPath.pathExistInAUndirectedGraph(adj, 'j', 'm'));

//Dictionary<int, List<int>> adj = createAdjency.CreateGraphAdjencyList(new int[][] {
//                                                    new int[] { 1,2},
//                                                    new int[] {4,6 },
//                                                    new int[] { 5,6},
//                                                    new int[] { 8,6},
//                                                    new int[] { 7,6},
//                                                    new int[] { 3,3}
//                                                    }, false);
//Graph.revision.ConnectedComponent connectedComponent = new Graph.revision.ConnectedComponent();
//Console.WriteLine(connectedComponent.find(adj));

Dictionary<int, List<int>> adj = createAdjency.CreateGraphAdjencyList(new int[][] {
                                                    new int[] { 0,8},
                                                    new int[] {0,1 },
                                                    new int[] { 0,5},
                                                    new int[] { 5,8},
                                                    new int[] { 2,3},
                                                    new int[] { 2,4},
                                                    new int[] { 3,4}
                                                    }, false);

Graph.revision.LargestComponentSize componentSize = new Graph.revision.LargestComponentSize();
Console.WriteLine(componentSize.find(adj));
