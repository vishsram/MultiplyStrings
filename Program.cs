using System;
using System.Linq;
using System.Text;

namespace MultiplyStrings
{
    class Program
    {
        public String MultiplyStrings(String S1, String S2) {
            char[] allowedChars = {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};

            // Convert S1 & S2 to int
            int number1 = StringToInt(S1, allowedChars);
            int number2 = StringToInt(S2, allowedChars);
            int multiplicationValue = number1 * number2;
            
            // Convert multiplicationValue to String
            String result = IntToString(multiplicationValue);
            return new String(result.Reverse().ToArray());
        }

        public int StringToInt(String Str, char[] allowedChars) {
            if (String.IsNullOrEmpty(Str)) {
                return 0;
            }
            int number = 0;
            for (int i = 0; i < Str.Length; i++) {
                if (!allowedChars.Contains(Str[i])) {
                    throw new ArgumentException("Only numbers from 0 to 9 are allowed.");
                }
                int currentDigit = Str[i] - '0';
                number*=10;
                number+=currentDigit;
            }
            return number;
        }

        public String IntToString (int multiplicationValue) {
            
            StringBuilder resultString = new StringBuilder();

            while (multiplicationValue > 0) {
                int currentDigit = multiplicationValue % 10;
                resultString.Append((char) (currentDigit + '0'));
                multiplicationValue/=10;
            }
            return resultString.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program Multiplication = new Program();
            String result = Multiplication.MultiplyStrings("456", "43");
            Console.WriteLine(result);
        }
    }
}
