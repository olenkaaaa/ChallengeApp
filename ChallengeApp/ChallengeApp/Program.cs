Console.WriteLine("Podaj dwie liczby, a następnie wybierz, co chcesz z nimi zrobić.");
Console.Write("Pierwsza liczba -> ");
var firstNumberAsString = Console.ReadLine();
var firstNumber = int.Parse(firstNumberAsString);
Console.Write("Druga liczba -> ");
var secondNumberAsString = Console.ReadLine();
var secondNumber = int.Parse(secondNumberAsString);
Console.WriteLine("Jeśli chcesz wykonać dodawanie, wpisz '+', odejmowanie '-', mnożenie '*', dzielenie '/'");
Console.Write("Tutaj wpisz działanie -> ");
var operation = Console.ReadLine();

if (operation == "+")
{
    Console.WriteLine(firstNumberAsString + " + " + secondNumberAsString + " = " + (firstNumber + secondNumber));
}
else if (operation == "-")
{
    Console.WriteLine(firstNumberAsString + " - " + secondNumberAsString + " = " + (firstNumber - secondNumber));
}
else if (operation == "*")
{
    Console.WriteLine(firstNumberAsString + " * " + secondNumberAsString + " = " + (firstNumber * secondNumber));
}
else if (operation == "/")
{
    Console.WriteLine(firstNumberAsString + " / " + secondNumberAsString + " = " + (firstNumber / secondNumber));
}
