﻿namespace Route256Live.LargeClasses;

public readonly struct Salary
{
    public int CurrentSalary { get; init; }
    public int FirstSalary { get; init; }
    public int MinSalary { get; init; }
    public int MaxSalary { get; init; }
    public int AvgSalary { get; init; }
    public int MedianSalary { get; init; }
}