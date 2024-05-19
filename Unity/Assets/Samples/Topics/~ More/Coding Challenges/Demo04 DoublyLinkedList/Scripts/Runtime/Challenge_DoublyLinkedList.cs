using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.CodingChallenges.DoublyLinkedList
{
    //Definition for singly-linked list.
    //Do not edit
    public class ListNode 
    {
        public int val;
        public ListNode previous;
        public ListNode next;
        public ListNode(int val=0, ListNode previous=null, ListNode next=null) {
            this.val = val;
            this.previous = previous;
            this.next = next;
        }
    }
 
    
	/// <summary>
	/// https://www.geeksforgeeks.org/linked-list-implementation-in-c-sharp/
	/// </summary>
	public class Challenge_DoublyLinkedList : BaseDemo
	{
		protected override void Start()
		{
			// Must call base
			base.Start();
            
            // Sample Doubly linked list
            ListNode head = new ListNode(1, null, null);
            ListNode second = new ListNode(2, head, null);
            head.next = second;
            ListNode third = new ListNode(3, second, null);
            second.next = third;
			ListNode fourth = new ListNode(4, third, null);
		    third.next = fourth;
		    ListNode fifth = new ListNode(5, fourth, null);
		    fourth.next = fifth;
            
			
            //
            Debug.Log("LinkedListForward() --------------");
			LinkedListForward(head);
            
            //
            Debug.Log("LinkedListBackward() --------------");
            LinkedListBackward(head);
		}

		private void LinkedListForward(ListNode listNode)
		{
            ListNode currentNode = listNode;
            while (currentNode != null)
            {
                Debug.Log("Val: " + currentNode.val);
                currentNode = currentNode.next;
            }
		}
        
		private void LinkedListBackward(ListNode head)
		{
			// 1. Find the last node
			ListNode lastNode = head;

			if (lastNode == null)
			{
				return;
			}
    
			while (lastNode.next != null)
			{
				lastNode = lastNode.next;
			}
    
			// 2. Now move backwards 
			while (lastNode != null)
			{
				Debug.Log("Val: " + lastNode.val);
        
				// Move to the previous node
				lastNode = lastNode.previous;
			}
		}
	}
}