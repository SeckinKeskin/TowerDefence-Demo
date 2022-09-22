using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [HideInInspector]public GridCell selectedGridCell;
    [HideInInspector]public int currentTowerId = 0;
    [HideInInspector]public int nextTowerId = 0;
    [HideInInspector]public ScriptableTowerObjects currentTower;
    [HideInInspector]public ScriptableTowerObjects nextTower;
    [HideInInspector]public ScriptableEnemyObjects nextWave;
    [SerializeField]public GridSystem[] gridSystem;
    [SerializeField]public TowerHandler towerHandler;
    [SerializeField]private EnemyHandler enemyHandler;
    [SerializeField]private InGameUIManager uiManager;
    [SerializeField]private int nextWaveTime = 10;

    public void Start()
    {
        setTowerIds();
    }

    public void constractTower()
    {
        selectedGridCell.usable = false;

        towerHandler.buildPosition = new Vector2(selectedGridCell.x, selectedGridCell.y);
        towerHandler.towerManufacturer(currentTowerId);
        
        setTowerIds();
    }
    
    public void spawnEnemies()
    {
        uiManager.nextWaveTime = nextWaveTime;
        enemyHandler.enemyManufacturer(0);
    }

    private void setTowerIds()
    {
        currentTowerId = towerHandler.getCurrentTowerId();
        nextTowerId = towerHandler.getNextTowerId();
        
        setTowers();
        setEnemy();
        setUiIcons();
    }

    private void setUiIcons()
    {
        uiManager.changeTowerIcons(currentTowerId, nextTowerId);
    }

    private void setTowers()
    {
        currentTower = towerHandler.towerObjects[currentTowerId];
        nextTower = towerHandler.towerObjects[nextTowerId];
    }

    private void setEnemy()
    {
        nextWave = enemyHandler.enemyObjects[0];
    }
}