namespace LinkedList
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var myLinkedList = new LinkedList<int>();
            myLinkedList.First = new ListItem<int>(1);

            Console.WriteLine(myLinkedList.First.Value);
            Console.WriteLine(myLinkedList.First.NextItem);
        }
    }
}
