bool isprime(int n)
{
    for(int i = 2; i < n; i++)
    {
        if(n%i==0)return false;
    }
    return true;
}

Console.WriteLine("Enter a Number:");
int num = Convert.ToInt32(Console.ReadLine());
if (isprime(num))
{
    Console.WriteLine(num + " is prime number");
}
else
{
    Console.WriteLine(num + " is not Prime Number");
}