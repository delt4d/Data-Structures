namespace C_.MovieTheater
{
    public class ExtendedQueue : MyQueue<int>
    {
        public void RemoveAllNegatives()
        {
            Node<int>? currentNode = this.Start;
            Node<int>? previousNode = null;

            while (currentNode != null)
            {
                if (currentNode.Value < 0)
                {
                    if (previousNode == null)
                        this.Start = currentNode.Next;
                    else
                        previousNode.Next = currentNode.Next;

                    if (currentNode == this.End)
                        this.End = previousNode;

                    currentNode = currentNode.Next;
                }
                else
                {
                    previousNode = currentNode;
                    currentNode = currentNode.Next;
                }
            }
        }
    }
}