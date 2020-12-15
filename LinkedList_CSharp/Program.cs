using System;

namespace LinkedList_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome_To_LinkedListApp***");
            LinkedList list = new LinkedList();
            Console.WriteLine("Add_To_Begining");
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Display();
            Console.ReadLine();
        }
    }
}
