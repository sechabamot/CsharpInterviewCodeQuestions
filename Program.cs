using System;

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

        }


        //Q.1: How to reverse a string?
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

    }
}
