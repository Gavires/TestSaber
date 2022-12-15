using System;
using TestSaber.Task.Task1;
using TestSaber.Task.Task2;

namespace TestSaber
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Выберите задачу 1 : 2");
                var task = Console.ReadLine();
                switch (task)
                {
                    case "1":
                        var task1 = new NumberToBin();
                        break;
                    case "2":
                        var task2 = new RemoveDuosStr();
                        break;
                    default:
                        throw new Exception("Нет задач с таким номером....");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}