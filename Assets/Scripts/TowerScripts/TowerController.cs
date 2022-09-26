using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour 
{
    [HideInInspector]public Tower tower = new Tower();
    [SerializeField]private string triggeredTag;
    private SphereCollider rangeDetectionCollider;

    void Start()
    {
        tower.attackRangeCalculate();
        tower.attackSpeedCalculate();
        tower.damageCalculate();

        setTriggerRange();
    }

    void setTriggerRange()
    {
        rangeDetectionCollider = GetComponent<SphereCollider>();
        rangeDetectionCollider.radius = tower.attackRange;
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == triggeredTag)
        {
            Debug.Log("Attack!");
        }
    }
}