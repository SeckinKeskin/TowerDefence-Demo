using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerHandler : MonoBehaviour
{
    [SerializeField]public ScriptableTowerObjects[] towerObjects;
    [HideInInspector]public Vector2 buildPosition;
    private TowerController towerController;

    public void towerManufacturer(int id)
    {
        GameObject towerObject = Instantiate(towerObjects[id].tower, buildPosition, Quaternion.identity);
        towerController = towerObject.GetComponent<TowerController>();

        setTowerAttributes(towerObjects[id]);
    }

    private void setTowerAttributes(ScriptableTowerObjects towerObject)
    {
        towerController.tower.strength = towerObject.strength;
        towerController.tower.agility = towerObject.agility;
        towerController.tower.intelligence = towerObject.intelligence;
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
