using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public GameUIManager uiManager;
    public GridSystem[] gridSystem;
    public ScriptableTowerObjects[] towers;
    private GameObject tower;
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
        tower = Instantiate(towers[currentTowerId].tower, towerPosition, Quaternion.identity);
        selectedGridCell.usable = false;
        
        currentTowerId = getCurrentTowerId();
        nextTowerId = getNextTowerId();
        
        uiManager.changeTowerIcons(currentTowerId, nextTowerId);
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