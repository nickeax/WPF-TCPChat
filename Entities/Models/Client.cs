using System.Net.Sockets;

namespace Entities.Models;
public class Client
{
    public string Username { get; set; }
    public Guid UID { get; set; }
    public TcpClient ClientSocket { get; set; }
    public Client(TcpClient client)
    {
        ClientSocket = client;
        UID = Guid.NewGuid();

        Console.WriteLine($"[{DateTime.Now}]: Client has connected with the username: {Username}");
    }
}
