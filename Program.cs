using Microsoft.VisualBasic;
using System;
using System.Text;
using TestSaber.Model;

namespace TestSaber
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                var num = new Number();
                var numBit = "";
                var result =  num.Sign == 1 ?  "11111" : "00000";
                // num.Read();
                do
                {
                    var el = (num.ModValue - num.Sign);

                    numBit += (el* num.Multiplier).ToString();
                    num.DivValue /= 2;
                }
                while (num.DivValue != 0);

                for (int i = numBit.Length-1; i >= 0;  i--) {
                    result += numBit[i];
                }
                //num.DivValue = num.DivValue / 2;
                //numBit.Append(num.ModValue.ToString());
                //while (num.DivValue != 0) 
                //{
                //    numBit.Append(num.ModValue.ToString());
                //    num.DivValue = num.DivValue / 2;
                //}
                Console.WriteLine(result);
               // Console.ReadLine();
            }
        }
    }
}
