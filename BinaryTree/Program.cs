using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBinaryTree tree = new MyBinaryTree();

            /*********************/
            /**** Test Case 1 ****/
            /*********************/
            Console.WriteLine("\n## TC1: Build the following tree ###");
            //               1 (root)
            //       ┏━━━━━━━┻━━━━━━━┓
            //       2               3
            //   ┏━━━┻━━━┓       ┏━━━┻━━━┓
            //   4       5       6       n
            // ┏━┻━┓   ┏━┻━┓   ┏━┻━┓   
            // n   7   n   n   n   n 
            //    ┏┻┓              
            //    n n
            tree.Root = new MyBinaryTreeNode(1);
            tree.Root.Left = new MyBinaryTreeNode(2);
            tree.Root.Left.Left = new MyBinaryTreeNode(4);
            tree.Root.Left.Left.Right = new MyBinaryTreeNode(7);
            tree.Root.Left.Right = new MyBinaryTreeNode(5);
            tree.Root.Right = new MyBinaryTreeNode(3);
            tree.Root.Right.Left = new MyBinaryTreeNode(6);
            tree.Dump();
            Console.WriteLine("### End Of TC1 ###\n");

            /*********************/
            /**** Test Case 2 ****/
            /*********************/
            Console.WriteLine("\n## TC2: Traverse tree use pre-order ###");
            tree.Traversal(MyBinaryTree.TraversalOrder.PreOrder);

            Console.WriteLine("### End Of TC2 ###\n");

            /*********************/
            /**** Test Case 3 ****/
            /*********************/
            Console.WriteLine("\n## TC3: Traverse tree use in-order ###");
            tree.Traversal(MyBinaryTree.TraversalOrder.InOrder);
            Console.WriteLine("### End Of TC3 ###\n");

            // ...
            // Create your test cases here
            // ...
            //               9 (root)
            //       ┏━━━━━━━┻━━━━━━━┓
            //       8               7
            //   ┏━━━┻━━━┓       ┏━━━┻━━━┓
            //   n       6       5       n
            //         ┏━┻━┓   ┏━┻━┓
            //         4   n   3   n 
            //        ┏┻┓              
            //        2 1

            Console.WriteLine("Make new tree");
            tree.Root = new MyBinaryTreeNode(9);
            tree.Root.Left = new MyBinaryTreeNode(8);
            tree.Root.Left.Right = new MyBinaryTreeNode(6);
            tree.Root.Left.Right.Left = new MyBinaryTreeNode(4);
            tree.Root.Left.Right.Left.Left = new MyBinaryTreeNode(2);
            tree.Root.Left.Right.Left.Right = new MyBinaryTreeNode(1);
            tree.Root.Right = new MyBinaryTreeNode(7);
            tree.Root.Right.Left = new MyBinaryTreeNode(5);
            tree.Root.Right.Left.Left = new MyBinaryTreeNode(3);
            tree.Dump();
            Console.WriteLine("End of tree");

            ///////////////////////////////////////////////////////////////////////////////
            
            BinaryTree myTree = new BinaryTree();
            //testing
            Console.WriteLine("\nStart of new tree using my own class");
            myTree.root = new TreeNode(2);
            myTree.root.left = new TreeNode(7);
            myTree.root.left.left = new TreeNode(2);
            myTree.root.left.right = new TreeNode(6);
            myTree.root.left.right.left = new TreeNode(5);
            myTree.root.left.right.right = new TreeNode(11);
            myTree.root.right = new TreeNode(5);
            myTree.root.right.right = new TreeNode(9);
            myTree.root.right.right.left = new TreeNode(4);
            //print tree
            myTree.Display();
            Console.WriteLine("End of new tree");
            Console.WriteLine("This is a post commit change");
        }
    }
}
