﻿using BenchmarkDotNet.Attributes;

namespace Route256Live.LargeClasses
{

    [MemoryDiagnoser()]
    internal class LargeObjectTest
    {
        [Benchmark]
        public List<SimpleUser> TestInternalClass()
        {
            var result = new List<SimpleUser>();
            for (int i = 0; i < 100; i++)
            {
                var user = new SimpleUser(default, new WorkTime(), new Salary());
                result.Add(user);
            }

            return result;
        }
        
        [Benchmark]
        public List<SimpleUserOld> TestDefaultlClass()
        {
            var result = new List<SimpleUserOld>();
            for (int i = 0; i < 100; i++)
            {
                var user = new SimpleUserOld();
                result.Add(user);
            }

            return result;
        }
    }    
}
