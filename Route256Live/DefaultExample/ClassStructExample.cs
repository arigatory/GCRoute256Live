using BenchmarkDotNet.Attributes;

namespace Route256Live.DefaultExample
{
    struct MyStruct
    {
        public int Value;
    }

    class MyClass
    {
        public int Value;
    }
    
    internal class ClassStructExample
    {
        [Benchmark]
        [Arguments(10)]
        public void CalcStruct(int val)
        {
            var array = new MyStruct[val];

            for (int i = 0; i < array.Length; i++)
            {
                var st = new MyStruct();
                PrivateCalcStruct(ref st);
                array[i] = st;
            }
        }
        
        [Benchmark]
        [Arguments(10)]
        public void CalcClass(int val)
        {
            var array = new MyClass[val];

            for (int i = 0; i < array.Length; i++)
            {
                var st = new MyClass();
                PrivateCalcClass(st);
                array[i] = st;
            }
        }

        private void PrivateCalcClass(MyClass st)
        {
            st.Value = 5;
        }

        private void PrivateCalcStruct(ref MyStruct st)
        {
            st.Value = 5;
        }
    }    
}

