/* Count Words in a File
Problem Statement: Write a C# program that counts the number of words in a given text file and displays the top 5 most frequently
occurring words.
Requirements: Use StreamReader to read the file. Use a Dictionary<string, int> to count word occurrences. Sort the words 
based on frequency and display the top 5. */

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace Streams
{
    public static class WordCounter{
    
    // Reads file and prints top 5 most frequent words
    public static void CountTopWords(string filepath)
    {
        Dictionary<string,int> wc = new Dictionary<string,int>();
        using(StreamReader reader = new StreamReader(filepath)){
            string line;
            while((line = reader.ReadLine()) != null){
                // Split line into words
                string[] words = line.Split(' ','.',',');
                foreach(string word in words){
                    if(string.IsNullOrWhiteSpace(word)) continue;
                    string key = word.ToLower();
                    if(wc.ContainsKey(key)){
                        wc[key]++;
                    }else{
                        wc[key] = 1;
                    }
                }
            }

            // Sort and get top 5 words
            var topwords = wc.OrderByDescending(x => x.Value).Take(5);
            Console.WriteLine("top 5 most frequent words");
            foreach(var item in topwords){
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
}
