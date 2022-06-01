using System;

namespace Route256Live.LargeClasses
{
    public sealed class SimpleUser
    {
        public SimpleUser(int id, WorkTime workTime, Salary salaryInfo)
        {
            Id = id;
            WorkTime = workTime;
            SalaryInfo = salaryInfo;
        }

        public int Id{ get; init; }

        public WorkTime WorkTime { get; init; }
        
        public Salary SalaryInfo { get; init; }

    }
}