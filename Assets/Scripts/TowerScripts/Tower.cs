using UnityEngine;

public class Tower : MonoBehaviour, IProducible
{
    protected Sprite icon;
    protected Vector2 size;
    protected GameObject prefab;
    protected int cost;
    protected int level = 0;
    public GridCellBehaviour cellBehaviour;

    public virtual void Initialize()
    {
        transform.name = "Tower";
    }

    public virtual void SetPosition()
    {
        transform.position = cellBehaviour.transform.position;
    }

    public virtual void LevelUp()
    {
        level++;
    }
}
