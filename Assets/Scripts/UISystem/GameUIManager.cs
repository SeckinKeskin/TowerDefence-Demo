using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUIManager : MonoBehaviour
{
    public Image currentTower;
    public Image nextTower;
    public Sprite[] towerSprites;

    public void changeTowerIcons(int currentId, int nextId)
    {
        currentTower.GetComponent<Image>().sprite = GameManager.Instance.towers[currentId].towerIcon;
        nextTower.GetComponent<Image>().sprite = GameManager.Instance.towers[nextId].towerIcon;;
    }
}
