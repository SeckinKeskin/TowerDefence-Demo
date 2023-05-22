using UnityEngine;

public class Enemy : MonoBehaviour, IProducible
{   
    public void Initialize()
    {
        Transform destPoint = GameObject.Find("EnemyDestination-Point").transform;
        GetComponent<EnemyBehaviour>().destionationPoint = destPoint;
    }

    public void SetPosition()
    {

    }
    
    private void OnMouseDown()
    {
        Debug.Log("Enemy Base Selected!");
    }
}

public interface IDamageable
{
    public void TakeDamage(float damage);
}