using System;
using System.Collections.Generic;
using UnityEngine;

public class TowerType : MonoBehaviour
{
    public event Action TypeChanged;
    public TowerTypes currentType;
    public TowerTypes nextType;
    private List<TowerTypes> towerTypes;

    private void Start()
    {
        SetNextType();
    }

    public void SetTypes()
    {
        SetCurrentType();
        SetNextType();
    }

    private void UpdateType()
    {
        TypeChanged?.Invoke();
    }

    private void SetCurrentType()
    {
        currentType = nextType;

        UpdateType();
    }

    private void SetNextType()
    {
        towerTypes = TowerManager.Instance.GetTowerTypeList();
        
        int id = UnityEngine.Random.Range(0, towerTypes.Count);
        nextType = towerTypes[id];

        UpdateType();
    }
}
