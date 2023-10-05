static Dictionary<int, int> fibonacciNumbers = new Dictionary<int, int>();

public int Fib(int n)
{
    if (n <= 1)
    {
        return n;
    }

    if (fibonacciNumbers.ContainsKey(n))
    {
        return fibonacciNumbers[n];
    }    

    int number = Fib(n - 1) + Fib(n - 2);
    fibonacciNumbers.Add(n, number);

    return number;
}