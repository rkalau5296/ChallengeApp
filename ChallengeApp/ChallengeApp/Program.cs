using ChallengeApp;

Console.WriteLine("Witam w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new EmployeeInMemory("Raf", "Kal");
employee.GradeAdded += EmployeeGradeAdded;
employee.GradeAdded += EmployeeGradeAdded;
employee.GradeAdded -= EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę.");
}


employee.AddGrade(0.6f);
//Statistics statistics = employee.GetStatistics();

//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");
//Console.WriteLine($"Average: {statistics.Average}");
