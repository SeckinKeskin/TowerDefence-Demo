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

    public void Generate(Vector2 position)
    {
        GameObject newTower = Instantiate(currentTowerPrefab, position, Quaternion.identity);
    }

    private void SetCurrentTowerPrefab()
    {
        currentTowerType = towerType.currentType;
        currentTowerPrefab = TowerManager.Instance.GetPrefabByType(currentTowerType);
    }
}
