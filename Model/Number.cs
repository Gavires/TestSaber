using System;

namespace TestSaber.Model
{
    public class Number
    {
        public int Value { get; set; }
        public int ValueВischarge { get; private set; }
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

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <returns>Создает новый объект Number из введенного с клавиатуры числа</returns>
        public Number()
        {
            Read();
            DivValue = Value;
            Sign = Value < 0 ? 1 : 0;
        }

        /// <summary>
        /// Ввод числа с клавиатуры
        /// </summary> Вводит число с клавиатуры и записывает в объект Number
        /// <returns></returns>
        public void Read()
        {
            Console.WriteLine("Введите целое число");
            try
            {
                Value = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        /// <summary>
        /// Определение разрядности для отрицательного числа (с условием типа int)
        /// </summary>
        /// <param name="str">двоичное представление введенного числа</param>
        /// <returns>Возвращает дополнительный код для отрицательного числа</returns>
        private string Discharge(string str)
        {
            var result = "";
            for (var i = 0; i < 32 - str.Length; i++)
                result += 1;
            return result;
        }

        /// <summary>
        /// Добавление единицы к двоичному представлению числа
        /// </summary>
        /// <param name="str">двоичное представление введенного числа</param>
        /// <returns>Возвращает двоичное представление числа</returns>
        public string NegativeNumber(string str)
        {
            var i = str.Length - 1;
            var result = Discharge(str);
            while (str[i] != '0' && i > 0)
            {
                i--;
            }
            for (var j = 0; j < i; j++)
            {
                result += str[j];
            }
            result += 1;
            for (var j = i; j < str.Length - 1; j++)
            {
                result += 0;
            }
            return result;
        }
    }
}
