using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string randomLet = ConvertToString("001100010011001001100001011100110110011001110011011001100011001101100001011000010111001101100110011100110110011001001000001111010111001101100110011001100110010101101100011011000110000101110011011000010111001101110001011101110110010101101111001011000010000001010111011010100110101101101100011010100110101101101100011010100110101101101100001011000010111000101111011011110110000101110011011001100111001101100001011100100110110001001000011001010110011001110011011001100011001000110011001101000010111000101111001011100010110000101111001011110010110001110011011001100110110001101100011011110010110001010111011011110111001001101100011001000100100001100101011011000111001101100100011001100111001101100100011001100011010000110010001100110011010001101100011011110010110001010111011011110111001001101100011001000010000101001000011001010110110001101100011011110010110001010111011100110110000101100100011000010111001101100001011001100110000101101111011100100110011101100110011001000110011101100100011001100110011101100100011001100110011101101100011001000010000101001000011001010110010001100001011100110110010001100110011000010111001101100110011001000111001101100111011001100110010001101100011011000110111100101100010101110110000101110011011001000110000101110011011001000110111101110010011011000110010000100001010010000110010101101100011011000110000101110011011001000110000101110011011001100011010000110011001101010011001100110100001101100110111100101100010101110110111100110101001101000011011000110100001101010011011000110101001101000011011001110010011011000110010000100001");
            string[] stringBinary = new string[] { "01001000", "01100101", "01101100", "01101100", "01101111", "00101100", "00100000", "01010111", "01101111", "01110010", "01101100", "01100100", "00100001" };
            List<char> letterHW = new List<char> { };
            List<char> stringHW = new List<char> { };
            Char[] charHW = new Char[13];
            for(int a = 0; a < 13; a++)
            {
                letterHW.Add(Convert.ToChar(ConvertToString(stringBinary[a])));
            }
           
            foreach(char i in randomLet)
            {
                for (int e = 0; e < letterHW.Count; e++)
                {
                    if (i.Equals(letterHW[e]))
                    {
                        stringHW.Add(i);
                    }
                }
            }

            foreach(char c in stringHW)
            {
                if(c.Equals(letterHW[0])){ charHW[0] = c; }
                else if(c.Equals(letterHW[1])) { charHW[1] = c; }
                else if (c.Equals(letterHW[2])) { charHW[2] = c; charHW[3] = c; charHW[10] = c; }
                else if(c.Equals(letterHW[4])) { charHW[4] = c; charHW[8] = c; }
                else if(c.Equals(letterHW[5])) { charHW[5] = c; }
                else if(c.Equals(letterHW[6])) { charHW[6] = c; }
                else if (c.Equals(letterHW[7])) { charHW[7] = c; }
                else if(c.Equals(letterHW[9])) { charHW[9] = c; }
                else if(c.Equals(letterHW[11])) { charHW[11] = c; }
                else if(c.Equals(letterHW[12])) { charHW[12] = c; }
            }

            var qwerty = new string(charHW.ToArray());
            Console.WriteLine(qwerty);
            Console.ReadLine();
        }

        public static string ConvertToString(string binaryNum)
        {
            List<Byte> helloList = new List<Byte>();

            for (int i = 0; i < binaryNum.Length; i += 8)
            {
                helloList.Add(Convert.ToByte(binaryNum.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(helloList.ToArray());
        }
    }
}
