namespace _13.Queue
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            var count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(queue.Peek());
                queue.Dequeue();
            }
        }
    }
}
