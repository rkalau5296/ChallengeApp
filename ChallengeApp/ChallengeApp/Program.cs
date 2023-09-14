string name = "Ewa";
string gender = "K";
int age = 33;

if (gender == "K" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (gender == "M" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else
{
    Console.WriteLine("" + name + ", lat " + age + "");
}

