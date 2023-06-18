// 1. Stwórz klasę Employee, w której przechowasz imię, nazwisko, wiek
// oraz punkty pracownika w postaci liczb całkowitych.
//
// 2. Stwórz 3 pracowników i każdemu przydziel 5 ocen z zakresu
// od 1 do 10.
//
// 3. Napisz program, który wyszuka pracownika z najwyższą liczbą ocen,
// a następnie wyświetli jego dane oraz wynik.
using ChallengeApp;

Employee employee1 = new Employee("Marta", "Kowalska", 30);
Employee employee2 = new Employee("Krzysztof", "Nowak", 27);
Employee employee3 = new Employee("Piotr", "Wiśniewski", 49);

employee1.AddPoints(8);
employee1.AddPoints(6);
employee1.AddPoints(4);
employee1.AddPoints(9);
employee1.AddPoints(5);

employee2.AddPoints(3);
employee2.AddPoints(6);
employee2.AddPoints(5);
employee2.AddPoints(4);
employee2.AddPoints(2);

employee3.AddPoints(7);
employee3.AddPoints(6);
employee3.AddPoints(8);
employee3.AddPoints(1);
employee3.AddPoints(4);

var employee1Points = employee1.Points;
var employee2Points = employee2.Points;
var employee3Points = employee3.Points;

if (employee1Points > employee2Points && employee1Points > employee3Points)
{
    Console.WriteLine("Najwyższy wynik ma " + employee1.Name + " " + employee1.Surname + " " + employee1.Age + " lat" + ": " + employee1.Points);
}
else if (employee2Points > employee1Points && employee2Points > employee3Points)
{
    Console.WriteLine("Najwyższy wynik ma " + employee2.Name + " " + employee2.Surname + " " + employee2.Age + " lat" + ": " + employee2.Points);
}
else if (employee3Points > employee1Points && employee3Points > employee2Points)
{
    Console.WriteLine("Najwyższy wynik ma " + employee3.Name + " " + employee3.Surname + " " + employee3.Age + " lat" + ": " + employee3.Points);
}
else if (employee1Points == employee2Points && employee1Points == employee3Points)
{
    Console.WriteLine("Wszyscy pracownicy (" + employee1.Name + " " + employee1.Surname + " " + employee1.Age + " lat" + ", " + employee2.Name + " " + employee2.Surname + " " + employee2.Age + " lat" + " i " + employee3.Name + " " + employee3.Surname + " " + employee3.Age + " lat" + ") uzyskali ten sam wynik: " + employee1.Points);
}
else if (employee1Points == employee2Points)
{
    Console.WriteLine("Najwyższy wynik uzyskali jednocześnie " + employee1.Name + " " + employee1.Surname + " " + employee1.Age + " lat" + " i " + employee2.Name + " " + employee2.Surname + " " + employee2.Age + " lat" + ": " + employee1.Points);
}
else if (employee1Points == employee3Points)
{
    Console.WriteLine("Najwyższy wynik uzyskali jednocześnie " + employee1.Name + " " + employee1.Surname + " " + employee1.Age + " lat" + " i " + employee3.Name + " " + employee3.Surname + " " + employee3.Age + " lat" + ": " + employee1.Points);
}
else if (employee2Points == employee3Points)
{
    Console.WriteLine("Najwyższy wynik uzyskali jednocześnie " + employee2.Name + " " + employee2.Surname + " " + employee2.Age + " lat" + " i " + employee3.Name + " " + employee3.Surname + " " + employee3.Age + " lat" + ": " + employee2.Points);
}