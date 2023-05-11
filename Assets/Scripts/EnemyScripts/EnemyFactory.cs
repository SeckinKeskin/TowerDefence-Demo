using UnityEngine;

public class EnemyFactory : MonoBehaviour, IFactory
{
    [SerializeField] private EnemyType enemyType;
    private GameObject currentPrefab;
    private EnemyTypes currentType;

    private void Start()
    {
        currentType = enemyType.nextType;
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