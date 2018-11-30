using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
       private string _word;
       private string _sentence;
       public int multiples = 0;

       public RepeatCounter(string word, string sentence)
       {
           _word = word;
           _sentence = sentence;
           
       }

       public void SetWord(string word)
       {
           _word = word;
       }

       public string GetWord()
       {
        return _word;
       }

       public void SetSentence(string sentence)
       {
           _sentence = sentence;
       }

       public string GetSentence()
       {
           return _sentence;
       }

       public string[] SplitString()
           {
               return _sentence.Split(' ');
           }


           public int CountWord ()
           {
               foreach (string matchWord in SplitString())
               {
                   if (matchWord == _word)
                   {
                       multiples ++;
                   }
               }
               return multiples;
           }
    }
}