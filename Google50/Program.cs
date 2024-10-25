// See https://aka.ms/new-console-template for more information

using Google50;
using Google50.Easy;
using Google50.Medium;

Console.WriteLine("Google 50!");

//Console.WriteLine("Add Binary");
//AddBInary addBInary = new AddBInary();
//Console.WriteLine(addBInary.BinarySum("10110", "10101"));
//Console.WriteLine(addBInary.BinarySum("1", "111"));
//AddBinary addBinary =new AddBinary();
// Console.WriteLine(addBinary.Solve("10110","10101"));
//Console.WriteLine(addBinary.Solve("1","111"));

//ValidMountain mountain = new ValidMountain();
//Console.WriteLine(mountain.find(new int[] { 4, 5, 6, 7, 8, 7, 6, 5 }));
//Console.WriteLine(mountain.find(new int[] { 1, 2, 3, 4, 5 }));
//Console.WriteLine(mountain.find(new int[] { 9, 8, 7, 6, 5 }));

//SetMismatch setMismatch = new SetMismatch();
//Console.WriteLine(string.Join(",", setMismatch.findPair(new int[] { 1, 5, 3, 2, 7, 7, 6 })));
//Console.WriteLine(string.Join(",", setMismatch.findPair(new int[] { 2, 2, 3, 5, 4 })));
//Console.WriteLine(string.Join(",", setMismatch.findPair(new int[] { 1, 3, 3, 4 })));

//IsSubSequence isSubSequence = new IsSubSequence();
//Console.WriteLine(isSubSequence.find("hello", "xyhealoloo"));
//Console.WriteLine(isSubSequence.find("axc", "ahbgdc"));
//Console.WriteLine(isSubSequence.find("abc", "aabc"));

//MontonicArray montonicArray = new MontonicArray();
//Console.WriteLine(montonicArray.find(new int[] { 1, 5, 10, 10, 15, 16, 90 }));
//Console.WriteLine(montonicArray.find1(new int[] { 1, 5, 10, 10, 15, 16, 90 }));
//Console.WriteLine(montonicArray.find(new int[] { 9, 4, 2, 2, 0 }));
//Console.WriteLine(montonicArray.find1(new int[] { 9, 4, 2, 2, 0 }));
//Console.WriteLine(montonicArray.find(new int[] { 7, 8, 7, 7 }));
//Console.WriteLine(montonicArray.find1(new int[] { 7, 8, 7, 7 }));

//CountNodesEqualToAverageOfSubTree countNodesEqualToAverageOfSubTree = new CountNodesEqualToAverageOfSubTree();
//Console.WriteLine(countNodesEqualToAverageOfSubTree.find(countNodesEqualToAverageOfSubTree.BuildTree()));

//Console.WriteLine("Binary tree all paths");
//BinaryTreeReturnAllPath binaryTreeReturnAllPath = new BinaryTreeReturnAllPath();
//List<string> paths = binaryTreeReturnAllPath.binaryTreePaths(binaryTreeReturnAllPath.buildTree());
//Console.WriteLine(string.Join(",", paths));

//Medium

//TwoKeysKeyboard twoKeysKeyboard = new TwoKeysKeyboard();
//Console.WriteLine(twoKeysKeyboard.findValue(4));
//Console.WriteLine(twoKeysKeyboard.findValue(5));
//Console.WriteLine(twoKeysKeyboard.findValue(9));

//ArithmeticSlices arithmeticSlices = new ArithmeticSlices();
//Console.WriteLine(arithmeticSlices.findCount(new int[] { 1, 3, 5, 7, 9, 10, 11 }));
//Console.WriteLine(arithmeticSlices.findCount(new int[] { 7, 7, 7, 7 }));
//Console.WriteLine(arithmeticSlices.findCount(new int[] { 1, 2, 4, 6, 8 }));
//UniqueLength3PalindromicSubSequences uniqueLength3PalindromicSubSequences = new UniqueLength3PalindromicSubSequences();
//Console.WriteLine(uniqueLength3PalindromicSubSequences.find("abcba"));
//Console.WriteLine(uniqueLength3PalindromicSubSequences.find("aba"));
//Console.WriteLine(uniqueLength3PalindromicSubSequences.find("aacbbcacb"));

//MinimumDifferenceBetweenLargestandSmallestValueInThreeMoves minimumDifferenceBetweenLargestandSmallestValueInThree = new MinimumDifferenceBetweenLargestandSmallestValueInThreeMoves();
//Console.WriteLine(minimumDifferenceBetweenLargestandSmallestValueInThree.find(new int[] { 1, 5, 6, 14, 15 }));
//Console.WriteLine(minimumDifferenceBetweenLargestandSmallestValueInThree.find(new int[] { 10, 10, 10, 10, 10 }));
//Console.WriteLine(minimumDifferenceBetweenLargestandSmallestValueInThree.find(new int[] { 1, 100, 200, 300, 400 }));

//LetterCombinationOfPhoneNumber letterCombinationOfPhoneNumber = new LetterCombinationOfPhoneNumber();
//Console.WriteLine(string.Join(",",letterCombinationOfPhoneNumber.findLetter("47")));

//MaximumPointsYouCanObtainfromCards maximumPointsYouCanObtainfromCards = new MaximumPointsYouCanObtainfromCards();
//Console.WriteLine(maximumPointsYouCanObtainfromCards.find(new int[] { 10, 14, 7, 2, 8, 9, 4 },3));
//Console.WriteLine(maximumPointsYouCanObtainfromCards.find(new int[] { 1, 2, 3, 4, 5, 6 },2));
//Console.WriteLine(maximumPointsYouCanObtainfromCards.find(new int[] { 91, 24, 36, 48, 72, 19, 29 },4));

//MaximumLengthofSemiDecreasingSubarrays maximumLengthofSemiDecreasingSubarrays = new MaximumLengthofSemiDecreasingSubarrays();
//Console.WriteLine(maximumLengthofSemiDecreasingSubarrays.find(new int[] { 8, 4, 5, 3, 2 }));
//Console.WriteLine(maximumLengthofSemiDecreasingSubarrays.find(new int[] { 1, 2, 3, 4, 5 }));
//Console.WriteLine(maximumLengthofSemiDecreasingSubarrays.find(new int[] { 1, 2, 12, 2, 5, 11, 13 }));

//MinimumAreaRectangle minimumAreaRectangle = new MinimumAreaRectangle();
//Console.WriteLine(minimumAreaRectangle.find(new int[][] {
//                                                            new int[] { 1, 2 },
//                                                            new int[] { 2,1 },
//                                                            new int[] { 1,0},
//                                                            new int[] { 0,1 }
//                                                         }));
//Console.WriteLine(minimumAreaRectangle.find(new int[][] {
//                                                            new int[] { 0,1},
//                                                            new int[] { 0,3 },
//                                                            new int[] { 3,1},
//                                                            new int[] { 3,3 },
//                                                            new int[] { 4,1 },
//                                                            new int[] { 4,3 }
//                                                         }));
//Console.WriteLine(minimumAreaRectangle.find(new int[][] {
//                                                            new int[] { 1, 1 },
//                                                            new int[] { 2,2 },
//                                                            new int[] { 3,3}
//                                                         }));
// failed test case and sorting will give wrong answers
//Console.WriteLine(minimumAreaRectangle.find(new int[][] {
//                                                            new int[] { 1, 1 },
//                                                            new int[] { 1,3 },
//                                                            new int[] { 3,1},
//                                                            new int[] { 3,3},
//                                                            new int[] { 2,2}
//                                                         }));

//MinimizArrayReplacePairsWithTheirProduct minimizArrayAfterReplace = new MinimizArrayReplacePairsWithTheirProduct();
//Console.WriteLine(minimizArrayAfterReplace.find(new int[] {2,3,4,5 }, 10));
//Console.WriteLine(minimizArrayAfterReplace.find(new int[] { 1,2,2,3}, 5));
//Console.WriteLine(minimizArrayAfterReplace.find(new int[] { 10, 5, 2, 3, 4, 2, 20, 1 }, 50));

//FIndLeaves fIndLeaves = new FIndLeaves();
//List<List<int>> result = fIndLeaves.find(fIndLeaves.BuildTree());

//CookieDistribution_revise cookieDistribution_Revise = new CookieDistribution_revise();
//Console.WriteLine(cookieDistribution_Revise.find(new int[] {1,2 }, 2));
//Console.WriteLine(cookieDistribution_Revise.find(new int[] { 5, 6, 7, 3, 4 }, 2));

//RotateMatrix rotateMatrix = new RotateMatrix();
//int[][] matrix = null;
// matrix= rotateMatrix.rotate(new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } });
//for (int i = 0;i<matrix.Length;i++)
//{ 
//    Console.WriteLine(string.Join(",", matrix[i]));
//}

//matrix = rotateMatrix.rotate(new int[][] { new int[] { 5, 1, 9 }, new int[] { 2, 4, 8 }, new int[] { 13, 3, 6 } });
//for (int i = 0; i < matrix.Length; i++)
//{
//    Console.WriteLine(string.Join(",", matrix[i]));
//}

CombinationSum combinationSum = new CombinationSum();
List<List<int>> result = combinationSum.find(new int[] { 2,3,6,7},7);
if (result != null)
{
    foreach (var item in result)
    { 
        Console.WriteLine(string.Join(",", item));
    }
}