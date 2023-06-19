using System.Text.RegularExpressions;

namespace HashTablesandBST
{
    using System;
    using System.Collections.Generic;

    class MyMapNode<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }

    class FrequencyCounter
    {
        public static void Main()
        {
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            Dictionary<int, LinkedList<MyMapNode<string, int>>> hashTable = GetWordFrequency(paragraph);

            Console.WriteLine("Word Frequency:");
            foreach (var kvp in hashTable)
            {
                Console.WriteLine($"Index {kvp.Key}:");
                foreach (var node in kvp.Value)
                {
                    Console.WriteLine($"{node.Key}: {node.Value}");
                }
                Console.WriteLine();
            }
        }

        public static Dictionary<int, LinkedList<MyMapNode<string, int>>> GetWordFrequency(string paragraph)
        {
            Dictionary<int, LinkedList<MyMapNode<string, int>>> hashTable = new Dictionary<int, LinkedList<MyMapNode<string, int>>>();

            string[] words = paragraph.Split(' ');

            foreach (string word in words)
            {
                int index = Math.Abs(word.GetHashCode()) % 10; // Using modulo 10 to limit the number of indexes

                if (!hashTable.ContainsKey(index))
                {
                    hashTable[index] = new LinkedList<MyMapNode<string, int>>();
                }

                LinkedList<MyMapNode<string, int>> linkedList = hashTable[index];
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

            return hashTable;
        }
    }

}