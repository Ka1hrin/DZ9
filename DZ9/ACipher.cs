using System;

namespace DZ9
{
    internal class ACipher : ICipher
    {
        /// <summary>
        /// Зашифровать сдвигом на 1 
        /// </summary>
        public string Encode(string str)
        {
            char[] encodeArray = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                char lowerCh = char.ToLower(ch);

                if (char.IsLetter(lowerCh))
                {
                    if (lowerCh == 'я')
                        lowerCh = 'а';
                    else
                        lowerCh = (char)(lowerCh + 1);
                    lowerCh = char.IsUpper(ch) ? char.ToUpper(lowerCh) : lowerCh;
                    encodeArray[i] = lowerCh;
                }
                else
                {
                    encodeArray[i] = ch;
                }
            }
            
            return new string(encodeArray);
        }

        /// <summary>
        /// Расшифровать
        /// </summary>
        public string Decode(string str)
        {
            char[] encodeArray = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                char lowerCh = char.ToLower(ch);

                if (char.IsLetter(lowerCh))
                {
                    if (lowerCh == 'а')
                        lowerCh = 'я'; 
                    else
                        lowerCh = (char)(lowerCh - 1);
                    lowerCh = char.IsUpper(ch) ? char.ToUpper(lowerCh) : lowerCh;
                    encodeArray[i] = lowerCh;
                }
                else
                {
                    encodeArray[i] = ch;
                }
            }
            
            return new string(encodeArray);
        }
    }
}