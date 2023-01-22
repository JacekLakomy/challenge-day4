var name = "Ewa";
char sex = 'F';
var age = 25;

if (sex == 'F')
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
}
else if (age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}