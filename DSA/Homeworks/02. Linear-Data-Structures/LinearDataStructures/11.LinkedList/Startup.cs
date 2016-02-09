namespace _11.LinkedList
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var myLinkedList = new LinkedList<int>();
            myLinkedList.First = new LinkedListItem<int>(1);
            myLinkedList.InsertAfter(myLinkedList.First, new LinkedListItem<int>(3));
            myLinkedList.InsertAfter(myLinkedList.First, new LinkedListItem<int>(2));

            Console.WriteLine(myLinkedList.First.Value);
            Console.WriteLine(myLinkedList.First.NextItem.Value);
            Console.WriteLine(myLinkedList.First.NextItem.NextItem.Value);
        }
    }
}
