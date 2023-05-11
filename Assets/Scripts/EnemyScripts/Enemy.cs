using UnityEngine;

public class Enemy : MonoBehaviour, IProducible
{   
    public void Initialize()
    {
        Transform destPoint = GameObject.Find("EnemyDestination-Point").transform;
        GetComponent<EnemyBehaviour>().destionationPoint = destPoint;
    }
}
