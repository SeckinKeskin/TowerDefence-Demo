using UnityEngine;

public class TowerFactory : MonoBehaviour, IFactory
{
    [SerializeField] private TowerType towerType;
    private GameObject currentTowerPrefab;
    private TowerTypes currentTowerType;
    private Tower currentTower;
    private GridCellBehaviour selectedCellBehaviour;

    private void Start()
    {
        SetCurrentTowerPrefab();
        SetCurrentTowerCell();
    }

    public IProducible GetProduct()
    {
        SetCurrentTowerPrefab();
        SetCurrentTowerCell();

        return currentTowerPrefab.GetComponent<IProducible>();
    }

    public void Generate()
    {
        GameObject newTower = Instantiate(currentTowerPrefab, currentTowerPrefab.transform.position, Quaternion.identity);
    }

    public void SetSelectedCell(GridCellBehaviour cell)
    {
        selectedCellBehaviour = cell;
    }

    private void SetCurrentTowerPrefab()
    {
        currentTowerType = towerType.currentType;
        currentTowerPrefab = TowerManager.Instance.GetPrefabByType(currentTowerType);
    }

    private void SetCurrentTowerCell()
    {
        currentTower = currentTowerPrefab.GetComponent<Tower>();
        currentTower.cellBehaviour = selectedCellBehaviour;
    }
}
