using UnityEngine;

public class Tower : MonoBehaviour, IProducible
{
    protected Sprite icon;
    protected Vector2 size;
    protected GameObject prefab;
    protected int cost;
    protected int level = 0;
    public TowerTypes type = TowerTypes.Default;
    public GridCellBehaviour cellBehaviour;

    public virtual void Initialize()
    {
        transform.name = type + " Tower";
        cellBehaviour.isValid = false;
    }

    public virtual void SetPosition()
    {
        transform.position = GetPosition();
    }

    public virtual void LevelUp()
    {
        level++;
    }

    private Vector3 GetPosition()
    {
        Vector3 cellPosition = cellBehaviour.transform.position;
        return new Vector3(cellPosition.x, cellPosition.y, cellPosition.z - 0.5f);
    }
}
