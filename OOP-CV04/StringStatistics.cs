using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOP_CV04
{
    class StringStatistics
    {
        private String text = null;

        public StringStatistics(String text) {
            this.text = text;
        }

        public int wordCount() {
            int wordCount = 0;
            char[] separators = { ' ', ',', '?', '.', '\n' };
            string[] subs = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}", string.Join(" ", subs));
            foreach (String item in subs)
            {
                wordCount += 1; 
            }
            return wordCount;
        }

        public int lineCount() {
            int lineCount = 0;

            char[] separators = { '\n' };
            string[] subs = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (String item in subs)
            {
                lineCount += 1;
            }

            return lineCount;
        }

        public int sentenceCount()
        {
            int sentenceCount = 0;

            //char[] separators = { '.', '!', '?' };
            //string[] subs = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] subs = Regex.Split(text, @"[.!?]\s[A-Z]");
            foreach (String item in subs)
            {
                sentenceCount += 1;
            }

            return sentenceCount;
        }

        public String[] longestWords() {

            char[] separators = { ',', '!', '?', '.', '(', ')', ' ', '\n' };
            string[] subs = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            
            List<string> list = new List<string>();
            int pocet = 0;
            foreach (String item in subs)
            {
                if (item.Length > pocet)
                {
                    pocet = item.Length;
                    list.Clear();
                    list.Add(item);
                    
                }
                else if (item.Length == pocet) {
                    list.Add(item);
                }
                
            }
            string[] longest = list.ToArray();
            
            return longest;
        }
        public String mostFrequentElement()
        {
            int longestCount = 1;
            int count = 1;
            string previous = "";
            string mostFrequent = "";

            foreach (string item in sortAlfabeticaly())
            {
                if (item == previous)
                {
                    count++;
                    if (count > longestCount)
                    {
                        longestCount = count;
                        mostFrequent = item;
                    }

                }
                else if (previous != item)
                {
                    count = 1;
                }
                previous = item;
            }

            return mostFrequent;

        }

        public String[] shortestWords()
        {

            char[] separators = { ',', '!', '?', '.', '(', ')', ' ', '\n' };
            string[] subs = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<string> list = new List<string>();
            int pocet = int.MaxValue;
            foreach (String item in subs)
            {
                if (item.Length < pocet)
                {
                    pocet = item.Length;
                    list.Clear();
                    list.Add(item);

                }
                else if (item.Length == pocet)
                {
                    list.Add(item);
                }

            }
            string[] shortest = list.ToArray();

            return shortest;
        }

        public String[] sortAlfabeticaly()
        {
            char[] separators = { ',', '!', '?', '.', '(', ')', ' ', '\n' };
            string[] subs = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(subs);

            return subs;

        }

    }
}
