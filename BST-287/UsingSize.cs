using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_287
{
        class TreeNode<T>
        {
            public T Data { get; set; }
            public TreeNode<T> Left { get; set; }
            public TreeNode<T> Right { get; set; }

            public TreeNode(T data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }

        class BinaryTree<T>
        {
            private TreeNode<T> root;

            public BinaryTree()
            {
                root = null;
            }

            public void Add(T data)
            {
                root = AddNode(root, data);
            }

            private TreeNode<T> AddNode(TreeNode<T> currentNode, T data)
            {
                if (currentNode == null)
                {
                    return new TreeNode<T>(data);
                }

                if (currentNode.Left == null)
                {
                    currentNode.Left = AddNode(currentNode.Left, data);
                }
                else
                {
                    currentNode.Right = AddNode(currentNode.Right, data);
                }

                return currentNode;
            }

            public int Size()
            {
                return GetSize(root);
            }

            private int GetSize(TreeNode<T> currentNode)
            {
                if (currentNode == null)
                {
                    return 0;
                }

                int leftSize = GetSize(currentNode.Left);
                int rightSize = GetSize(currentNode.Right);

                return leftSize + rightSize + 1;
            }
        }
    
}
