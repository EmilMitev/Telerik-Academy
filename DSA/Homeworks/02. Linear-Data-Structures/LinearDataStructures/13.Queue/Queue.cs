namespace _13.Queue
{
    using System.Collections.Generic;

    public class Queue<T>
    {
        public Queue()
        {
            this.Items = new LinkedList<T>();
        }

        public LinkedList<T> Items { get; private set; }

        public int Count
        {
            get { return this.Items.Count; }

        }

        public void Enqueue(T item)
        {
            this.Items.AddLast(item);
        }

        public T Dequeue()
        {
            var result = Items.First.Value;
            this.Items.RemoveFirst();
            return result;
        }

        public T Peek()
        {
            return Items.First.Value;
        }

    }
}