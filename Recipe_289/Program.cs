using System;
using DBSample.EF;


namespace DBSample {
    class Program {
        static void Main(string[] args)
        {
            ExampleDbContext contexts = new ExampleDbContext();
            Console.WriteLine(contexts.ToString());
        }
    }
}


