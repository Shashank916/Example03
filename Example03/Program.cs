using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TryParse method
            string strInt = "123";
            int i;
            bool parsedSuccessfully = Int32.TryParse(strInt, out i);
            if (parsedSuccessfully)
            {
                Console.WriteLine("The string \"{0}\" was successfully parsed as an integer: {1}", strInt, i);
            }
            else
            {
                Console.WriteLine("The string \"{0}\" could not be parsed as an integer.", strInt);
            }

            // Convert method
            string strDouble = "123.456";
            double d;
            try
            {
                d = Convert.ToDouble(strDouble);
                Console.WriteLine("The string \"{0}\" was successfully parsed as a double: {1}", strDouble, d);
            }
            catch (FormatException)
            {
                Console.WriteLine("The string \"{0}\" could not be parsed as a double.", strDouble);
            }

            // Parse method
            string strDecimal = "123.456";
            Decimal dec;
            try
            {
                dec = Decimal.Parse(strDecimal);
                Console.WriteLine("The string \"{0}\" was successfully parsed as a decimal: {1}", strDecimal, dec);
            }
            catch (FormatException)
            {
                Console.WriteLine("The string \"{0}\" could not be parsed as a decimal.", strDecimal);
            }

        }
    }
}
