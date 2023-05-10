using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : Singleton<EnemyManager>
{
    [SerializeField] ScriptableEnemyObject[] scriptableEnemyObjectArray;
    [SerializeField] ScriptableEnemyObject dummyScriptableEnemyData;

#region Get Enemy Datas
    public GameObject GetPrefabByType(EnemyTypes type)
    {
        foreach (ScriptableEnemyObject scriptable in scriptableEnemyObjectArray)
        {
            if (scriptable.type == type)
                return scriptable.prefab;
        }

        return dummyScriptableEnemyData.prefab;
    }

    public Sprite GetIconByType(EnemyTypes type)
    {
        foreach (ScriptableEnemyObject scriptable in scriptableEnemyObjectArray)
        {
            if(scriptable.type == type)
                return scriptable.icon;
        }

        return dummyScriptableEnemyData.icon;
    }
#endregion

#region Get Enemy Lists
    public List<EnemyTypes> GetEnemyTypeList()
    {
        List<EnemyTypes> typeList = new List<EnemyTypes>();

        for (int i = 0; i < scriptableEnemyObjectArray.Length; i++)
            typeList.Add(scriptableEnemyObjectArray[i].type);

        return typeList;
    }
#endregion

}
