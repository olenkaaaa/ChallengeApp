using ChallengeApp;

var employee1 = new Employee("Marcin", "Twardowski");
employee1.AddGrade(2);
employee1.AddGrade(2);
employee1.AddGrade(6);
var statistics1 = employee1.GetStatistics();
Console.WriteLine($"{employee1.Name} {employee1.Surname}");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine();

var employee2 = new Employee("Anna", "Nowak");
employee2.AddGrade(7);
employee2.AddGrade(4);
employee2.AddGrade(1);
var statistics2 = employee2.GetStatistics();
Console.WriteLine($"{employee2.Name} {employee2.Surname}");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
