using System;

namespace LinkedList_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome_To_LinkedListApp***");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.WriteLine("\nAfter Deleting First Node");
            list.RemoveFirstNode();
            list.Display();
            Console.WriteLine("\nAfter Deleting Last Node");
            list.RemoveLastNode();
            list.Display();
            Console.WriteLine("\nNew LinkedList");
            LinkedList list1 = new LinkedList();
            list1.Add(56);
            list1.Add(30);
            list1.Add(70);
            list1.Display();
            Console.WriteLine("\nAfter Inserting Element...");
            list1.InserAtParticularPosition(3, 40);
            list1.Display();
            Console.WriteLine("\nPosition of 30--> " + list1.findPoistion(30));
            list1.deleteNode(40);
            Console.WriteLine("After Deleting Node");
            list1.Display();
            Console.WriteLine("Linkelist Size " + list1.count());
            Console.ReadLine();
        }
    }
}