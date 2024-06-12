// See https://aka.ms/new-console-template for more information

using WarmUp;

Console.WriteLine("Warm Up Section");

Console.WriteLine("Reverse Vowels");
ReverseVowels reverseVowels = new ReverseVowels();
reverseVowels.solution("hello");
reverseVowels.solution("AEIOU");
reverseVowels.solution("DesignGUrus");
