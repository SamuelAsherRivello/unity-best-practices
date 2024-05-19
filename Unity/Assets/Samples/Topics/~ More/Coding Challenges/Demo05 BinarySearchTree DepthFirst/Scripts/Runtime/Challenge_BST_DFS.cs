using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.CodingChallenges.Challenge_BST_DFS
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
    public class Challenge_BST_DFS : BaseDemo
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
            //	  4   5   (null)
            TreeNode head = new TreeNode(1);
            head.left = new TreeNode(2);
            head.right = new TreeNode(3);
            head.left.left = new TreeNode(4);
            head.left.right = new TreeNode(5);
            
            //
            Debug.Log("Challenge_BST_DFS() --------------");
            // Description:
            //		Traverse the left subtree
            //		Visit the root
            //		Traverse the right subtree
            // Time Complexity:
            //		O(N)
            // Result:
            //		4 2 5 1 3 
            BST_DeptFirstSearch_InOrder(head);
            
        }

        private void BST_DeptFirstSearch_InOrder(TreeNode treeNode)
        {
            // Base case
            if (treeNode == null)
            {
                return;
            }

            // Recur on the left subtree
            BST_DeptFirstSearch_InOrder(treeNode.left);
      
            // Visit the current node
            Debug.Log("DFS val: " + treeNode.val);
      
            // Recur on the right subtree
            BST_DeptFirstSearch_InOrder(treeNode.right);
        }
        
    }
}