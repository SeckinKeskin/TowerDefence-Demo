using UnityEngine;
using System.Collections.Generic;

public class EnemyFactory : MonoBehaviour, IFactory
{
    [SerializeField] private Transform generatePosition;
    [SerializeField] private EnemyType enemyType;
    private GameObject currentPrefab;
    private EnemyTypes currentType;
    private Enemy currentEnemy;

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
    }

    public void SetCurrentEnemyPrefab()
    {
        currentType = enemyType.nextType;
        currentPrefab = EnemyManager.Instance.GetPrefabByType(currentType);

        enemyType.SetNextType();
    }
}