using UnityEngine;

public class BuildCommand : ICommand
{
    private GridCellBehaviour gridCellBehaviour;

    public void Execute()
    {
        if(!GetGridCellBehaviour()) return;
        
        TowerFactory towerFactory = GetTowerFactory();
        gridCellBehaviour = GetGridCellBehaviour();
        bool isValid = gridCellBehaviour.isValid;

        if(isValid)
        {
            towerFactory?.SetSelectedCell(gridCellBehaviour);
            GameManager.Instance.Generator(towerFactory);
            GameManager.Instance.SetTowerType();
        }
    }

    private TowerFactory GetTowerFactory()
    {
        return GameObject.FindObjectOfType<TowerFactory>();
    }

    private GridCellBehaviour GetGridCellBehaviour()
    {
        SelectController selection = new SelectController();
        return selection.GetSelectedGameObject().GetComponent<GridCellBehaviour>();
    }
}