using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem : MonoBehaviour
{
    [SerializeField]private int gridSizeX = 5;
    [SerializeField]private int gridSizeY = 5;
    [SerializeField]private GameObject originalGridObject;
    [SerializeField]private Transform gridStartPosition;
    [SerializeField]private float gridObjectMargin = .7f;
    [HideInInspector]public List<GridCell> gridCellList = new List<GridCell>();

    void Awake()
    {
        for(int y = 0; y < gridSizeY; y++)
        {
            for(int x = 0; x < gridSizeX; x++)
            {
                GridCell gridCell = new GridCell();
                gridCell.x = getGridObjectPosition(x, y).x;
                gridCell.y = getGridObjectPosition(x, y).y;
                gridCell.name = "Grid-" + x + "x" + y;

                gridCellList.Add(gridCell);

                gridCellHandler(gridCell);
            }
        }
    }

    private void gridCellHandler(GridCell gridCell)
    {
        GameObject gridObject = Instantiate(originalGridObject, gridStartPosition.transform.position, Quaternion.identity);
        gridObject.transform.position = new Vector2(gridCell.x, gridCell.y);
        gridObject.name = gridCell.name;
    }

    private Vector2 getGridObjectPosition(int x, int y)
    {
        return new Vector2(gridStartPosition.position.x + (gridObjectMargin * x), gridStartPosition.position.y + (gridObjectMargin * y));
    }
}
