

class Circle : Drawing
{
    private int r;

    public Circle(int x, int y, int r)
    {
        this.x = x;
        this.y = y;
        this.r = r;
    }

    public override double Area()
    {
        return this.r * this.r * Math.PI;
    }

    public override string ToString()
    {
        return $"Circle at x: {x}, y: {x}, radius: {r}";
    }
}