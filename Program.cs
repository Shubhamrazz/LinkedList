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
            //Calling Class LinkedList
            LinkedList linkedList = new LinkedList();
            linkedList.Append(56);
            linkedList.Append(70);

            //Display Data Before Adding into  Linked List
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Display Data Before Adding into  Linked List ::");
            Console.WriteLine("-----------------------------------------------");
            linkedList.Display();

            //Adding Data Between 2 Data
            linkedList.InsertAtParticularPosition(2, 30);

            //Display Data After Adding into  Linked List
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Display Data Before Adding into  Linked List ::");
            Console.WriteLine("-----------------------------------------------");

            linkedList.Display();

            Console.ReadLine();

        }
    }
}
