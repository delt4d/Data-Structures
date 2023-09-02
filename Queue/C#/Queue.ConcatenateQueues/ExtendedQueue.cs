namespace C_.MovieTheater
{
    public class ExtendedQueue<T> : MyQueue<T>
    {
        public MyQueue<T> ConcatenateWith(MyQueue<T> secondQueue)
        {
            var newQueue = new MyQueue<T>();

            Node<T>? currentNode;

            currentNode = this.Start;
            while (currentNode != null)
            {
                newQueue.Insert(currentNode.Value);
                currentNode = currentNode.Next;
            }

            currentNode = secondQueue.Start;
            while (currentNode != null)
            {
                newQueue.Insert(currentNode.Value);
                currentNode = currentNode.Next;
            }

            return newQueue;
        }
    }
}