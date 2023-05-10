using UnityEngine;
using UnityEngine.UI;

public class EnemyTypePresenter : MonoBehaviour
{
    [SerializeField] private EnemyType enemyType;
    [SerializeField] private Image nextEnemyIcon;

    private void Start()
    {
        if(enemyType != null)
        {
            enemyType.TypeChanged += OnTypeChanged;
        }

        UpdateView();
    }

    public void SetTypes()
    {
        enemyType?.SetNextType();
    }

    private void UpdateView()
    {
        if(enemyType == null) return;

        nextEnemyIcon.sprite = EnemyIcon(enemyType.nextType);
    }

    private Sprite EnemyIcon(EnemyTypes type)
    {
        return EnemyManager.Instance.GetIconByType(type);
    }

    private void OnTypeChanged()
    {
        UpdateView();
    }
}