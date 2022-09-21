using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHandler : MonoBehaviour
{
    [SerializeField]private ScriptableEnemyObjects[] enemyObjects;
    [SerializeField]private Transform spawnPoint;
    [SerializeField]private Transform destinationPoint;
    private Enemy enemy;

    public void enemyManufacturer(int id)
    {
        GameObject enemyObject = Instantiate(enemyObjects[id].enemy, spawnPoint.position, Quaternion.identity);
        enemy = enemyObject.GetComponent<Enemy>();
        enemy.destionationPoint = destinationPoint;
    }
}
