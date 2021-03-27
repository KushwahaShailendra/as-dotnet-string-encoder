using System;
using System.Text;

namespace Encoder
{
    public class EncoderProcessor
    {
        public string Encode(string message)
        {
            //Implement your code here!
            //Implement your code here!
            var str = new StringBuilder(message.ToLower());
            string vowels = "aeiou";
            string consonants = "bcdfghjklmnpqrstvwxyz";
            string numbers = "1234567890";
            StringBuilder strNum;
            int innerLoop;
            for (var c = 0; c < str.Length; c++)
            {
                if (str[c] == ' ')
                {
                    str[c] = 'y';
                }
                else if (str[c] == 'y')
                {
                    str[c] = ' ';
                }
                else if (vowels.Contains(str[c]))
                {
                    str[c] = (vowels.IndexOf(str[c]) + 1).ToString()[0];
                }
                else if (consonants.Contains(str[c]))
                {
                    str[c] = Convert.ToChar(str[c] - 1);
                }
                else if (numbers.Contains(str[c]))
                {
                    innerLoop = c;
                    strNum = new StringBuilder();
                    while (innerLoop < str.Length && numbers.Contains(str[innerLoop]))
                    {
                        strNum.Insert(0, str[innerLoop]);
                        innerLoop++;
                    }
                    str.Remove(c, innerLoop - c);
                    str.Insert(c, strNum);
                    c = innerLoop - 1;
                }

            }
            return str.ToString();
        }
    }
}