double Factorial (int n)
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}

Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6
Console.WriteLine(Factorial(5));

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}