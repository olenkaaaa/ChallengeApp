// Napisać program realizujący funkcje prostego kalkulatora, pozwalającego na wykonywanie operacji
// dodawania, odejmowania, mnożenia i dzielenia na dwóch liczbach rzeczywistych.
// Program ma identyfikować sytuację wprowadzenia błędnego symbolu działania oraz próbę dzielenia przez zero.
// Scenariusz działania programu:
// a) Program wyświetla informację o swoim przeznaczeniu.
// b) Wczytuje pierwszą liczbę.
// c) Wczytuje symbol operacji arytmetycznej: +, -, *, /.
// d) Wczytuje drugą liczbę.
// e) Wyświetla wynik lub - w razie konieczności - informację o niemożności wykonania działania.
// f) Program kończy swoje działanie po naciśnięciu przez użytkownika klawisza Enter.

Console.WriteLine("Jestem kalkulatorem do podstawowych operacji na liczbach naturalnych od 0 do 10.");
Console.Write("Tutaj wprowadź swoje działanie -> ");
var operation = Console.ReadLine();
char[] elements = operation.ToArray();

var number1 = Convert.ToInt32(elements[0]);
var number2 = Convert.ToInt32(elements[2]);

var counterAddition = 0;
var counterSubtraction = 0;
var counterMultiplication = 0;
var counterDivision = 0;

foreach (char sign in elements)
{
    if (sign == '+')
    {
        counterAddition++;
    }
    else if (sign == '-')
    {
        counterSubtraction++;
    }
    else if (sign == '*')
    {
        counterMultiplication++;
    }
    else if (sign == '/')
    {
        counterDivision++;
    }
}

if (counterAddition == 1)
{
    Console.WriteLine(number1 + number2);
}
else if (counterSubtraction == 1)
{
    Console.WriteLine(number1 - number2);
}
else if (counterMultiplication == 1)
{
    Console.WriteLine(number1 * number2);
}
else if (counterDivision == 1)
{
    Console.WriteLine(number1 / number2);
}
