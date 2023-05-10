using UnityEngine;

public class Tower : MonoBehaviour, IProducible
{
    protected Sprite icon;
    protected Vector2 size;
    protected GameObject prefab;
    protected int cost;
    protected int level = 0;

    public virtual void Initialize()
    {
        transform.name = "Tower";

        Debug.Log(transform.name);
    }

    public virtual void LevelUp()
    {
        level++;
    }
}
