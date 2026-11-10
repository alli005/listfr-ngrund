using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listfr_ngrund
{
    class Node
    {
        public int Value{get; set;}
        public Node Next{get;set;}
        public Node(int value, Node next = null)
        {
            Value = value;
            Next = next;
        }
    }
    public class LinkedList
    {
        private Node head = null;
        private int count = 0;

        public int Count
        {
            get{return count;}
        }
        public int this[int index]
        {
            get
            {
                return At(index);
            }
            set
            {
                Replace(index, value);
            }
        }
        private int At(int index)
        {
            Node current = head;
            for(int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Value;
        }
        private void Replace(int index, int value)
        {
            Node current = head;
            for(int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            current.Value = value;
        }

        public void Add(int value)
        {
            if(head == null)
            {
                head = new Node(value);
                count++;
                return;
            }
            Node current;
            for(current = head; current.Next != null; current = current.Next){}        
            Node newNode = new Node(value);
            current.Next = newNode;
            count++;
        }
        public void RemoveLast()
        {
            if(head == null)
            {
                return;
            }
            if(count == 1)
            {
                head = null;
                count--;
                return;
            }
            Node current;
            for(current = head; current.Next.Next != null; current = current.Next){}

            current.Next = null;   
            count--;             
        }
        public void RemoveAt(int index)
        {
            if(head == null)
            {
                return;
            }
            else if(index >= count)
            {
                return;
            }
            else if(index < 0)
            {
                return;
            }
            if(index == 0)
            {
                head = head.Next;
                count--;
                return;
            }
            Node current = head;
            for(int i = 0; i < index-1; i++)
            {
                current = current.Next;
            }
            current.Next = current.Next.Next;
            count--;
        }
    }
}