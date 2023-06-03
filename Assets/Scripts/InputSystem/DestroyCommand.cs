using UnityEngine;

public class DestroyCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("Destroy Object Execute");

        Tower tower = GetTower();
        TowerFactory factory = GetTowerFactory();

        factory?.towerPool.Release(tower);
    }

    private GameObject GetSelectedTower()
    {
        SelectController selection = new SelectController();
        return selection.GetSelectedGameObject();
    }

    private TowerFactory GetTowerFactory()
    {
        return GameObject.FindObjectOfType<TowerFactory>();
    }

    private Tower GetTower()
    {
        return GetSelectedTower()?.GetComponent<Tower>();
    }
}