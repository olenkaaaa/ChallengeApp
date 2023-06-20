// Twój program powinien generować silne, losowe hasła
// na podstawie określonych przez użytkownika kryteriów,
// takich jak długość hasła i rodzaje znaków, które powinny być użyte
// (na przykład, małe litery, wielkie litery, cyfry, symbole).

Console.WriteLine("Jestem generatorem haseł. Podaj mi kryteria, które ma spełniać Twoje hasło.");
Console.Write("Długość hasła (wpisz cyfrę, określającą liczbę znaków) -> ");
var passwordLengthAsString = Console.ReadLine();
var passwordLength = int.Parse(passwordLengthAsString);
Console.Write("Czy ma zawierać liczby? (Wpisz 'tak' lub 'nie') -> ");
var hasNumbers = Console.ReadLine();
Console.Write("Czy ma zawierać znaki specjalne? (Wpisz 'tak' lub 'nie') -> ");
var hasSpecialChars = Console.ReadLine();
Console.Write("Czy ma zaczynać się z wielkiej litery? (Wpisz 'tak' lub 'nie) -> ");
var startsWithCapitalLetter = Console.ReadLine();

var numbersLettersSpecialChars = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%&*?"; // hasNumbers, hasSpecialChars
var onlyCapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

var numbersLetters = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"; // has Numbers, nie ma hasSpecialChars

List<string> passwordSigns = new List<string>();

//var onlySmallLetters = "abcdefghijklmnopqrstuvwxyz";
//var onlyCapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//var allLetters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
var numbersAndLetters = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

Random random = new Random();

for (var i = 0; i < passwordLength; i++)
{
    if (hasNumbers == "tak")
    {
        if (hasSpecialChars == "tak")
        {
            if (startsWithCapitalLetter == "tak")
            {
                // uzupełnij
            }
            else if (startsWithCapitalLetter == "nie")
            {
                var index = random.Next(0, numbersLettersSpecialChars.Length);
                var firstRandomSign = numbersLettersSpecialChars[index];
                var firstRandomSignAsString = firstRandomSign.ToString();
                passwordSigns.Add(firstRandomSignAsString);
            }
        }
        else if (hasSpecialChars == "nie")
        {
            if (startsWithCapitalLetter == "tak")
            {

            }
            else if (startsWithCapitalLetter == "nie")
            {

            }
        }
    }
    else if (hasNumbers == "nie")
    {
        if (hasSpecialChars == "tak")
        {
            if (startsWithCapitalLetter == "tak")
            {

            }
            else if (startsWithCapitalLetter == "nie")
            {

            }
        }
        else if (hasSpecialChars == "nie")
        {
            if (startsWithCapitalLetter == "tak")
            {

            }
            else if (startsWithCapitalLetter == "nie")
            {

            }
        }
    }
}

var password = string.Concat(passwordSigns);
Console.WriteLine("Twoje hasło: " + password);