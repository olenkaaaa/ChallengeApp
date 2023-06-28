﻿using ChallengeApp;

var employee = new Employee("Anna", "Nowak");
employee.AddGrade(9);
employee.AddGrade(1);
employee.AddGrade(2);
var statistics = employee.GetStatistics();
//var statistics1 = employee.GetStatisticsWithForEach();
//var statistics2 = employee.GetStatisticsWithFor();
//var statistics3 = employee.GetStatisticsWithDoWhile();
//var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");