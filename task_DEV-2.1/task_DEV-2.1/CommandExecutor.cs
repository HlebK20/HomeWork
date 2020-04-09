using System.Windows.Input;

namespace task_DEV_2._1
{
    class CommandExecutor
    {
        public ICommand Command { get; private set; }
        public void SetCommand(ICommand command)
        {
            Command = command;
        }
        public void ExecuteCommand()
        {
            Command.Execute();
        }
    }
}
