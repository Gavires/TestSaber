using TestSaber.Model;

namespace TestSaber.Task.Task1
{
    public class NumberToBin
    {
        public NumberToBin()
        {
            Task1();
        }

        /// <summary>
        /// Задача 1
        /// </summary>
        /// <returns>Перевод в двоичную систему  введенного с клавиатуры десятичного знакового числа</returns>
        private void Task1()
        {
            while (true)
            {
                var number = new Number();
                number.Task();
            }
        }
    }
}
