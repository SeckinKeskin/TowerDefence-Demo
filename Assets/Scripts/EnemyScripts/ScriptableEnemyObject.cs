using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Create Scriptable Data/New Enemy", order = 2)]
public class ScriptableEnemyObject : ScriptableObject
{
    public EnemyTypes type;
    public Sprite icon;
    public GameObject prefab;
}
