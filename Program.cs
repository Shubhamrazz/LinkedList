using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("----Welcome to Linked List Program----");
            //Calling Class LinkedList
            LinkedList linkedList = new LinkedList();
            linkedList.Append(56);//Append means add
            linkedList.Append(30);
            linkedList.Append(70);

            //Display Data of Linked List
            linkedList.Display();

            Console.ReadLine();
        }
    }
}
