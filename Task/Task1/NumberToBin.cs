using System;
using System.Collections.Generic;
using System.Text;
using TestSaber.Model;

namespace TestSaber.Task.Task1
{
    public class NumberToBin
    {
        /// <summary>
        /// Задача 1
        /// </summary>
        /// <returns>Перевод в двоичную систему  введенного с клавиатуры десятичного знакового числа</returns>
        public void Task1()
        {
            while (true)
            {
                var numBit = "";
                var result = "";
                var num = new Number();
                do
                {
                    numBit += ((num.ModValue - num.Sign) * num.Multiplier).ToString();
                    num.DivValue /= 2;
                }
                while (num.DivValue != 0);

                for (int i = numBit.Length - 1; i >= 0; i--)
                {
                    result += numBit[i];
                }
                var res = num.Sign == 1 ? num.NegativeNumber(result) : result;
                var flag = Convert.ToInt32(res, 2) == num.Value ? "равно" : "неравно";
                Console.WriteLine(res);
                Console.WriteLine($"Проверка: число {res} в десятичной системе {Convert.ToInt32(res, 2)} {flag} исходному числу {num.Value}");
            }
        }
    }
}
