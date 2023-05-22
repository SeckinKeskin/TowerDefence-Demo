public class CommandController
{
    private ICommand currentCommand;

    public ICommand GetCommand(ControlTypes controlType)
    {
        switch(controlType)
        {
            case ControlTypes.Select:
                return new SelectCommand();
            case ControlTypes.Build:
                return new BuildCommand();
            case ControlTypes.Deselect:
                return new DeselectCommand();
            default:
                return new SelectCommand();
        }
    }

    public void InputEvent(ControlTypes type)
    {
        currentCommand = GetCommand(type);
        currentCommand.Execute();
    }
}