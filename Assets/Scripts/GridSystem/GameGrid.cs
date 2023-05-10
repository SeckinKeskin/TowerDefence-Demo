using System.Collections.Generic;
using UnityEngine;

public class GameGrid : MonoBehaviour
{
    [SerializeField] private GameObject gridObject;
    [SerializeField] private Transform gridParent;
    [SerializeField] private Transform gridStartPosition;
    [SerializeField] private int columnLenght = 5;
    [SerializeField] private int rowLenght = 5;
    
    private Grid grid;
    private List<Cell> gridCellList;
    private List<GameObject> gridObjectList;
    private GridCellBehaviour currentCellBehaviour;
    private Cell currentCell;

    private void Start()
    {
        grid = new Grid(columnLenght, rowLenght);
        gridCellList = grid.GetGridList();

        InstantiateGridObjects();
    }

    private void InstantiateGridObjects()
    {
        gridObjectList = new List<GameObject>();

        foreach (Cell cell in gridCellList)
        {
            GameObject intantiateGridObject = Instantiate(gridObject, gridStartPosition.localPosition, Quaternion.identity);
            currentCellBehaviour = intantiateGridObject.GetComponent<GridCellBehaviour>();
            currentCell = cell;

            InitializeCell();

            gridObjectList.Add(intantiateGridObject);
        }
    }

    private void InitializeCell()
    {
        currentCellBehaviour.cell = currentCell;
        currentCellBehaviour.parent = gridParent;

        currentCellBehaviour.Initialize();
    }
}