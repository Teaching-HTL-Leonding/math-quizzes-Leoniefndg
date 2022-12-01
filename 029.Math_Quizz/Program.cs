System.Console.WriteLine("Please enter your first number ");
int number1 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(" ");

System.Console.WriteLine("Please enter your second number ");
int number2 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(" ");

System.Console.WriteLine("Please enter your result number ");
double resultNumber = double.Parse(Console.ReadLine()!);
System.Console.WriteLine(" ");

if ((number1 + number2) == resultNumber)
{
    System.Console.WriteLine("The operator was plus");
}
else if ((number1 - number2) == resultNumber)
{
    System.Console.WriteLine("The operator was minus");
}
else if (Math.Round((double)number1 / number2,2) == resultNumber ||Math.Round ((double)number2 / number1,2) == resultNumber)
{
   
    System.Console.WriteLine("The operator was divide ");
}

else if ((number1*number2)==resultNumber)
{
    System.Console.WriteLine("Your operator was multiply ");
}

else if ((number1%number2)==resultNumber||(number2%number1)==resultNumber)
{
    System.Console.WriteLine("The operator was modulo");
}
else if (Math.Pow(number1, number2)== resultNumber || Math.Pow(number2,number1)==resultNumber)
{
    System.Console.WriteLine("Your operator was an exponentiation");
}