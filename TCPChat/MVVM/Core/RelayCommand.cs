using System.Windows.Input;

namespace TCPChatClient.MVVM.Core;

public class RelayCommand(Action<object> execute, Func<object, bool> canExecute = null) : ICommand
{
    Action<object> _execute = execute;
    Func<object, bool> _canExecute = canExecute;

    public event EventHandler CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }

    public bool CanExecute(object parameter)
    {
        return _canExecute == null || _canExecute(parameter);
    }

    public void Execute(object parameter)
    {
        _execute(parameter);
    }
}
