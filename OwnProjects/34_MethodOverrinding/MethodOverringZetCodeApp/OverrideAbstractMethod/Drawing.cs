

abstract class Drawing
{
    protected int x = 0;
    protected int y = 0;

    public abstract double Area();

    public string GetCoordinates()
    {
        return $"x: {x}, y: {y}";
    }
}
