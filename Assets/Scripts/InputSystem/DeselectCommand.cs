using UnityEngine;

public class DeselectCommand : ICommand
{
    public void execute()
    {
        Debug.Log("Deselect Command");

        if(GameManager.Instance.selectedGridCell != null)
        {
            GameManager.Instance.selectedGridCell = null;
        }
    }
}