
using System.Collections.Generic;
using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.CodingChallenges.Challenge_BST_BFS
{
	//Definition for a binary tree node.
	//Do not edit
	public class TreeNode 
	{
		public int val;
		public TreeNode left;
		public TreeNode right;
		public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
			this.val = val;
			this.left = left;
			this.right = right;
		}
	}
    
    
	/// <summary>
	/// https://www.geeksforgeeks.org/tree-traversals-inorder-preorder-and-postorder/#tree-traversal-techniques
	/// </summary>
	public class Challenge_BST_BFS : BaseDemo
	{
		protected override void Start()
		{
			// Must call base
			base.Start();
            
			// Sample Binary Search Tree
			//		  1
			//		 / \
			//		2   3
			//	   / \   \
			//	  4   5   6
			TreeNode head = new TreeNode(1);
			head.left = new TreeNode(2);
			head.right = new TreeNode(3);
			head.left.left = new TreeNode(4);
			head.left.right = new TreeNode(5);
			head.right.right = new TreeNode(6);
            
            //
            Debug.Log("BST_BreadthFirstSearch() --------------");
            // Description:
            //		Create an empty queue Q
            //		Enqueue the root node of the tree to Q
	        //		Loop while Q is not empty
	        //			Dequeue a node from Q and visit it
	        //			Enqueue the left child of the dequeued node if it exists
            //			Enqueue the right child of the dequeued node if it existsEnqueue the right child of the dequeued node if it exists
	        // Time Complexity:
	        //		O(N)
            // Result:
            //		1 2 3 4 5 6 
			BST_BreadthFirstSearch(head);
            
		}

		private void BST_BreadthFirstSearch(TreeNode treeNode)
		{
			if (treeNode == null) return;

			Queue<TreeNode> queue = new Queue<TreeNode>();
			queue.Enqueue(treeNode);

			while (queue.Count > 0) 
			{
				TreeNode nextTreeNode = queue.Dequeue();
				Debug.Log("BFS: " + nextTreeNode.val + " ");

				if (nextTreeNode.left != null) queue.Enqueue(nextTreeNode.left);
				if (nextTreeNode.right != null) queue.Enqueue(nextTreeNode.right);
			}
		}
        
	}
}