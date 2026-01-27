// Exploring Tuples in C#
TuplesDemo();

void TuplesDemo()
{
    // Creating and using tuples
    var pt = (X: 1, Y: 2);
    var slope = (double)pt.Y / (double)pt.X;
    Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.");

    // Modifying tuple elements
    pt.X = pt.X + 5;
    Console.WriteLine($"The point is now at {pt}.");

    // Creating a new tuple based on an existing one
    var pt2 = pt with { Y = 10 };
    Console.WriteLine($"The point 'pt2' is at {pt2}.");

    var subscript = (A: 0, B: 0);
    subscript = pt;
    Console.WriteLine(subscript);

    // Different ways to declare tuples
    var namedData = (Name: "Morning observation", Temp: 17, Wind: 4);
    var person = (FirstName: "", LastName: "");
    var order = (Product: "guitar picks", style: "triangle", quantity: 500, UnitPrice: 0.10m);
}

// Demonstrating record types with positional parameters
Point pt3 = new Point(1, 1);
var pt4 = pt3 with { Y = 10 };
Console.WriteLine($"The two points are {pt3} and {pt4}");

// Calculating slope using a method in the record type
double slopeResult = pt4.Slope();
Console.WriteLine($"The slope of {pt4} is {slopeResult}");

// Defining a record type for Point
public record struct Point(int X, int Y)
{   
    public double Slope() => (double)Y / (double)X;
}