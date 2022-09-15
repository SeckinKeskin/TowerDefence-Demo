using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    [SerializeField] private GridSystem gridSystem;

    private ICommand command;

    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            selectHandler();
        }
    }

    void selectHandler()
    {
        if(getRaycastHitCollider())
        {
            GameObject selectedGameObject = getRaycastHitCollider().gameObject;
            command = new SelectCommand(selectedGameObject);
        }
        else
        {
            command = new DeselectCommand();
        }

        command.execute();
    }

    private Collider2D getRaycastHitCollider()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D raycastHit2D = Physics2D.GetRayIntersection(ray);

        return raycastHit2D.collider;
    }
}
