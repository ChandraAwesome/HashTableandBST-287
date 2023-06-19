using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_287
{
//    class TreeNode<T>
//    {
//        public T Data { get; set; }
//        public TreeNode<T> Left { get; set; }
//        public TreeNode<T> Right { get; set; }

//        public TreeNode(T data)
//        {
//            Data = data;
//            Left = null;
//            Right = null;
//        }
//    }

//    class BinaryTree<T>
//    {
//        private TreeNode<T> root;

//        public BinaryTree()
//        {
//            root = null;
//        }

//        public void Add(T data)
//        {
//            root = AddNode(root, data);
//        }

//        private TreeNode<T> AddNode(TreeNode<T> currentNode, T data)
//        {
//            if (currentNode == null)
//            {
//                return new TreeNode<T>(data);
//            }

//            if (currentNode.Left == null)
//            {
//                currentNode.Left = AddNode(currentNode.Left, data);
//            }
//            else
//            {
//                currentNode.Right = AddNode(currentNode.Right, data);
//            }

//            return currentNode;
//        }

//        public bool Search(T data)
//        {
//            return SearchNode(root, data);
//        }

//        private bool SearchNode(TreeNode<T> currentNode, T data)
//        {
//            if (currentNode == null)
//            {
//                return false;
//            }

//            if (currentNode.Data.Equals(data))
//            {
//                return true;
//            }

//            bool foundLeft = SearchNode(currentNode.Left, data);
//            bool foundRight = SearchNode(currentNode.Right, data);

//            return foundLeft || foundRight;
//        }
//    }
}

