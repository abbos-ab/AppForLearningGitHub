Calculator calculator = new Calculator();
var response = calculator.Add(5, 10);
Console.WriteLine(response);

class Calculator
{
    public int Add(int a, int b) => a + b;
}
