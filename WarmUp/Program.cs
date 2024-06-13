// See https://aka.ms/new-console-template for more information

using WarmUp;

Console.WriteLine("Warm Up Section");

// Console.WriteLine("Contains duplicate integer in an array");
// ContainsDuplicate containsDuplicate = new ContainsDuplicate();
// Console.WriteLine(containsDuplicate.solution(new int[]{1,2,3,4}));
// Console.WriteLine(containsDuplicate.solution(new int[]{1,2,3,1}));

// Console.WriteLine("Pangram or not - A sentence contains all the english alphabets lower or upper");
// Pangram pangram = new Pangram();
// Console.WriteLine(pangram.solution("xx"));
// Console.WriteLine(pangram.solution("This is not a pangram"));
// Console.WriteLine(pangram.solution("TheQuickBrownFoxJumpsOverTheLazyDog"));


Console.WriteLine("palindrome: identify the given phrase is palindrome? after removing all non alphanumeric, phrase can contain upper and lower case letter");
ValidPalindrome validPalindrome = new ValidPalindrome();
Console.WriteLine(validPalindrome.solution("A man, a plan, a canal, Panama!"));
Console.WriteLine(validPalindrome.solution("Was it a car or a cat I saw?"));
Console.WriteLine(validPalindrome.solution("aBcbA"));
Console.WriteLine(validPalindrome.solution("aBxa"));

// Console.WriteLine("Reverse Vowels");
// ReverseVowels reverseVowels = new ReverseVowels();
// reverseVowels.solution("hello");
// reverseVowels.solution("AEIOU");
// reverseVowels.solution("DesignGUrus");
