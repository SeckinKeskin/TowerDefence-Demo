using System.Collections.Generic;

public class Grid
{
    private int columnLength = 0;
    private int rowLength = 0;

    public Grid(int _columnLenght, int _rowLenght)
    {
        columnLength = _columnLenght;
        rowLength = _rowLenght;
    }

    public List<Cell> getGridList()
    {
        Cell currentCell = new Cell(0, 0);
        List<Cell> cellList = new List<Cell>();

        for (int row = 0; row < rowLength; row++)
        {
            for (int column = 0; column < columnLength; column++)
            {
                currentCell = new Cell(column, row);
                cellList.Add(currentCell);
            }
        }

        return cellList;
    }
}