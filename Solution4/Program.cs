using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution4
{
    class Program
    {
       static void Main(string[] args)
        {

           string filePath = @"C:\AbreInterview\transcript.txt";

            string[] lines = File.ReadLines(filePath).ToArray();

            foreach (var line in lines)
            {
                string[] words = line.Split(' ');
                foreach (var word in words)
                {
                    Console.WriteLine(word);
                }
            }
            Console.ReadLine(); 
        }
    }
}
    
