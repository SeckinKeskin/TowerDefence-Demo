using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField]private EnemyHandler enemyHandler;
    [SerializeField]private InGameUIManager uiManager;
    public GridSystem[] gridSystem;
    public ScriptableTowerObjects[] towers;
    [HideInInspector]public GridCell selectedGridCell;
    public int currentTowerId = 0;
    public int nextTowerId = 0;

    public void Start()
    {
        currentTowerId = getCurrentTowerId();
        nextTowerId = getNextTowerId();

        uiManager.changeTowerIcons(currentTowerId, nextTowerId);
    }

    public void constractTower()
    {
        Vector2 towerPosition = new Vector2(selectedGridCell.x, selectedGridCell.y);
        GameObject tower = Instantiate(towers[currentTowerId].tower, towerPosition, Quaternion.identity);
        selectedGridCell.usable = false;
        
        currentTowerId = getCurrentTowerId();
        nextTowerId = getNextTowerId();
        
        uiManager.changeTowerIcons(currentTowerId, nextTowerId);
    }

    public void spawnEnemies()
    {
        uiManager.nextWaveTime = 45;
        enemyHandler.enemyManufacturer(0);
    }

    public int getCurrentTowerId()
    {
        if(nextTowerId > -1)
            return nextTowerId;
        else
            return Random.Range(0, towers.Length);
    }

    public int getNextTowerId()
    {
        return Random.Range(0, towers.Length);
    }
}