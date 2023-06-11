// Napisz w Program.cs kod, w którym:
// - zadeklarujesz zmienną z imieniem
// - zadeklarujesz zmienną z płcią (dobierz zmienną)
// - zadeklarujesz zmienną z wiekiem 
// - zweryfikujesz dane i wyświetlisz jeden z komunikatów 
// (1): "Kobieta poniżej 30 lat"
// (2): "Ewa, lat 33"
// (3): "Niepełnoletni Mężczyzna"
// ------------------
// (możesz dodać swoje)

var name = "Ewa";
var sex = "Kobieta";
var age = 33;

if(sex == "Kobieta")
{
    if(age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if(age == 30)
    {
        Console.WriteLine("Kobieta w wieku 30 lat");
    }
    else if(age == 33)
    {
        if(name == "Ewa")
        {
            Console.WriteLine("Ewa, lat 33");
        }
    }
}
else if(sex == "Mężczyzna")
{
    if(age < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    }
    else if(name == "Jan" && age == 15)
    {
        Console.WriteLine("Jan, lat 15");
    }
    else
    {
        Console.WriteLine("Pełnoletni Mężczyzna");
    }
}