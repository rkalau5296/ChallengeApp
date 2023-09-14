using ChallengeApp;

List<Employee> employees = new()
{
    new ()
    {
        Name = "Paweł",
        Surname = "Kowalski",        
        Grades = new List<int>() { 6, 5, 9, 5, 8 }
    },
    new ()
    {
        Name = "Andrzej",
        Surname = "Kwiatkowski",        
        Grades = new List<int>() { 9, 9, 6, 8, 5 }
    },
    new ()
    {
        Name = "Piotr",
        Surname = "Nowak",        
        Grades = new List<int>() { 3, 2, 9, 7, 7 }
    }
};

int maxResult = 0;
Employee? theBestEmployeeResult = null;
bool isMoreThanOne = false;

foreach (Employee employee in employees)
{
    int result = employee.Grades.Sum();
    if (result > maxResult)
    {
        maxResult = result;
        theBestEmployeeResult = employee;        
    }
    else if (result == maxResult)
    {
        isMoreThanOne = true;
    }
}

if (isMoreThanOne)
{
    Console.WriteLine("Jest więcej niż jeden pracowników z największym wynikiem");
}
else
    Console.WriteLine("Najlepszy wynik posiada pracownik: " + theBestEmployeeResult?.Name + " " + theBestEmployeeResult?.Surname + " " + maxResult);