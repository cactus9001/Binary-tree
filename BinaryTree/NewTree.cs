﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class TreeNode
    {
        public int data;
        public TreeNode left;
        public TreeNode right;

        public TreeNode()
        {
            this.data = 0;
            this.left = null;
            this.right = null;
        }
        public TreeNode(int val)
        {
            this.data = val;
            this.left = null;
            this.right = null;
        }
    }

    
    class BinaryTree
    {
        public TreeNode root;
        public BinaryTree()
        {
            this.root = null;
        }
        public void Print(TreeNode node, int index, string indent = "")
        {
            
            string title = "";
            switch (index)
            {
                case 0: // root node
                    title = "──  Root ";
                    break;
                case -1: // left node
                    title = indent + "├──  left  ";
                    break;
                case 1: // right node
                    title = indent + "└──  right ";
                    break;
                default:
                    break;
            }
            if (index != 0)
            {
                Console.WriteLine($"{indent}│");
            }
            if (node == null)
            {
                Console.WriteLine($"{title} null");
            }
            else
            {
                Console.WriteLine($"{title} {node.data}");
                string padding = (index == -1) ? "│    " : "     "; //stolen from your code. simpler than if else.

                this.Print(node.left, -1, indent + padding);
                this.Print(node.right, 1, indent + padding);
            }
        }

        public void Display()
        {
            this.Print(this.root, 0);
        }
    }

}
