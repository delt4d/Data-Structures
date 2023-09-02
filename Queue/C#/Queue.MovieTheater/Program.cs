using C_.MovieTheater;

static void FindNode(MyQueue<Client> queue, Client client)
{
    var result = queue.Query(client, out var currentNode, out var previousNode);

    Console.WriteLine($"\nClient {client.Name} found? " + result);

    if (result == true)
    {
        Console.WriteLine($"Previous node: {(previousNode != null ? previousNode.Value.Name : "")}");
        Console.WriteLine($"Current node: {currentNode!.Value.Name}");
    }
}

var movieTheater = new MovieTheater();

var clientRebeca = new Client
{
    Age = 20,
    AmountPaidForTheTicket = 10,
    Name = "Rebeca",
    PaidHalf = false
};
var clientMary = new Client
{
    Age = 18,
    AmountPaidForTheTicket = 5,
    Name = "Mary",
    PaidHalf = true
};
var clientJohn = new Client
{
    Age = 42,
    AmountPaidForTheTicket = 10,
    Name = "John",
    PaidHalf = false
};
var clientDavid = new Client
{
    Age = 45,
    AmountPaidForTheTicket = 5,
    Name = "David",
    PaidHalf = true
};
var clientSarah = new Client
{
    Age = 74,
    AmountPaidForTheTicket = 10,
    Name = "Sarah",
    PaidHalf = false
};
var clientHenri = new Client
{
    Age = 20,
    AmountPaidForTheTicket = 5,
    Name = "Henri",
    PaidHalf = true
};

movieTheater.AddClient(clientRebeca);
movieTheater.AddClient(clientMary);
movieTheater.AddClient(clientJohn);
movieTheater.AddClient(clientDavid);
movieTheater.AddClient(clientSarah);
movieTheater.Print();

FindNode(movieTheater.Clients, clientSarah);
FindNode(movieTheater.Clients, clientHenri);

movieTheater.RemoveClient();
movieTheater.RemoveClient();
movieTheater.Print();

movieTheater.AddClient(clientHenri);
FindNode(movieTheater.Clients, clientJohn);
FindNode(movieTheater.Clients, clientMary);

movieTheater.Print();