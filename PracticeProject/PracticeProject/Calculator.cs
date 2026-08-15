namespace PracticeProject;

public class Calculator
{
    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new ArithmeticException("Division by zero is not allowed.");
        }

        return a / b;
    }
}