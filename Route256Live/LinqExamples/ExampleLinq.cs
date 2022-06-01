using BenchmarkDotNet.Attributes;

namespace Route256Live.LinqExamples
{
    class User
    {
        public int Age;
    }
    
    [MemoryDiagnoser()]
    public class ExampleLinq
    {
        private List<User> _users = new List<User>();

        [GlobalSetup]
        public void GlobalSetup()
        {
            for (int i = 0; i < 20; i++)
            {
                _users.Add(new User());
            }
        }

        [Benchmark]
        public int ForeachExample()
        {
            var sum = 0;

            foreach (User user in _users)
            {
                sum += user.Age;
            }

            return sum / _users.Count;
        }
        
        [Benchmark]
        public int ForExample()
        {
            var sum = 0;

            for (int i = 0; i < _users.Count; i++)
            {
                sum += _users[i].Age;
            }

            return sum / _users.Count;
        }
        
        [Benchmark]
        public int LinqExample()
        {
            var sum = _users.Select(static u => u.Age).Sum();

            return sum / _users.Count;
        }
    }
}

