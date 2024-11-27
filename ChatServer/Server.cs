using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer;
public class Server
{
    List<Client> _users;
    TcpListener _tcpListener;
    public Server(IPAddress iPAddress, int port)
    {
        _users = new List<Client>();
        _tcpListener = new(iPAddress, port);
    }

    public void InitialiseServer()
    {
        _tcpListener.Start();
    }

    void AcceptClients()
    {
        while (true)
        {
            var client = new Client(_tcpListener.AcceptTcpClient());
            _users.Add(client);
            Console.WriteLine($"Client has connected!");
            // Broadcast the connection to everyone on the server

        }
    }
}
