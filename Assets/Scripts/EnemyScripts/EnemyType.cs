using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType : MonoBehaviour
{
    public event Action TypeChanged;
    public EnemyTypes nextType;
    private List<EnemyTypes> enemyTypes;

    private void Start()
    {
        SetNextType();
    }

    public void UpdateType()
    {
        TypeChanged?.Invoke();
    }

    public void SetNextType()
    {
        enemyTypes = EnemyManager.Instance.GetEnemyTypeList();

        int id = UnityEngine.Random.Range(0, enemyTypes.Count);
        nextType = enemyTypes[id];

        UpdateType();
    }
}
