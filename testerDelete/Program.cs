using System;

namespace testerDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine(Guid.NewGuid().ToString());

            Console.ReadKey();
            goto start;
        }
    }
}
