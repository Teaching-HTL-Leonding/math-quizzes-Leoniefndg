    System.Console.WriteLine("Please enter the maximal number ");
    int c = int.Parse(Console.ReadLine()!);

    System.Console.WriteLine("please enter your first number ");
    int a =int.Parse(Console.ReadLine()!);

    System.Console.WriteLine("Please enter your secund number");
    int b = int.Parse(Console.ReadLine()!);


for (int n =1; n <= c; n++)
{

    if (n % a == 0 && n % b ==0)
    {
        System.Console.WriteLine(" FizzBuzz");
    }
    else if (n % a ==0)
    {
        System.Console.WriteLine(" Fizz");
    }
    else if (n % b ==0)
    {
        System.Console.WriteLine(" Buzz");
    }
    else 
    {
        System.Console.WriteLine(n);
    }
}