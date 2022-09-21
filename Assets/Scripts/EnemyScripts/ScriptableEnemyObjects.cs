using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "ScriptableObjects/EnemyObject", order = 1)]
public class ScriptableEnemyObjects : ScriptableObject
{
    public int agility = 0;
    public int strength = 0;
    public int intelligence = 0;
    public GameObject enemy;
}
