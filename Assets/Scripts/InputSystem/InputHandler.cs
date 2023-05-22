using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private ICommand command;
    private CommandController commandController = new CommandController();

    void Update()
    {   
        if(Input.GetMouseButtonDown(0))
        {
            commandController.InputEvent(ControlTypes.Select);
        }
        else if (Input.GetMouseButtonUp(0) || Input.GetKeyUp(KeyCode.Space) || Input.GetKeyUp(KeyCode.Return))
        {
            commandController.InputEvent(ControlTypes.Build);
        }
        else if (Input.GetMouseButtonUp(1))
        {
            commandController.InputEvent(ControlTypes.Deselect);
        }
        else if (Input.GetMouseButtonUp(2))
        {
            commandController.InputEvent(ControlTypes.Destroy);
        }
    }
}