using ChallengeApp;

Console.WriteLine("Witam w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new EmployeeInFile("Raf", "Kal");
Statistics statistics = employee.GetStatistics();

Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average}");
