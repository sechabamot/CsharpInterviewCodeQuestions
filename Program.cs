using System;
using System.Collections.Generic;

namespace CsharpInterviewCodeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1
            string inputToReverse = "sechaba";
            Console.WriteLine($"The revers of '{inputToReverse}' is: {ReturnReversString(inputToReverse)}");
            //Q2 
            string pallindrome = "madam";
            Console.WriteLine($"Is the text '{pallindrome}' a pallindrome:{CheckIfPallindrome(pallindrome)}");
            //Q3
            string sentenceToReverse = "this is a wild cart";
            Console.WriteLine($"This sentence '{sentenceToReverse}' read backwords is: {ReverseTheSentence(sentenceToReverse)}");
            //Q4
            int[] intArray = new int[] {2,4,6,5};
            Console.WriteLine($"The total of the even numbers in [2,4,6,5] array are: {ReturnTotalOfEvenNumbers(intArray)}");
            //Q5
            string countCharacters = "Count these characters";
            Console.WriteLine($"Total character count in [ {countCharacters} ] : {CountOccurrences(countCharacters)}");
            //Q6
            string removeDuplicates = "aaaabbbbccccddddeeeeffff";
            Console.WriteLine($"After removing duplicates in  [{removeDuplicates}]  we get : {RemoveDuplicateChar(removeDuplicates)}");
        }


        //Q1: How to reverse a string?
        public static string ReturnReversString(string input)
        {
            string output ="";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            return output;
        }

        //Q2: How to find if the given string is a palindrome or not?
        public static bool CheckIfPallindrome(string input)
        {
            string revers = "";
            for (int i = input.Length -1 ; i >= 0; i--)
            {
                revers += input[i];
            }

            if (revers == input)
            {
                return true;
            }

            return false;
        }

        //Q3: Reverse the order of words in a given string?
        public static string ReverseTheSentence(string input)
        {
            string output = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == ' ')
                {
                    output += input.Substring(i + 1) + " ";
                    input = input.Remove(i);
                }
                if (i == 0)
                {
                    output += input.Substring(i);
                }
            }

            return output;
        }

        //Q4: Given an array of ints, write a C# method to total all the values that are even numbers.
        public static int ReturnTotalOfEvenNumbers(int[] array)
        {
            int output = 0;
            foreach (int nu in array)
            {
                if (nu % 2 == 0)
                {
                    output += nu;
                }
            }
            return output;
        }

        //Q5: How to count the occurrence of each character in a string?
        public static string CountOccurrences(string input)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();
            string output = "";

            foreach (var character in input.ToLower())
            {
                
                if (!char.IsWhiteSpace(character))
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }
            }

            foreach (var character in characterCount)
            {
                output  += $"[ {character.Key} : {character.Value}] ";
                //Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }

            return output;
        }

        //Q6: How to remove duplicate characters from a string?
        public static string RemoveDuplicateChar(string input)
        {
            string output = "";
            foreach (char c in input)
            {
                if (!output.Contains(c))
                {
                    output += c;
                }
            }
            return output;
        }
    }
}
