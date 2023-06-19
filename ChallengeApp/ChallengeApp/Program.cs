Console.WriteLine("Wypisz 20 liter (z alfabetu angielskiego), które chcesz dodać do tablicy.");
Console.Write("Zacznij tutaj (litery rozdzielaj spacją) -> ");
var userInput = Console.ReadLine();

if (userInput.Length > 39)
{
    userInput = userInput.Substring(0, 39);
    Console.WriteLine("Wpisałeś za dużo liter, zostaną wzięte pod uwagę tylko te litery: " + userInput);
}
else if (userInput.Length < 39)
{
    Console.Write("Wpisałeś za mało liter, wpisz jeszcze raz -> ");
    userInput = Console.ReadLine();
}

List<string> letters = userInput.Split(" ").ToList();

var counterA = 0;
var counterB = 0;
var counterC = 0;
var counterD = 0;
var counterE = 0;
var counterF = 0;
var counterG = 0;
var counterH = 0;
var counterI = 0;
var counterJ = 0;
var counterK = 0;
var counterL = 0;
var counterM = 0;
var counterN = 0;
var counterO = 0;
var counterP = 0;
var counterQ = 0;
var counterR = 0;
var counterS = 0;
var counterT = 0;
var counterU = 0;
var counterV = 0;
var counterW = 0;
var counterX = 0;
var counterY = 0;
var counterZ = 0;



foreach (var letter in letters)
{
    if (letter == "a" || letter == "A")
    {
        counterA++;
    }
    else if (letter == "b" || letter == "B")
    {
        counterB++;
    }
    else if (letter == "c" || letter == "C")
    {
        counterC++;
    }
    else if (letter == "d" || letter == "D")
    {
        counterD++;
    }
    else if (letter == "e" || letter == "E")
    {
        counterE++;
    }
    else if (letter == "f" || letter == "F")
    {
        counterF++;
    }
    else if (letter == "g" || letter == "G")
    {
        counterG++;
    }
    else if (letter == "h" || letter == "H")
    {
        counterH++;
    }
    else if (letter == "i" || letter == "I")
    {
        counterI++;
    }
    else if (letter == "j" || letter == "J")
    {
        counterJ++;
    }
    else if (letter == "k" || letter == "K")
    {
        counterK++;
    }
    else if (letter == "l" || letter == "L")
    {
        counterL++;
    }
    else if (letter == "m" || letter == "M")
    {
        counterM++;
    }
    else if (letter == "n" || letter == "N")
    {
        counterN++;
    }
    else if (letter == "o" || letter == "O")
    {
        counterO++;
    }
    else if (letter == "p" || letter == "P")
    {
        counterP++;
    }
    else if (letter == "q" || letter == "Q")
    {
        counterQ++;
    }
    else if (letter == "r" || letter == "R")
    {
        counterR++;
    }
    else if (letter == "s" || letter == "S")
    {
        counterS++;
    }
    else if (letter == "t" || letter == "T")
    {
        counterT++;
    }
    else if (letter == "u" || letter == "U")
    {
        counterU++;
    }
    else if (letter == "v" || letter == "V")
    {
        counterV++;
    }
    else if (letter == "w" || letter == "W")
    {
        counterW++;
    }
    else if (letter == "x" || letter == "X")
    {
        counterX++;
    }
    else if (letter == "y" || letter == "Y")
    {
        counterY++;
    }
    else if (letter == "z" || letter == "Z")
    {
        counterZ++;
    }
}


Console.WriteLine("a:" + counterA);
Console.WriteLine("b:" + counterB);
Console.WriteLine("c:" + counterC);
Console.WriteLine("d:" + counterD);
Console.WriteLine("e:" + counterE);
Console.WriteLine("f:" + counterF);
Console.WriteLine("g:" + counterG);
Console.WriteLine("h:" + counterH);
Console.WriteLine("i:" + counterI);
Console.WriteLine("j:" + counterJ);
Console.WriteLine("k:" + counterK);
Console.WriteLine("l:" + counterL);
Console.WriteLine("m:" + counterM);
Console.WriteLine("o:" + counterO);
Console.WriteLine("p:" + counterP);
Console.WriteLine("q:" + counterQ);
Console.WriteLine("r:" + counterR);
Console.WriteLine("s:" + counterS);
Console.WriteLine("t:" + counterT);
Console.WriteLine("u:" + counterU);
Console.WriteLine("v:" + counterV);
Console.WriteLine("w:" + counterW);
Console.WriteLine("x:" + counterX);
Console.WriteLine("y:" + counterY);
Console.WriteLine("z:" + counterZ);
