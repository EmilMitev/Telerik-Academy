namespace _11.LinkedList
{
    public class LinkedList<T>
    {
        private LinkedListItem<T> firstNode;

        public LinkedList()
        {
            this.firstNode = null;
        }

        public LinkedListItem<T> First
        {
            get { return this.firstNode; }
            set { this.firstNode = value; }
        }

        public void InsertAfter(LinkedListItem<T> node, LinkedListItem<T> newItem)
        {
            if (node.NextItem == null)
            {
                node.NextItem = new LinkedListItem<T>(newItem.Value);
                return;
            }

            var oldValue = node.NextItem.Value;
            var oldNextItem = node.NextItem.NextItem;

            node.NextItem.Value = newItem.Value;
            node.NextItem.NextItem = newItem.NextItem;

            node.NextItem.NextItem = new LinkedListItem<T>(oldValue);
            node.NextItem.NextItem.NextItem = oldNextItem;
        }
    }
}