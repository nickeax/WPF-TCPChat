using ChatServer;
using System.Net;

Server server = new(IPAddress.Any, 10_000);

server.InitialiseServer();