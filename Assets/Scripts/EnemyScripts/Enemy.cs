using UnityEngine;
using System.Collections.Generic;

public class Enemy : MonoBehaviour, IProducible
{
    public EnemyTypes type = EnemyTypes.Default;
    public void Initialize()
    {
        Transform destPoint = GameObject.Find("EnemyDestination-Point").transform;
        GetComponent<EnemyBehaviour>().destionationPoint = destPoint;
    }

    public void SetPosition()
    {

    }
}

public interface IDamageable
{
    public void TakeDamage(float damage);
}