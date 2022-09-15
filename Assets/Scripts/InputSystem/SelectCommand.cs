using UnityEngine;

public class SelectCommand : ICommand
{
    private GameObject selectedGameObject;
    private GridCell selectedGridCell;
    private GridSystem[] gridSystem;

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

        for(int j = 0; j < gridSystem.Length; j++)
        {
            for(int i = 0; i < gridSystem[j].gridCellList.Count; i++)
            {
                if(gridSystem[j].gridCellList[i].name == selectedGameObject.transform.name)
                {
                    selectedGridCell = gridSystem[j].gridCellList[i];
                }
            }
        }
    }

    private void setSelectedObjects()
    {
        GameManager.Instance.selectedGridCell = selectedGridCell;
    }
}
