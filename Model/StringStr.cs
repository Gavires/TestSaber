using System;
using System.Collections.Generic;
using System.Text;

namespace TestSaber.Model
{
    public class StringStr : BaseModel <string>
    {
        public int Length { get; private set; }

        public StringStr()
        {
            Read();
            Length = Value.Length;
        }

        public override void Read()
        {
            Console.WriteLine("Введите строку");
            try
            {
                Value = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        /// <summary>
        /// Задача 2: Удаление повторов в строке
        /// </summary>
        public override void Task()
        {
            Console.WriteLine(RemoveDups());
        }

        public string RemoveDups()
        {
            var result = new StringBuilder();
            var i = 0;
            while (i < Value.Length)
            {
                result.Append(Value[i]);
                while (i < Length - 1 && Value[i] == Value[i + 1])
                    i++;
                i++;
            }
            return result.ToString();
        }
    }
}
