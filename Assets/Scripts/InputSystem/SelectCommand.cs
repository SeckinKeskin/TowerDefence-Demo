using UnityEngine;

public class SelectCommand : ICommand
{
    private GameObject selectedGameObject;
    private GridCell selectedGridCell;
    private GridSystem gridSystem;

    public SelectCommand(GameObject gameObject)
    {
        selectedGameObject = gameObject;
    }

    public void execute()
    {
        setSelectedGridCell();
        setSelectedObjects();

        if(getGridUsable())
        {
            GameManager.Instance.constractTower();
        }

        Debug.Log("Select Command");
    }

    private bool getGridUsable()
    {
        return selectedGridCell.usable;
    }

    private void setSelectedGridCell()
    {
        gridSystem = GameManager.Instance.gridSystem;

        for(int i = 0; i < gridSystem.gridCellList.Count; i++)
        {
            if(gridSystem.gridCellList[i].name == selectedGameObject.transform.name)
            {
                selectedGridCell = gridSystem.gridCellList[i];
            }
        }
    }

    private void setSelectedObjects()
    {
        GameManager.Instance.selectedGridCell = selectedGridCell;
    }
}
