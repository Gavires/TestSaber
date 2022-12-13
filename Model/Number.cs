using System;

namespace TestSaber.Model
{
    public class Number
    {
        public int Value { get; private set; }
        public int DivValue { get; set; }
        public int Sign { get; private set; }
        public int Multiplier
        {
            get { return Value < 0 ? -1 : 1; }
        }
        public int ModValue
        {
            get { return (DivValue % 2) * Multiplier; }
        }

        public Number ()
        {
            Read();
            DivValue = Value;
            Sign = Value < 0 ? 1 : 0;
        }
        public void Read()
        {
            Console.WriteLine("Введите целое число");
            Value = int.Parse(Console.ReadLine());
        }
    }
}
