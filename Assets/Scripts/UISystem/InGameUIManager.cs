using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameUIManager : MonoBehaviour
{
    [SerializeField]private Image currentTower;
    [SerializeField]private Image nextTower;
    [SerializeField]private Sprite[] towerSprites;
    [SerializeField]private Text nextWaveTimerText;
    public float nextWaveTime = 30;

    void FixedUpdate()
    {   
        if(!isCountDownEnded())
            nextWaveTimerText.text = nextWaveTimeText();
        else
            GameManager.Instance.spawnEnemies();
    }

    private string nextWaveTimeText()
    {
        nextWaveTime -= Time.deltaTime;
        return Mathf.RoundToInt(nextWaveTime).ToString();
    }

    private bool isCountDownEnded()
    {
        if(nextWaveTime > 0) 
            return false;
        else
            return true;
    }

    public void changeTowerIcons(int currentId, int nextId)
    {
        currentTower.GetComponent<Image>().sprite = GameManager.Instance.currentTower.towerIcon;
        nextTower.GetComponent<Image>().sprite = GameManager.Instance.nextTower.towerIcon;
    }
}
