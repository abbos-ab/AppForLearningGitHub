Calculator calculator = new Calculator();
var response = calculator.Add(5, 10, 7);
Console.WriteLine(response);

class Calculator
{
    public int Add(int a, int b, int c) => a + b + c;
    public int Subtract(int a, int b) => a - b;

    public int Multiply(int a, int b) => a * b;

    public int Divide(int a, int b)
    {
        return a / b;
    }
}


