using UnityEngine;

public class SelectCommand : ICommand
{
    private GameObject selectedGameObject;
    private GridCellBehaviour cellBehaviour;
    private TowerFactory towerFactory;
    
    public SelectCommand(GameObject gameObject)
    {
        selectedGameObject = gameObject;
        cellBehaviour = selectedGameObject.GetComponent<GridCellBehaviour>();
    }

    public void Execute()
    {
        towerFactory = GameObject.FindObjectOfType<TowerFactory>();

        if(cellBehaviour.isAvailable)
        {
            GameManager.Instance.Generator(towerFactory, selectedGameObject.transform.position);
            GameManager.Instance.SetTowerType();
            
            cellBehaviour.isAvailable = false;
        }
    }
}
