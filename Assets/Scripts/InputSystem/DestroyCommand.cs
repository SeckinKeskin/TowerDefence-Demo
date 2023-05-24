using UnityEngine;

public class DestroyCommand : ICommand
{
    private GameObject destroyObject;
    public void Execute()
    {
        Debug.Log("Destroy Object");

        destroyObject = GetSelectedTower();
        DestroyObject();
    }

    private GameObject GetSelectedTower()
    {
        SelectCommand selectCommand = new SelectCommand();
        return selectCommand.GetSelectedGameObject();
    }

    private void DestroyObject()
    {
        if(!destroyObject) return;

        if(destroyObject.tag == "Tower")
            destroyObject.SetActive(false);
    }
}