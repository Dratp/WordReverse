using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace DataStruct
{
    class Program
    {
        static void Main(string[] args)
        {
           string reversedinput = "";
            Console.WriteLine("Write a Sentence and we will reverse it for you");
           string input = Console.ReadLine();
            Stack<string> words = BreakWord(input);
            Stack<char> reverse = StringReverse(words);
            reverse.Pop();
          for(int i =0; i<reverse.Count;)
            {
                reversedinput = reversedinput + reverse.Pop();
            }
            Console.WriteLine(reversedinput);
        }


        static Stack<char> StringReverse(Stack<string> stuff)
        {
            Stack<char> letters = new Stack<char>();
            for (int i = 0; i < stuff.Count;)
            {
                string word = (string)stuff.Pop();
                for(int j =0; j < word.Length; j++)
                {
                    letters.Push(word[j]);
                }
                letters.Push(' ');
            }
            return letters;
        }
        static Stack<string> BreakWord(string sentence)
        {
            Stack<string> words = new Stack<string>();
            string SubsituteSentence = sentence;
            int Length = SubsituteSentence.Length;
            int space = SubsituteSentence.IndexOf(" ");
            for (int i = space; i > 0;)
            {
                words.Push(SubsituteSentence.Substring(0, space));
                space++;
                Length = Length - space;
                SubsituteSentence = SubsituteSentence.Substring(space, Length);
                space = SubsituteSentence.IndexOf(" ");
                i = space;
            }
            words.Push(SubsituteSentence);
            return words;
        }


    }
}
