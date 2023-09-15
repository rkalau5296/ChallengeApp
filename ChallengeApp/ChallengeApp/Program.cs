using ChallengeApp;

List<Employee> employees = new()
{
    new Employee("Paweł", "Kowalski", 22),
    new Employee("Andrzej", "Kwiatkowski", 32),
    new Employee("Piotr", "Nowak", 35),    
};

employees[0].AddScore(5);
employees[0].AddScore(8);
employees[0].AddScore(3);
employees[0].AddScore(8);
employees[0].AddScore(1);

employees[1].AddScore(9);
employees[1].AddScore(7);
employees[1].AddScore(3);
employees[1].AddScore(8);
employees[1].AddScore(1);

employees[2].AddScore(1);
employees[2].AddScore(1);
employees[2].AddScore(3);
employees[2].AddScore(8);
employees[2].AddScore(1);

int maxResult = 0;
Employee? theBestEmployeeResult = null;
bool isMoreThanOne = false;

foreach (Employee employee in employees)
{    
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        theBestEmployeeResult = employee;        
    }
    else if (employee.Result == maxResult)
    {
        isMoreThanOne = true;
    }
}

if (isMoreThanOne)
{
    Console.WriteLine("Jest więcej niż jeden pracowników z największym wynikiem");
}
else
    Console.WriteLine("Najlepszy wynik posiada pracownik: " + theBestEmployeeResult?.Name + " " + theBestEmployeeResult?.Lastname + " " + maxResult);