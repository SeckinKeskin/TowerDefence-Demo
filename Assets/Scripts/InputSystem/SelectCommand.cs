using UnityEngine;

public class SelectCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("Selected game object name is " + GetSelectedGameObjectName());
    }

    public string GetSelectedGameObjectName()
    {
        return GetRaycastHitCollider()?.name;
    }

    public GameObject GetSelectedGameObject()
    {
        return GetRaycastHitCollider()?.gameObject;
    }

    private Collider2D GetRaycastHitCollider()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D raycastHit2D = Physics2D.GetRayIntersection(ray);

        return raycastHit2D.collider;
    }
}