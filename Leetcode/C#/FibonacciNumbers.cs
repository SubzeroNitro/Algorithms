static Dictionary<int, int> fibonacciNumbers = new Dictionary<int, int>
{ 
    { 0, 0 },
    { 1, 1 }
};

public int Fib(int n)
{
    if (fibonacciNumbers.ContainsKey(n))
    {
        return fibonacciNumbers[n];
    }    

    int count = fibonacciNumbers.Count;
    int sum = fibonacciNumbers[count - 2];

    for (int i = count; i <= n; i++)
    {
        sum += fibonacciNumbers[count - 1];
        fibonacciNumbers.Add(i, sum);
    }

    return sum;
}