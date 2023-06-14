Console.WriteLine("Podaj trzy liczby całkowite");

Console.Write("Pierwsza liczba -> ");
string num1 = Console.ReadLine();
var number1 = int.Parse(num1);
Console.Write("Druga liczba -> ");
string num2 = Console.ReadLine();
var number2 = int.Parse(num2);
Console.Write("Trzecia liczba -> ");
string num3 = Console.ReadLine();
var number3 = int.Parse(num3);

if (number1 > number2 && number1 > number3)
{
    Console.WriteLine("Liczba " + number1 + " jest największa");
    
    if (number2 < number3 )
    {
        Console.WriteLine("Liczba " + number2 + " jest najmniejsza");
    }
    else if (number3 < number2)
    {
        Console.WriteLine("Liczba " + number3 + " jest najmniejsza");
    }
}
else if (number2 > number1 && number2 > number3)
{
    Console.WriteLine("Liczba " + number2 + " jest największa");

    if (number1 < number3)
    {
        Console.WriteLine("Liczba " + number1 + " jest najmniejsza");
    }
    else if (number3 < number1)
    {
        Console.WriteLine("Liczba " + number3 + " jest najmniejsza");
    }
}
else if (number3 > number1 && number3 > number2)
{
    Console.WriteLine("Liczba " + number3 + " jest największa");

    if (number2 < number1)
    {
        Console.WriteLine("Liczba " + number2 + " jest najmniejsza");
    }
    else if (number1 < number2)
    {
        Console.WriteLine("Liczba " + number1 + " jest najmniejsza");
    }
}
