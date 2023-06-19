using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_287
{
    class MyBinaryNode<TKey> where TKey : IComparable<TKey>
    {
        public TKey Key { get; set; }
        public MyBinaryNode<TKey> Left { get; set; }
        public MyBinaryNode<TKey> Right { get; set; }

        public MyBinaryNode(TKey key)
        {
            Key = key;
            Left = null;
            Right = null;
        }
    }

    class BinarySearchTree<TKey> where TKey : IComparable<TKey>
    {
        private MyBinaryNode<TKey> root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Add(TKey key)
        {
            root = AddNode(root, key);
        }

        private MyBinaryNode<TKey> AddNode(MyBinaryNode<TKey> currentNode, TKey key)
        {
            if (currentNode == null)
            {
                currentNode = new MyBinaryNode<TKey>(key);
            }
            else if (key.CompareTo(currentNode.Key) < 0)
            {
                currentNode.Left = AddNode(currentNode.Left, key);
            }
            else if (key.CompareTo(currentNode.Key) > 0)
            {
                currentNode.Right = AddNode(currentNode.Right, key);
            }

            return currentNode;
        }

        public void InorderTraversal()
        {
            InorderTraversal(root);
        }

        private void InorderTraversal(MyBinaryNode<TKey> currentNode)
        {
            if (currentNode != null)
            {
                InorderTraversal(currentNode.Left);
                Console.Write(currentNode.Key + " ");
                InorderTraversal(currentNode.Right);
            }
        }
    }

}
