using UnityEngine;

public class StrengthTower : Tower
{
    public override void Initialize()
    {
        transform.name = "Strength Tower";

        Debug.Log(transform.name);
    }
}