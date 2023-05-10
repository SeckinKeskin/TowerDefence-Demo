using UnityEngine;

public class EnemyFactory : MonoBehaviour, IFactory
{
    private GameObject currentPrefab;
    private EnemyTypes currentType;

    private void Start()
    {
        currentType = EnemyTypes.Default;
    }

    public IProducible GetProduct()
    {
        SetCurrentEnemyPrefab();

        return currentPrefab.GetComponent<IProducible>();
    }

    public void Generate(Vector2 position)
    {
        GameObject newEnemy = Instantiate(currentPrefab, position, Quaternion.identity);
    }

    public void SetCurrentEnemyPrefab()
    {
        currentPrefab = EnemyManager.Instance.GetPrefabByType(currentType);
    }
}
