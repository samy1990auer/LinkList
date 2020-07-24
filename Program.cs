using System;

namespace HR_Prob1
{
   class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList llist = new SinglyLinkedList();
            int llistCount = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                SinglyLinkedListNode llist_head = insertNodeAtTail (llist.head, llistItem);
                llist.head = llist_head;
            }

        }
        static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
        {
            SinglyLinkedListNode new_node = new SinglyLinkedListNode(data);
            if (head == null)
            {
                head = new_node;
                return head;
            }
            SinglyLinkedListNode current_node = head;
            while (current_node.next != null)
            {
                current_node = current_node.next;
            }
            current_node.next = new_node;
            return head;
        }
    }
    class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;
        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }
    class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedList()
        {
            this.head = null;
        }
    }
}
