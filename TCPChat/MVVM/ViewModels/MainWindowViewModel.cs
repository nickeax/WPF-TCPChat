using System.Security.RightsManagement;
using TCPChatClient.MVVM.Core;
using TCPChatClient.Net;

namespace TCPChatClient.MVVM.ViewModels;

public class MainWindowViewModel
{
    public RelayCommand ConnectToServerCommand { get; set; }
    Server _server;

    public MainWindowViewModel()
    {
        _server = new Server();
        ConnectToServerCommand = new RelayCommand(o => _server.Connect("127.0.0.1", 10_000));
    }
}
