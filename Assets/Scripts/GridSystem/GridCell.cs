public class GridCell 
{
    private float _x = 0.0f;
    private float _y = 0.0f;
    private string _name;
    private bool _usable = true;

    public float x
    {
        get => _x;
        set => _x = value;
    }

    public float y
    {
        get => _y;
        set => _y = value;
    }

    public string name
    {
        get => _name;
        set => _name = value;
    }

    public bool usable
    {
        get => _usable;
        set => _usable = value;
    }
}