﻿int number = 7867;
string numberAsString = number.ToString();
char[] signs = numberAsString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char sign in signs)
{
    if (sign == '0')
    {
        counter0++;
    }
    else if (sign == '1')
    {
        counter1++;
    }
    else if (sign == '2')
    {
        counter2++;
    }
    else if (sign == '3')
    {
        counter3++;
    }
    else if (sign == '4')
    {
        counter4++;
    }
    else if (sign == '5')
    {
        counter5++;
    }
    else if (sign == '6')
    {
        counter6++;
    }
    else if (sign == '7')
    {
        counter7++;
    }
    else if (sign == '8')
    {
        counter8++;
    }
    else if (sign == '9')
    {
        counter9++;
    }
}

Console.WriteLine("Wyniki dla liczby " + number);
Console.WriteLine("0 => " + counter0);
Console.WriteLine("1 => " + counter1);
Console.WriteLine("2 => " + counter2);
Console.WriteLine("3 => " + counter3);
Console.WriteLine("4 => " + counter4);
Console.WriteLine("5 => " + counter5);
Console.WriteLine("6 => " + counter6);
Console.WriteLine("7 => " + counter7);
Console.WriteLine("8 => " + counter8);
Console.WriteLine("9 => " + counter9);