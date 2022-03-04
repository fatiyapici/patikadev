class struct_concept
{
    public static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        rectangle.ShortEdge = 3;
        rectangle.LongEdge = 4;
        Console.WriteLine("'Class' area calculate: {0}", rectangle.calcArea());

        RectangleStruct rectangleStruct = new RectangleStruct();
        rectangleStruct.ShortEdge = 4;
        rectangleStruct.LongEdge = 5;
        Console.WriteLine("'Struct' area calculate: {0}", rectangleStruct.calcArea());
    }
}

class Rectangle
{
    public int ShortEdge;
    public int LongEdge;

    public long calcArea()
    {
        return ShortEdge * LongEdge;
    }
}

struct RectangleStruct
{
    public int ShortEdge;
    public int LongEdge;

    public long calcArea()
    {
        return ShortEdge * LongEdge;
    }
}