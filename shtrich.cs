using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace WindowsFormsApplication6
{
    class Code128B
    {
        public string input;
        public string output;
        List<string> lst;
        Hashtable htb;
        public void ComputeSum()
        {
            int sum = 104;
            for (int i = 0; i < input.Length; i++)
            {
                int pos = i + 1;
                int c = lst.IndexOf(input[i].ToString());
                int res = c * pos;
                sum += res;
            }
            sum = sum % 103;
            string newe="";
            for(int i=0;i<input.Length;i++) newe+=String.Format("[{0}",input[i]);
            input=newe;
            input += "[";
            input += lst[sum];
        }
        public Code128B(string inp)
        {
            input = inp;
            htb = new Hashtable();
            htb.Add(" ", "11011001100");
            htb.Add("!", "11001101100");
            htb.Add("\"", "11001100110");
            htb.Add("#", "10010011000");
            htb.Add("$", "10010001100");
            htb.Add("%", "10001001100");
            htb.Add("&", "10011001000");
            htb.Add("'", "10011000100");
            htb.Add("(", "10001100100");
            htb.Add(")", "11001001000");
            htb.Add("*", "11001000100");
            htb.Add("+", "11000100100");
            htb.Add(",", "10110011100");
            htb.Add("-", "10011011100");
            htb.Add(".", "10011001110");
            htb.Add("/", "10111001100");
            htb.Add("0", "10011101100");
            htb.Add("1", "10011100110");
            htb.Add("2", "11001110010");
            htb.Add("3", "11001011100");
            htb.Add("4", "11001001110");
            htb.Add("5", "11011100100");
            htb.Add("6", "11001110100");
            htb.Add("7", "11101101110");
            htb.Add("8", "11101001100");
            htb.Add("9", "11100101100");
            htb.Add(":", "11100100110");
            htb.Add(";", "11101100100");
            htb.Add("<", "11100110100");
            htb.Add("=", "11100110010");
            htb.Add(">", "11011011000");
            htb.Add("?", "11011000110");
            htb.Add("@", "11000110110");
            htb.Add("A", "10100011000");
            htb.Add("B", "10001011000");
            htb.Add("C", "10001000110");
            htb.Add("D", "10110001000");
            htb.Add("E", "10001101000");
            htb.Add("F", "10001100010");
            htb.Add("G", "11010001000");
            htb.Add("H", "11000101000");
            htb.Add("I", "11000100010");
            htb.Add("J", "10110111000");
            htb.Add("K", "10110001110");
            htb.Add("L", "10001101110");
            htb.Add("M", "10111011000");
            htb.Add("N", "10111000110");
            htb.Add("O", "10001110110");
            htb.Add("P", "11101110110");
            htb.Add("Q", "11010001110");
            htb.Add("R", "11000101110");
            htb.Add("S", "11011101000");
            htb.Add("T", "11011100010");
            htb.Add("U", "11011101110");
            htb.Add("V", "11101011000");
            htb.Add("W", "11101000110");
            htb.Add("X", "11100010110");
            htb.Add("Y", "11101101000");
            htb.Add("Z", "11101100010");
            htb.Add("[", "11100011010");
            htb.Add("\\", "11101111010");
            htb.Add("]", "11001000010");
            htb.Add("^", "11110001010");
            htb.Add("_", "10100110000");
            htb.Add("`", "10100001100");
            htb.Add("a", "10010110000");
            htb.Add("b", "10010000110");
            htb.Add("c", "10000101100");
            htb.Add("d", "10000100110");
            htb.Add("e", "10110010000");
            htb.Add("f", "10110000100");
            htb.Add("g", "10011010000");
            htb.Add("h", "10011000010");
            htb.Add("i", "10000110100");
            htb.Add("j", "10000110010");
            htb.Add("k", "11000010010");
            htb.Add("l", "11001010000");
            htb.Add("m", "11110111010");
            htb.Add("n", "11000010100");
            htb.Add("o", "10001111010");
            htb.Add("p", "10100111100");
            htb.Add("q", "10010111100");
            htb.Add("r", "10010011110");
            htb.Add("s", "10111100100");
            htb.Add("t", "10011110100");
            htb.Add("u", "10011110010");
            htb.Add("v", "11110100100");
            htb.Add("w", "11110010100");
            htb.Add("x", "11110010010");
            htb.Add("y", "11011011110");
            htb.Add("z", "11011110110");
            htb.Add("{", "11110110110");
            htb.Add("|", "10101111000");
            htb.Add("}", "10100011110");
            htb.Add("~", "10001011110");
            htb.Add("DEL", "10111101000");
            htb.Add("FNC3", "10111100010");
            htb.Add("FNC2", "11110101000");
            htb.Add("SHIFT", "11110100010");
            htb.Add("CODEC", "10111011110");
            htb.Add("FNC4", "10111101110");
            htb.Add("CODEA", "11101011110");
            htb.Add("FNC1", "11110101110");
            htb.Add("Start A", "11010000100");
            htb.Add("Start B", "11010010000");
            htb.Add("Start C", "11010011100");
            htb.Add("Stop", "1100011101011");
             lst = new List<string>();
            lst.Add(" ");
            lst.Add("!");
            lst.Add("\"");
            lst.Add("#");
            lst.Add("$");
            lst.Add("%");
            lst.Add("&");
            lst.Add("'");
            lst.Add("(");
            lst.Add(")");
            lst.Add("*");
            lst.Add("+");
            lst.Add(",");
            lst.Add("-");
            lst.Add(".");
            lst.Add("/");
            lst.Add("0");
            lst.Add("1");
            lst.Add("2");
            lst.Add("3");
            lst.Add("4");
            lst.Add("5");
            lst.Add("6");
            lst.Add("7");
            lst.Add("8");
            lst.Add("9");
            lst.Add(":");
            lst.Add(";");
            lst.Add("<");
            lst.Add("=");
            lst.Add(">");
            lst.Add("?");
            lst.Add("@");
            lst.Add("A");
            lst.Add("B");
            lst.Add("C");
            lst.Add("D");
            lst.Add("E");
            lst.Add("F");
            lst.Add("G");
            lst.Add("H");
            lst.Add("I");
            lst.Add("J");
            lst.Add("K");
            lst.Add("L");
            lst.Add("M");
            lst.Add("N");
            lst.Add("O");
            lst.Add("P");
            lst.Add("Q");
            lst.Add("R");
            lst.Add("S");
            lst.Add("T");
            lst.Add("U");
            lst.Add("V");
            lst.Add("W");
            lst.Add("X");
            lst.Add("Y");
            lst.Add("Z");
            lst.Add("[");
            lst.Add("\\");
            lst.Add("]");
            lst.Add("^");
            lst.Add("_");
            lst.Add("`");
            lst.Add("a");
            lst.Add("b");
            lst.Add("c");
            lst.Add("d");
            lst.Add("e");
            lst.Add("f");
            lst.Add("g");
            lst.Add("h");
            lst.Add("i");
            lst.Add("j");
            lst.Add("k");
            lst.Add("l");
            lst.Add("m");
            lst.Add("n");
            lst.Add("o");
            lst.Add("p");
            lst.Add("q");
            lst.Add("r");
            lst.Add("s");
            lst.Add("t");
            lst.Add("u");
            lst.Add("v");
            lst.Add("w");
            lst.Add("x");
            lst.Add("y");
            lst.Add("z");
            lst.Add("{");
            lst.Add("|");
            lst.Add("}");
            lst.Add("~");
            lst.Add("DEL");
            lst.Add("FNC 3");
            lst.Add("FNC 2");
            lst.Add("SHIFT");
            lst.Add("CODE C");
            lst.Add("FNC 4");
            lst.Add("CODE A");
            lst.Add("FNC 1");
            lst.Add("Start A");
            lst.Add("Start B");
            lst.Add("Start C");
            lst.Add("Stop");
            ComputeSum();
            input = string.Format("[Start B{0}", input);
            input += "[Stop";
            string[] arr=input.Split('[');
            output += "00000";
            for (int i = 0; i < arr.Length; i++) output += htb[arr[i]];

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication6
{
    class EAN13
    {
        public string input;
        public string output;
        private int CheckSum()
        {
            string code = input;
            int x = 0;
            int y = 0;
            for (int i = 0; i < 12; i++)
            {
                int pos = i + 1;
                if (pos % 2 == 0) y += Convert.ToInt32(input[i])-48; else x +=Convert.ToInt32(input[i])-48;
            }
            int z = x + 3 * y;
            int zz = z;
            while (z % 10 != 0) z++;
            int checksum = z - zz;
            return checksum;
        }
        public EAN13(string inp)
        {
            input = inp;
            if (input.Length != 13)
            {
                input=input.Insert(12, Convert.ToString(CheckSum()));
            }
            
            string temp = "";
            for (int i = 12; i >= 0; i--) temp += input[i];
            //input = temp;
            string[] first_table = { "0001101", "0011001", "0010011", "0111101", "0100011", "0110001", "0101111", "0111011", "0110111", "0001011" };
            string[] second_table = { "0100111", "0110011", "0011011", "0100001", "0011101", "0111001", "0000101", "0010001", "0001001", "0010111" };
            string[] third_table = { "1110010", "1100110", "1101100", "1000010", "1011100", "1001110", "1010000", "1000100", "1001000", "1110100" };
            int num = input[0]-48;
            output += "101";
            switch (num)
            {
                case 0:
                    {
                        for (int i = 1; i < 7; i++) output += first_table[input[i]-48];
                        break;
                    }
                case 1:
                    {
                        output += first_table[input[1]-48];
                        output += first_table[input[2]-48];//AABABB
                        output += second_table[input[3]-48];
                        output += first_table[input[4]-48];
                        output += second_table[input[5]-48];
                        output += second_table[input[6]-48];
                        
                        break;
                    }
                case 2://AABBAB
                    {
                        output += first_table[input[1]-48];
                        output += first_table[input[2]-48];
                        output += second_table[input[3]-48];
                        output += second_table[input[4]-48];
                        output += first_table[input[5]-48];
                        output += second_table[input[6]-48];
                        break;
                    }
                case 3://AABBBA
                    {
                        output += first_table[input[1]-48];
                        output += first_table[input[2]-48];
                        output += second_table[input[3]-48];
                        output += second_table[input[4]-48];
                        output += second_table[input[5]-48];
                        output += first_table[input[6]-48];
                        break;
                    }
                case 4://ABAABB
                    {
                        output += first_table[input[1]-48];
                        output += second_table[input[2]-48];
                        output += first_table[input[3]-48];
                        output += first_table[input[4]-48];
                        output += second_table[input[5]-48];
                        output += second_table[input[6]-48];
                        break;
                    }
                case 5://ABBAAB
                    {
                        output += first_table[input[1]-48];
                        output += second_table[input[2]-48];
                        output += second_table[input[3]-48];
                        output += first_table[input[4]-48];
                        output += first_table[input[5]-48];
                        output += second_table[input[6]-48];
                        break;
                    }
                case 6://ABBBAA
                    {
                        output += first_table[input[1]-48];
                        output += second_table[input[2]-48];
                        output += second_table[input[3]-48];
                        output += second_table[input[4]-48];
                        output += first_table[input[5]-48];
                        output += first_table[input[6]-48];
                        break;
                    }
                case 7://ABABAB
                    {
                        output += first_table[input[1]-48];
                        output += second_table[input[2]-48];
                        output += first_table[input[3]-48];
                        output += second_table[input[4]-48];
                        output += first_table[input[5]-48];
                        output += second_table[input[6]-48];

                        break;
                    }
                case 8://ABABBA
                    {
                        output += first_table[input[1]-48];
                        output += second_table[input[2]-48];
                        output += first_table[input[3]-48];
                        output += second_table[input[4]-48];
                        output += second_table[input[5]-48];
                        output += first_table[input[6]-48];

                        break;
                    }
                case 9://ABBABA
                    {
                        output += first_table[input[1]-48];
                        output += second_table[input[2]-48];
                        output += second_table[input[3]-48];
                        output += first_table[input[4]-48];
                        output += second_table[input[5]-48];
                        output += first_table[input[6]-48];
                        break;
                    }
            }
            output += "01010";
            for (int i = 7; i < 13; i++) output += third_table[input[i]-48];
            output += "101";
        }
    }
}
