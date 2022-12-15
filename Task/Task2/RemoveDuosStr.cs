using TestSaber.Model;

namespace TestSaber.Task.Task2
{
    public class RemoveDuosStr : BaseModel<string>
    {
        public int Length { get; set; }

        public RemoveDuosStr()
        {
            Task2();
        }

        /// <summary>
        /// Задача 2
        /// </summary>
        /// <returns>Удаление повторов в строке</returns>
        private string Task2()
        {
            while (true)
            {
                var str = new StringStr();
                str.Task();
            }
        }
    }
}