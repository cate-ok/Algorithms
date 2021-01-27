﻿using Algorithms.Algorithms.Tree;
using Algorithms.DataStructures.Tree;

namespace PracticeApp.Algorithms.Tree
{
    public class TreeTraversalExample
    {
        public void InOrderTraversalTest()
        {
            var root = new BinaryTreeNode("10");
            var n1 = new BinaryTreeNode("5");
            n1.left = new BinaryTreeNode("3");
            n1.right = new BinaryTreeNode("7");
            root.left = n1;
            var n2 = new BinaryTreeNode("20");
            n2.left = new BinaryTreeNode("15");
            root.right = n2;

            var treeTraversal = new TreeTraversal();
            treeTraversal.InOrderTraversal(root);
        }
    }
}
