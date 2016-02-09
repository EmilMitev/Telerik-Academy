namespace _12.Stack
{
    public class Stack<T>
    {
        private int count = 0;
        private int size = 8;

        public Stack()
        {
            this.Items = new T[this.size];
        }

        public T[] Items { get; private set; }

        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }

        public void Push(T item)
        {
            this.Items[count] = item;
            this.Count++;

            if (this.Count == size)
            {
                this.size *= 2;
                var newCollection = new T[this.size];

                for (int i = 0; i < this.Count; i++)
                {
                    newCollection[i] = this.Items[i];
                }
                this.Items = newCollection;
            }
        }

        public T Pop()
        {
            var index = this.Count - 1;
            var result = this.Items[index];
            this.Items[index] = default(T);
            this.Count--;
            return result;
        }

        public T Peek()
        {
            return this.Items[this.Count - 1];
        }
    }
}