using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
     class LinkedList
     {
          //Instance
            internal Node head;

        //Adding Data to LinkedList
        internal void Add(int data)
        {
            //Object of Node
            Node node = new Node(data);

            //Add Data
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        //Adding Data In Particular Position
        public void InsertAtParticularPosition(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
                Console.WriteLine("Invalid Position");
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;

                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
        }

        //Delete First element 
        internal Node POP()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }

        //Display LinkedList Data Through Method
        internal void Display()
            {
                //Head is Null then List is empty otherwise print All data of Linked List
                if (this.head == null)
                    Console.WriteLine("The list is empty.");
                else
                {
                    Node temp = head;
                    while (temp != null)
                    {
                        Console.WriteLine("Data : " + temp.data);
                        temp = temp.next;
                    }
                }
            }
     }
}
