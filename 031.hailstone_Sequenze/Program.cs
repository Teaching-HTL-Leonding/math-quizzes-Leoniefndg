Console.WriteLine("Please enter a number what is not negative");
int n = int.Parse(Console.ReadLine()!);//1 länge l

System.Console.WriteLine("Please enter another number what is not negative");
int m = int.Parse(Console.ReadLine()!);//2länge p

int l = 0;
int p = 0;
while (n > 1)
{


    if (n % 2 == 0)
    {
        n = n / 2;
    }
    else if (n % 2 != 0)
    {
        n = (n * 3) + 1;
    }
    l++;

}


while (m>1)
{
    if (m % 2 == 0)
    {
        m = m / 2;
    }
    else if (m % 2 != 0)
    {
        m = (m * 3) + 1;
    }

    p++;
}

if (l > p)
{
    System.Console.WriteLine("Your first number is longer");
}
else if (p > l)
{
    System.Console.WriteLine("Your second number is longer");
}
else 
{
    System.Console.WriteLine("Your lengths are the same ");
}