using UnityEngine;

public class SelectController
{
    public string GetSelectedObjectName()
    {
        return GetRaycastHitCollider()?.name;
    }

    public GameObject GetSelectedGameObject()
    {
        return GetRaycastHitCollider()?.gameObject;
    }

    public Collider2D GetRaycastHitCollider()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D raycastHit2D = Physics2D.GetRayIntersection(ray);

        return raycastHit2D.collider;
    }
}