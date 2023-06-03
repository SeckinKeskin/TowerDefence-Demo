using UnityEngine;

public class BuildCommand : ICommand
{
    private GridCellBehaviour gridCellBehaviour;

    public void Execute()
    {
        if(!gridCellBehaviour) return;
        
        TowerFactory towerFactory = GetTowerFactory();
        bool isValid = gridCellBehaviour.isValid;

        if(isValid)
        {
            towerFactory?.SetSelectedCell(gridCellBehaviour);
            towerFactory?.towerPool.Get();
        }
    }

    private TowerFactory GetTowerFactory()
    {
        return GameObject.FindObjectOfType<TowerFactory>();
    }
}