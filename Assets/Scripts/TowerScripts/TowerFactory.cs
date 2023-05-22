using UnityEngine;

public class TowerFactory : MonoBehaviour, IFactory
{
    [SerializeField] private TowerType towerType;
    private GameObject currentTowerPrefab;
    private TowerTypes currentTowerType;

    private void Start()
    {
        SetCurrentTowerPrefab();
    }

    public IProducible GetProduct()
    {
        SetCurrentTowerPrefab();

        return currentTowerPrefab.GetComponent<IProducible>();
    }

    public void Generate()
    {
        GameObject newTower = Instantiate(currentTowerPrefab, Vector2.zero, Quaternion.identity);
    }

    private void SetCurrentTowerPrefab()
    {
        currentTowerType = towerType.currentType;
        currentTowerPrefab = TowerManager.Instance.GetPrefabByType(currentTowerType);
    }
}
