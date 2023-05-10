using System.Collections.Generic;

public class Grid
{
    private int columnLength = 0;
    private int rowLength = 0;

    public Grid(int columnLenght, int rowLenght)
    {
        this.columnLength = columnLenght;
        this.rowLength = rowLenght;
    }

    public List<Cell> GetGridList()
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