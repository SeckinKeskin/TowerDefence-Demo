using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerHandler : MonoBehaviour
{
    [SerializeField]public ScriptableTowerObjects[] towerObjects;
    [HideInInspector]public Vector2 buildPosition;
    private TowerManager towerManager;

    public void towerManufacturer(int id)
    {
        GameObject towerObject = Instantiate(towerObjects[id].tower, buildPosition, Quaternion.identity);
        towerManager = TowerManager.Instance;

        setTowerAttributes(towerObjects[id]);
    }

    private void setTowerAttributes(ScriptableTowerObjects towerObject)
    {
        towerManager.tower.attributes.strength = towerObject.strength;
        towerManager.tower.attributes.agility = towerObject.agility;
        towerManager.tower.attributes.intelligence = towerObject.intelligence;
    }

    public int getCurrentTowerId()
    {
        if(GameManager.Instance.nextTowerId > -1)
            return GameManager.Instance.nextTowerId;
        else
            return Random.Range(0, towerObjects.Length);
    }

    public int getNextTowerId()
    {
        return Random.Range(0, towerObjects.Length);
    }
}
