using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class FizzBuzz
    {//Fizz Buzz
        public IList<string> fizzBuzz(int n)
        {
            List<string>  answer= new List<string>();
             for (int i = 1; i < n + 1; i++)
            {
                if (i % 5 == 0 || i % 3 == 0)
                {
                    if (i % 5 == 0 && i % 3 == 0) { answer.Add("FizzBuzz"); continue; }
                    if (i % 3 == 0) { answer.Add( "Fizz"); continue; }
                    if (i % 5 == 0) { answer.Add ( "Buzz"); continue; }
                }
                else { answer.Add( i.ToString()); continue; }
            }
            return answer;
            //String[] answer = new String[n];

            //for (int i = 1; i < n + 1; i++)
            //{
            //    if (i % 5 == 0 || i % 3 == 0)
            //    {
            //        if (i % 5 == 0 && i % 3 == 0) { answer[i - 1] = "FizzBuzz"; continue; }
            //        if (i % 3 == 0) { answer[i - 1] = "Fizz"; continue; }
            //        if (i % 5 == 0) { answer[i - 1] = "Buzz"; continue; }
            //    }
            //    else { answer[i - 1] = i.ToString(); continue; }
            //}
            //return answer;
        }
    }
}
