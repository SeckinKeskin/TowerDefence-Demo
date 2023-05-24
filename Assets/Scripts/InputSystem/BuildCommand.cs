using UnityEngine;

public class BuildCommand : ICommand
{
    private GridCellBehaviour gridCellBehaviour;
    private TowerFactory towerFactory;

    public void Execute()
    {
        gridCellBehaviour = SetGridCellBehaviour();
        towerFactory = GameObject.FindObjectOfType<TowerFactory>();

        TowerGenerate();
    }

    private void TowerGenerate()
    {
        if(!gridCellBehaviour) return;

        bool isValid = gridCellBehaviour.isValid;
        
        if(isValid)
        {
            towerFactory?.SetSelectedCell(gridCellBehaviour);
            GameManager.Instance.Generator(towerFactory);
            GameManager.Instance.SetTowerType();
        }
    }

    private GridCellBehaviour SetGridCellBehaviour()
    {
        SelectCommand selectCommand = new SelectCommand();

        return selectCommand.GetSelectedGameObject()?.GetComponent<GridCellBehaviour>();
    }
}