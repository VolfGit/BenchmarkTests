

using ConsoleApp3;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

[MemoryDiagnoser]
[RankColumn]
public class Program
{
    

   
    
    public static void Main()
    {
        BenchmarkRunner.Run<Person>();
        string s = "abc";
        Person person = new Person();
        person.Name = "BOB";
        person.Foo();
    }
    [Benchmark]
    public void Foo()
    {
        string s = "abc";
        Console.WriteLine(ConsoleApp3.Program.Print(s));
        
    }


    
}
public class Person
{

    public string Name { get; set; }
    [Benchmark]
    public void Foo()
    {
        Console.WriteLine(Name);

    }
}