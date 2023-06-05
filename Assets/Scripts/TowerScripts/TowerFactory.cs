using UnityEngine;
using System.Collections.Generic;

public class TowerFactory : MonoBehaviour, IFactory
{
    [SerializeField] private TowerType towerType;
    private List<Tower> DestroyedTowerList = new List<Tower>();

    public IProducible GetProduct()
    {
        return GetCurrentTower().GetComponent<IProducible>();
    }

    public void Generate()
    {
        Tower tower = GetCurrentTower();

        if(!HasDestroyedTowerList(tower))
        {
            Instantiate(tower.gameObject, tower.transform.position, Quaternion.identity);
        }
        else
        {
            RebuildTower(tower);
        }
    }

    private Tower GetCurrentTower()
    {
        TowerTypes currentTowerType = towerType.currentType;
        Tower tower = TowerManager.Instance.GetPrefabByType(currentTowerType).GetComponent<Tower>();

        return (!HasDestroyedTowerList(tower)) ? tower : GetTowerFromDestroyListByType();
    }

    public void SetSelectedCell(GridCellBehaviour cell)
    {
        GetCurrentTower().cellBehaviour = cell;
    }

    private void RebuildTower(Tower tower)
    {
        DestroyedTowerList.Remove(tower);
        tower.cellBehaviour.isValid = false;
        tower.gameObject.SetActive(true);
    }

    public void DestroyTower(Tower tower)
    {
        tower.gameObject.SetActive(false);
        tower.cellBehaviour.isValid = true;
        DestroyedTowerList.Add(tower);
    }

    private bool HasDestroyedTowerList(Tower tower)
    {
        if(DestroyedTowerList.Count == 0) return false;

        foreach (Tower t in DestroyedTowerList)
        {
            if(t.type == tower.type) return true;
        }

        return false;
    }

    private Tower GetTowerFromDestroyListByType()
    {
        TowerTypes type = towerType.currentType;

        foreach (Tower tower in DestroyedTowerList)
        {
            if (tower.type == type)
            {
                return tower;
            }
        }

        return null;        //Error handler needed
    }
}
