using System.Net.Sockets;

namespace TCPChatClient.Net;

public class Server
{
    TcpClient _client;

    public Server()
    {
        _client = new TcpClient();
    }

    public void Connect(string ip, int port)
    {
        if (!_client.Connected)
        {
            _client.Connect(ip, port);
        }
    }
}
