using System;

namespace ExtendString
{
    class Program
    {
        Main(string[] args)
        {
            foreach(string s in args)
            {
                Console.WriteLine(sToRandomCase());
            }
        }
    }
}
