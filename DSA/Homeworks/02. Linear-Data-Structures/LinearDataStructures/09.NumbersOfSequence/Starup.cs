namespace _09.NumbersOfSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Starup
    {
        public static void Main()
        {
            Console.Write("Enter N: ");
            int firstNumber = int.Parse(Console.ReadLine());

            int count = 50;

            var queue = new Queue<int>();

            queue.Enqueue(firstNumber);

            for (int i = 0; i < count; i++)
            {
                queue.Enqueue(queue.Peek() + 1);
                queue.Enqueue(2 * queue.Peek() + 1);
                queue.Enqueue(queue.Peek() + 2);

                Console.Write(queue.Dequeue() + " ");
            }

            while (queue.Count > 0)
            {
                Console.Write(queue.Dequeue() + " ");
            }
        }
    }
}
