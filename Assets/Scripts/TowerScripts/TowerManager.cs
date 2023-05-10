using System.Collections.Generic;
using UnityEngine;

public class TowerManager : Singleton<TowerManager> 
{
    [SerializeField] private ScriptableTowerObject[] scriptableTowerArray;
    [SerializeField] private ScriptableTowerObject dummyTowerData;

    #region Each Tower Properties Get By Type
    public Sprite GetIconByType(TowerTypes type)
    {
        foreach (ScriptableTowerObject scriptableTower in scriptableTowerArray)
        {
            if(scriptableTower.type == type)
                return scriptableTower.icon;
        }

        return dummyTowerData.icon;
    }

    public Vector2 GetSizeByType(TowerTypes type)
    {
        foreach (ScriptableTowerObject scriptableTower in scriptableTowerArray)
        {
            if(scriptableTower.type == type)
                return scriptableTower.gridSize;
        }

        return Vector2.one;
    }

    public GameObject GetPrefabByType(TowerTypes type)
    {
        foreach (ScriptableTowerObject scriptableTower in scriptableTowerArray)
        {
            if(scriptableTower.type == type)
                return scriptableTower.prefab;
        }

        return dummyTowerData.prefab;
    }

    public int GetCostByType(TowerTypes type)
    {
        foreach (ScriptableTowerObject scriptableTower in scriptableTowerArray)
        {
            if(scriptableTower.type == type)
                return scriptableTower.cost;
        }

        return 0;
    }
    #endregion
    
    #region  Each Tower Part Get Lists
    public List<Sprite> GetTowerIconList()
    {
        List<Sprite> iconList = new List<Sprite>();

        foreach (ScriptableTowerObject scriptableTower in scriptableTowerArray)
        {
            iconList.Add(scriptableTower.icon);
        }

        return iconList;
    }

    public List<TowerTypes> GetTowerTypeList()
    {
        List<TowerTypes> typeList = new List<TowerTypes>();

        foreach(ScriptableTowerObject scriptableTower in scriptableTowerArray)
        {
            typeList.Add(scriptableTower.type);
        }

        return typeList;
    }
    #endregion
}