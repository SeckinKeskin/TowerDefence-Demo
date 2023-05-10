using UnityEngine;

[CreateAssetMenu(fileName = "TowerData", menuName = "Create Scriptable Data/New Tower", order = 1)]
public class ScriptableTowerObject : ScriptableObject
{
    public TowerTypes type;
    public GameObject prefab;
    public Sprite icon;
    public Vector2 gridSize = new Vector2(1f, 1f);
    public int cost = 0;
}
