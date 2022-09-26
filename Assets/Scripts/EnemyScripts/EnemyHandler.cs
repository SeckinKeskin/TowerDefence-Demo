using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    [SerializeField]public ScriptableEnemyObjects[] enemyObjects;
    [SerializeField]private Transform spawnPoint;
    [SerializeField]private Transform destinationPoint;
    private EnemyController enemy;

    public void enemyManufacturer(int id)
    {
        GameObject enemyObject = Instantiate(enemyObjects[id].enemy, spawnPoint.position, Quaternion.identity);
        enemy = enemyObject.GetComponent<EnemyController>();
        enemy.destionationPoint = destinationPoint;
    }
}
