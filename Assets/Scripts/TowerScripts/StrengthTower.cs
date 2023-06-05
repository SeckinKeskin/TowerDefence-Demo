using UnityEngine;

public class StrengthTower : Tower
{
    public override void Initialize()
    {
        transform.name = "Strength Tower";
        type = TowerTypes.Strength;

        Debug.Log(transform.name);
    }
}