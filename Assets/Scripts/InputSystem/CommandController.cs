public class CommandController
{
    private ICommand currentCommand;

    public ICommand GetCommand(ControlTypes controlType)
    {
        switch(controlType)
        {
            case ControlTypes.Build:
                return new BuildCommand();
            case ControlTypes.Destroy:
                return new DestroyCommand();
            default:
                return new InfoCommand();
        }
    }

    public void InputEvent(ControlTypes type)
    {
        currentCommand = GetCommand(type);
        currentCommand.Execute();
    }
}