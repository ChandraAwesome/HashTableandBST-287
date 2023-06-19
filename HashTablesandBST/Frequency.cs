using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            Dictionary<int, LinkedList<MyMapNode<string, int>>> wordFrequency = GetWordFrequency(paragraph);

            PrintWordFrequency(wordFrequency);
        }

        public static Dictionary<int, LinkedList<MyMapNode<string, int>>> GetWordFrequency(string paragraph)
        {
            Dictionary<int, LinkedList<MyMapNode<string, int>>> wordFrequency = new Dictionary<int, LinkedList<MyMapNode<string, int>>>();

            string[] words = paragraph.Split(' ');

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


