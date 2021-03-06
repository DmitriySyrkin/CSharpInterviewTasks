﻿using System;

namespace BinaryTreeDepth
{
	// 50.	Write a function to find the depth of a binary tree.
	// TODO: Figure out the type of node's values and how data should be inserted
	// Currently implemented as basic binary search tree (values that are less then current - placed at the left,
	// greater or equal - to the right of the current node
	class Program
	{
		private static void Main(string[] args)
		{
			BinaryTree tree = new BinaryTree();

			tree.Insert(25);
			tree.Insert(10);
			tree.Insert(50);
			tree.Insert(100);
			tree.Insert(18);
			tree.Insert(8);
			tree.Insert(6);
			tree.Insert(66);

			int depth = tree.GetDepthRecursive();
			Console.WriteLine(depth);
			tree.TraverseRecursive(BinaryTree.TraversalType.PreOrder);
			Console.WriteLine();
			tree.TraverseRecursive(BinaryTree.TraversalType.InOrder);
			Console.WriteLine();
			tree.TraverseRecursive(BinaryTree.TraversalType.PostOrder);
			Console.WriteLine();
			/*
			tree.TraverseMorrisPreOrder();
			Console.WriteLine();
			tree.TraverseMorrisInOrder();
			Console.WriteLine();

			tree.TraversePreOrderStack();
			Console.WriteLine();

			tree.TraverseBreadth();
			Console.WriteLine();
			 */
			int maxDepth = tree.GetMaxDepth();
			Console.WriteLine(maxDepth);
			//tree.TraverseDictionary();
		}
	}
}
