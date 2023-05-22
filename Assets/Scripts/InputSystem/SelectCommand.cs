using UnityEngine;

public class SelectCommand : ICommand
{
    private GameObject selectedGameObject;
    private ICommand buildCommand;

    public void Execute()
    {
        selectedGameObject = GetSelectedGameObject();
        Debug.Log("Selected game object name is " + GetSelectedGameObjectName());
    }

    private string GetSelectedGameObjectName()
    {
        return GetRaycastHitCollider()?.name;
    }

    private GameObject GetSelectedGameObject()
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