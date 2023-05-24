using UnityEngine;
using System.Collections.Generic;

public class EnemyFactory : MonoBehaviour, IFactory
{
    [SerializeField] private Transform generatePosition;
    [SerializeField] private EnemyType enemyType;
    private GameObject currentPrefab;
    private EnemyTypes currentType;
    private Enemy currentEnemy;
    private ObjectPool<IProducible> enemyPool = new ObjectPool<IProducible>();

    private void Start()
    {
        currentType = enemyType.nextType;
    }

    public IProducible GetProduct()
    {
        SetCurrentEnemyPrefab();

        return currentPrefab.GetComponent<IProducible>();
    }

    public void Generate()
    {
        GameObject newEnemy = Instantiate(currentPrefab, generatePosition.position, Quaternion.identity);
        AddEnemyPool();
    }

    public void SetCurrentEnemyPrefab()
    {
        currentType = enemyType.nextType;
        currentPrefab = EnemyManager.Instance.GetPrefabByType(currentType);

        enemyType.SetNextType();
    }

    public void AddEnemyPool()
    {
        currentEnemy = currentPrefab.GetComponent<Enemy>();
        enemyPool.AddObjectPool(currentEnemy);

        Debug.Log("Enemy pool size is " + enemyPool.GetObjectPool().Count);
    }
}