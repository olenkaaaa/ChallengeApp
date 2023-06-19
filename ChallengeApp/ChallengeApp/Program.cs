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

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Points > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Points;
    }
}

Console.WriteLine("Najwyższy wynik uzyskał " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " " + employeeWithMaxResult.Age + " lat: " + employeeWithMaxResult.Points);

