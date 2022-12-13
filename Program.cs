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
            while (true) {
                var num = new Number();
                var numBit = "";
                var result = num.Sign == 1 ? "11111" : "00000";
                // num.Read();
                do {
                    var el = (num.ModValue - num.Sign);

                    numBit += (el * num.Multiplier).ToString();
                    num.DivValue /= 2;
                }
                while (num.DivValue != 0);

                for (int i = numBit.Length - 1; i >= 0; i--) {
                    result += numBit[i];
                }

                Console.WriteLine(num.Sign == 1 ? otr(result) : result);
                // Console.ReadLine();
            }

            string otr(string str)
            {
                var i = str.Length;
                var result = "";
                while (str[i] != '0' && i > 0) {
                    i--;
                }
                for (var j = 0; j < i; j++) {
                    result += str[j];
                }
                result += 1;
                for (var j = i + 1; j < str.Length; j++) {
                    result += 0;
                }
                return result;
            
            }
        }
    }
}
