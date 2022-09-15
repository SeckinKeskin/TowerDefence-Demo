using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TowerData", menuName = "ScriptableObjects/ScriptableTowerObjects", order = 1)]
public class ScriptableTowerObjects : ScriptableObject
{
    public int agility = 0;
    public int strength = 0;
    public int intelligence = 0;
    public float attackRange = 0.0f;
    public GameObject tower;
    public Sprite towerIcon;
}
