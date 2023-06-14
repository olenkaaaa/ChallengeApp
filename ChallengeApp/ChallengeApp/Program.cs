Console.Write("Podaj swoją wagę -> ");
var weightString = Console.ReadLine();
var weight = int.Parse(weightString);
Console.Write("Podaj swój wzrost -> ");
var heightStringCm = Console.ReadLine();
var heightCm = int.Parse(heightStringCm);
var heightM = heightCm / 100.0;

var BMI = weight / Math.Pow(heightM, 2);

Console.WriteLine("Twoje BMI wynosi " + BMI);

if (18.5 <= BMI && BMI <= 24.9)
{
    Console.WriteLine("Twoja waga jest prawidłowa");
}
else if (BMI < 18.5)
{
    Console.WriteLine("Masz niedowagę");
}
else
{
    Console.WriteLine("Masz nadwagę");
}