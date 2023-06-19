using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesandBST
{
class MyMapNode<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }

    class FrequencyCounter
    {
        static void Main()
        {
            string phrase = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";

            // Remove word "avoidable" from the phrase
            string modifiedPhrase = RemoveWord(phrase, "avoidable");

            Dictionary<int, LinkedList<MyMapNode<string, int>>> wordFrequency = GetWordFrequency(modifiedPhrase);

            PrintWordFrequency(wordFrequency);
        }

        public static string RemoveWord(string phrase, string wordToRemove)
        {
            // Split the phrase into words
            string[] words = phrase.Split(' ');

            // Create a list to store the modified words
            List<string> modifiedWords = new List<string>();

            // Iterate through the words
            foreach (string word in words)
            {
                if (!word.Equals(wordToRemove, StringComparison.OrdinalIgnoreCase))
                {
                    modifiedWords.Add(word);
                }
            }

            // Join the modified words back into a phrase
            string modifiedPhrase = string.Join(" ", modifiedWords);

            return modifiedPhrase;
        }

        public static Dictionary<int, LinkedList<MyMapNode<string, int>>> GetWordFrequency(string phrase)
        {
            Dictionary<int, LinkedList<MyMapNode<string, int>>> wordFrequency = new Dictionary<int, LinkedList<MyMapNode<string, int>>>();

            string[] words = phrase.Split(' ');

            foreach (string word in words)
            {
                int index = Math.Abs(word.GetHashCode()) % 10; // Using modulo 10 to limit the number of indexes

                if (!wordFrequency.ContainsKey(index))
                {
                    wordFrequency[index] = new LinkedList<MyMapNode<string, int>>();
                }

                LinkedList<MyMapNode<string, int>> linkedList = wordFrequency[index];
                MyMapNode<string, int> existingNode = null;

                foreach (var node in linkedList)
                {
                    if (node.Key.Equals(word))
                    {
                        existingNode = node;
                        break;
                    }
                }

                if (existingNode != null)
                {
                    existingNode.Value++;
                }
                else
                {
                    MyMapNode<string, int> newNode = new MyMapNode<string, int>
                    {
                        Key = word,
                        Value = 1
                    };
                    linkedList.AddLast(newNode);
                }
            }

            return wordFrequency;
        }

        public static void PrintWordFrequency(Dictionary<int, LinkedList<MyMapNode<string, int>>> wordFrequency)
        {
            Console.WriteLine("Word Frequency:");
            foreach (var kvp in wordFrequency)
            {
                Console.WriteLine($"Index {kvp.Key}:");
                foreach (var node in kvp.Value)
                {
                    Console.WriteLine($"{node.Key}: {node.Value}");
                }
                Console.WriteLine();
            }
        }
    }

}

