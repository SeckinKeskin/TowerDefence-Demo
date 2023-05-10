using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerTypePresenter : MonoBehaviour
{
    [SerializeField] private TowerType towerType;
    [SerializeField] private Image currentTowerIcon;
    [SerializeField] private Image nextTowerIcon;

    private void Start()
    {
        if(towerType != null)
        {
            towerType.TypeChanged += OnTypeChanged;
        }

        UpdateView();
    }

    public void SetTypes()
    {
        towerType?.SetTypes();
    }

    private void UpdateView()
    {
        if (towerType == null) return;

        currentTowerIcon.sprite = TowerIcon(towerType.currentType);
        nextTowerIcon.sprite = TowerIcon(towerType.nextType);
    }

    private Sprite TowerIcon(TowerTypes type)
    {
        return TowerManager.Instance.GetIconByType(type);
    }

    private void OnTypeChanged()
    {
        UpdateView();
    }
}
