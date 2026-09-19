using System;

class Program
{
    static void Main(string[] args)
    {
        int? n1 = null;

        if (n1.HasValue)
        {
            int n2 = n1.Value;
            Console.WriteLine(n2);
        }
        int n3 = 42;
        int? n4 = n3;
        int? n5 = n4;

        Nullable<int> n6 = null;
        int n7 = n6.GetValueOrDefault();


        Console.WriteLine(n1);
        Console.WriteLine(n5);
        Console.WriteLine(n7);
    }
}