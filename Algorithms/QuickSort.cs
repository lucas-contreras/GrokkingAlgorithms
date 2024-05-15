using BenchmarkDotNet.Attributes;
using System.Collections;

namespace Algorithms
{
    [MemoryDiagnoser]
    public class QuickSort
    {
        [Benchmark]
        public static List<int> Exec<T>(List<int> array) where T : struct
        {
            if (array.Count < 2)
            {
                return array;
            }

            int pivot = array[0];
            List<int> less = new List<int>();
            List<int> greater = new List<int>();

            for (int x = 1; x < array.Count; x++)
            {
                var value = array[x];
                if (value <= pivot)
                {
                    less.Add(value);
                }
                else
                {
                    greater.Add(value);
                }
            }

            //List<int> less = array.FindAll(x => x <= pivot);
            //List<int> greater = array.FindAll(x => x > pivot);

            var result1 = Exec<int>(less);
            var result2 = Exec<int>(greater);

            result1.Add(pivot);
            result1.AddRange(result2);

            return result1;
        }
    }
}
