using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField]public TowerHandler towerHandler;
    [SerializeField]private EnemyHandler enemyHandler;
    [SerializeField]private InGameUIManager uiManager;
    [SerializeField]public GridSystem[] gridSystem;
    [HideInInspector]public GridCell selectedGridCell;
    [HideInInspector]public int currentTowerId = 0;
    [HideInInspector]public int nextTowerId = 0;

    public void Start()
    {
        currentTowerId = towerHandler.getCurrentTowerId();
        nextTowerId = towerHandler.getNextTowerId();

        uiManager.changeTowerIcons(currentTowerId, nextTowerId);
    }

    public void constractTower()
    {
        towerHandler.buildPosition = new Vector2(selectedGridCell.x, selectedGridCell.y);
        towerHandler.towerManufacturer(currentTowerId);
        selectedGridCell.usable = false;
        
        currentTowerId = towerHandler.getCurrentTowerId();
        nextTowerId = towerHandler.getNextTowerId();
        
        uiManager.changeTowerIcons(currentTowerId, nextTowerId);
    }

    public void spawnEnemies()
    {
        uiManager.nextWaveTime = 45;
        enemyHandler.enemyManufacturer(0);
    }
}