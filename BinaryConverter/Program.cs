using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryConverter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        static public string NumToBin(int number)
        {
            if (number == 0)
            {
                return "0";
            }

            else
            {
                List<string> binStr = new List<string>();

                while (number > 1)
                {
                    binStr.Add(Convert.ToString(number % 2));
                    number = (int)Math.Floor((double)number / 2);
                }


                binStr.Add("1");
                binStr.Reverse();
                return string.Join("", binStr);
            }
            
        }

        static public string BinToNum(string bin)
        {
            int number = 0; 

            for (int i = 0; i < bin.Length; i++)
            {
                if(bin[i].Equals('1'))
                {
                    number += (int)Math.Pow(2,bin.Length - i - 1);
                }
                if(Regex.IsMatch(bin[i].ToString(), "[^\b0-1]"))
                {
                    throw new FormatException();
                }
 
            }

            return number.ToString();   
        }

        static public string NumToHex(int number)
        {
            List<string> hex = new List<string>();
            Dictionary<int, string> hexKey = new Dictionary<int, string>()
            {
                {10, "A" },
                {11, "B" },
                {12, "C" },
                {13, "D" },
                {14, "E" },
                {15, "F" }
            };

            while(number >= 16)
            {
                hex.Add(Convert.ToString(number % 16));
                number = (int)Math.Floor((double)number / 16);

            }

            hex.Add(number.ToString());
            hex.Reverse();

            for (int i = 0; i < hex.Count; i++)
            {
                if(Convert.ToInt32(hex[i]) >= 10)
                {
                    hex[i] = hexKey[Convert.ToInt32(hex[i])];
                }
            }

            return string.Join("", hex);

        }

        static public string HexToNum(string hex)
        {
            Dictionary<string, int> hexKey = new Dictionary<string, int>()
             {
                 {"0",0 },
                 {"1",1 },
                 {"2",2 },
                 {"3",3 },
                 {"4",4 },
                 {"5",5 },
                 {"6",6 },
                 {"7",7 },
                 {"8",8 },
                 {"9",9 },
                 {"A",10 },
                 {"B",11 },
                 {"C",12 },
                 {"D",13 },
                 {"E",14 },
                 {"F",15}
             };

            double number = 0; 

            for (int i = 0; i < hex.Length; i++)
            {
                number += hexKey[hex[i].ToString()] * Math.Pow(16, (hex.Length - i - 1));
            }

            return number.ToString(); 
        }

        
    }
}
