using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerHandler : MonoBehaviour
{
    [SerializeField]public ScriptableTowerObjects[] towerObjects;
    private ScriptableTowerObjects scriptableTowerObject;
    private Tower tower;
    [HideInInspector]public Vector2 buildPosition;

    public void towerManufacturer(int id)
    {
        GameObject towerObject = Instantiate(towerObjects[id].tower, buildPosition, Quaternion.identity);
        tower = GetComponent<Tower>();
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
