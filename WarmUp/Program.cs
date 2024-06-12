// See https://aka.ms/new-console-template for more information

using WarmUp;

Console.WriteLine("Warm Up Section");

// Console.WriteLine("Contains duplicate integer in an array");
// ContainsDuplicate containsDuplicate = new ContainsDuplicate();
// Console.WriteLine(containsDuplicate.solution(new int[]{1,2,3,4}));
// Console.WriteLine(containsDuplicate.solution(new int[]{1,2,3,1}));

Console.WriteLine("Pangram or not - A sentence contains all the english alphabets lower or upper");
Pangram pangram = new Pangram();
Console.WriteLine(pangram.solution("xx"));
Console.WriteLine(pangram.solution("This is not a pangram"));
Console.WriteLine(pangram.solution("TheQuickBrownFoxJumpsOverTheLazyDog"));

// Console.WriteLine("Reverse Vowels");
// ReverseVowels reverseVowels = new ReverseVowels();
// reverseVowels.solution("hello");
// reverseVowels.solution("AEIOU");
// reverseVowels.solution("DesignGUrus");
