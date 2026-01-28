// Basic conditional statements and loops in C#
ComplexIfElseDemo();
whileExample();
forExample();
sumDivisibleByThree();

// Complex if-else statement demonstration
void ComplexIfElseDemo()
{
    int a = 5;
    int b = 3;
    int c = 4;
    if ((a + b + c > 10) && (a == b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("And the first number is equal to the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("Or the first number is not equal to the second");
    }
}
// While loop example
void whileExample()
{
int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
}
}

// For loop example
void forExample()
{
    for (int row = 1; row < 11; row++)
    {
        for (char column = 'a'; column < 'k'; column++)
        {
            Console.WriteLine($"The cell is ({row}, {column})");
        }
    }
}

// Challenge Problem: Find sum of all numbers between 1 and 20 that are divisible by 3
void sumDivisibleByThree()
{
    int sum = 0;
    for (int i = 1; i <= 20; i++)
    {
        if (i % 3 == 0)
        {
            sum += i;
        }
    }
    Console.WriteLine($"The sum of all numbers between 1 and 20 that are divisible by 3 is {sum}");
}