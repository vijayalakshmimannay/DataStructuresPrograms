using System;
namespace UnOrderedList
{
    internal class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            LinkedListData list = new LinkedListData();
            list.Add("vijaya");
            list.Add("lakshmi");
            list.Add("harsha");
            //list.DisPlay();
            int a = list.Search("arjun");
            Console.WriteLine("index position of element is: " + a);
            list.InsertAtPerticularPosition(a + 1, "satya");
            // list.DisPlay();
            list.RemoveFirstNode("vijaya");
            // list.RemoveLastNode("malli");
            list.DisPlay();
        }
    }
}
