﻿using ChallengeApp;

Console.WriteLine("Witam w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new EmployeeInFile("Raf", "Kal");




//while (true)
//{
//    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
//    var input = Console.ReadLine();
//    if(input == "q")
//    {
//        break;
//    }
//    try
//    {
//        employee.AddGrade(input);
//    }catch (Exception ex)
//    {
//        Console.WriteLine($"Exception Catched: {ex.Message}");
//    }
//}
//employee.AddGrade(0.6f);
Statistics statistics = employee.GetStatistics();

Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average}");
