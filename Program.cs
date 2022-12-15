using System;
using TestSaber.Model;
using TestSaber.Task.Task1;

namespace TestSaber
{
    public class Program
    {
        static void Main(string[] args)
        {
            var task1 = new NumberToBin();
            task1.Task1();
        }
    }
}
