namespace LinkedList
{
    public class LinkedList<T>
    {
        private ListItem<T> firstNode;

        public LinkedList()
        {
            this.firstNode = null;
        }

        public ListItem<T> First
        {
            get { return this.firstNode; }
            set { this.firstNode = value; }
        }
    }
}
