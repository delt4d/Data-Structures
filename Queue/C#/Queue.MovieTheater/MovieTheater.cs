namespace C_.MovieTheater
{
    public class MovieTheater
    {
        private readonly MyQueue<Client> clients = new();
        public MyQueue<Client> Clients => clients;
        public void AddClient(Client client)
        {
            clients.Insert(client);
        }
        public void RemoveClient()
        {
            clients.Remove();
        }
        public void Query(Client client, out Node<Client>? currentNode, out Node<Client>? previousNode)
        {
            Clients.Query(client, out currentNode, out previousNode);
        }
        public void Print()
        {
            Clients.Show(client => client.Name);
        }
    }
}