using System;

namespace TestSaber.Model
{
    public class Number : BaseModel<int>
    {
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
        public override void Read()
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

        /// <summary>
        /// Задача 1: Перевод в двоичную систему
        /// </summary>
        public override void Task()
        {
            var numBit = "";
            var result = "";
            do
            {
                numBit += ((ModValue - Sign) * Multiplier).ToString();
                DivValue /= 2;
            }
            while (DivValue != 0);

            for (int i = numBit.Length - 1; i >= 0; i--)
            {
                result += numBit[i];
            }
            var res = Sign == 1 ? NegativeNumber(result) : result;
            var flag = Convert.ToInt32(res, 2) == Value ? "равно" : "неравно";
            Console.WriteLine(res);
            Console.WriteLine($"Проверка: число {res} в десятичной системе {Convert.ToInt32(res, 2)} {flag} исходному числу {Value}");
        }
    }
}
