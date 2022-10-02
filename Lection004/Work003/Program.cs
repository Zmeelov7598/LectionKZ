int Factorial(int n) // лучше через double
{
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}

Console.WriteLine(Factorial(3));
