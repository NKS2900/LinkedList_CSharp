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
            list.Add(70);
            list.Display();
            Console.WriteLine("\nAfter Inserting Element...");
            list.InserAtParticularPosition(2, 30);
            list.Display();
            Console.WriteLine("\nAfter Deleting First Node");
            list.RemoveFirstNode();
            list.Display();
            Console.WriteLine("\nAfter Deleting Last Node");
            list.RemoveLastNode();
            list.Display();
            Console.ReadLine();
        }
    }
}
