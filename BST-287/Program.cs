
namespace BST_287
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            bst.Add(56); // Adding 56 as root
            bst.Add(30); // Adding 30 to the left
            bst.Add(70); // Adding 70 to the right

            Console.WriteLine("Inorder Traversal of the Binary Search Tree:");
            bst.InorderTraversal();

            /**************************************************************/

            BinaryTree<int> binaryTree = new BinaryTree<int>();

            // Creating the binary tree shown in the figure
            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(3);
            binaryTree.Add(4);
            binaryTree.Add(5);

            int size = binaryTree.Size();

            Console.WriteLine("Size of the binary tree: " + size);

            /**********************************************************/

            //BinaryTree<int> binaryTree = new BinaryTree<int>();

            //binaryTree.Add(56);
            //binaryTree.Add(30);
            //binaryTree.Add(70);
            //binaryTree.Add(22);
            //binaryTree.Add(40);
            //binaryTree.Add(11);
            //binaryTree.Add(3);
            //binaryTree.Add(16);
            //binaryTree.Add(63);
            //binaryTree.Add(67);

         //   bool found63 = binaryTree.Search(63);

           // Console.WriteLine("Search result for 63: " + found63);
        }
    }
}