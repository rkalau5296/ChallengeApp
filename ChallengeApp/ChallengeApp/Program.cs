using ChallengeApp;

Console.WriteLine("Witam w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new Employee("Raf", "Kal");

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    string? input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception)
    {
        Console.WriteLine("Exception catched");
    }

    
}

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");