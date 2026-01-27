// Basic arithmetic operations in C#
//WorkWithIntegers();
//OrderPrecedence();
//WorkWithNumbers();
//WorkWithDoubles();
//WorkWithDecimal();
//radiusChallenge();
// Method to demonstrate basic arithmetic operations with integers
void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);


    // subtraction
    c = a - b;
    Console.WriteLine(c);

    // multiplication
    c = a * b;
    Console.WriteLine(c);

    // division
    c = a / b;
    Console.WriteLine(c);
}

// Method to demonstrate order of operations in arithmetic
void OrderPrecedence()
{
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d);

    d = (a + b) * c;
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);
}

// Method to demonstrate quotient, remainder, range, and overflow with integers
void WorkWithNumbers()
{
    // Demonstrating quotient and remainder
    int a = 7;
    int b = 4;
    int c = 3;
    int d = (a + b) / c;
    int e = (a + b) % c;
    Console.WriteLine($"quotient: {d}");
    Console.WriteLine($"remainder: {e}");

    // Demonstrating the range of the int data type
    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"The range of integers is {min} to {max}");

    // Demonstrating overflow
    int what = max + 3;
    Console.WriteLine($"An example of overflow: {what}");
}

// Method to demonstrate working with doubles
void WorkWithDoubles()
{
    // Basic arithmetic operations with doubles
    double a = 5;
    double b = 4;
    double c = 2;
    double d = (a + b) / c;
    Console.WriteLine(d);


    // Demonstrating the range of the double data type
    double max = double.MaxValue;
    double min = double.MinValue;
    Console.WriteLine($"The range of double is {min} to {max}");

    // Demonstrating precision issues with doubles
    double third = 1.0 / 3.0;
    Console.WriteLine(third);
}

// Method to demonstrate working with decimals
void WorkWithDecimal()
{
    // Demonstrating the range of the decimal data type
    decimal min = decimal.MinValue;
    decimal max = decimal.MaxValue;
    Console.WriteLine($"The range of the decimal type is {min} to {max}");

    // Demonstrating precision with decimal
    double a = 1.0;
    double b = 3.0;
    Console.WriteLine(a / b);

    // Decimal type for higher precision
    decimal c = 1.0M;
    decimal d = 3.0M;
    Console.WriteLine(c / d);
}

// Method to calculate the area of a circle given its radius
void radiusChallenge()
{
    // Area = π r^2
    double radius = 2.50;
    double area = Math.PI * Math.Pow(radius,2);
    Console.WriteLine($"The area of a circle with a radius of {radius} is {area}");
}