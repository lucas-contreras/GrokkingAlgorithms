// See https://aka.ms/new-console-template for more information
using Algorithms;
using BenchmarkDotNet.Running;

List<int> elems = new List<int>
{
    4,1,5,3,6,12,56,54545,13,6776,2334,23,3,
};


var a = QuickSort.Exec<int>(elems);

//var summary = BenchmarkRunner.Run<QuickSort>();


a.ForEach(x => Console.WriteLine(x));
