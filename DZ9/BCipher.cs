using System;

namespace DZ9
{
    internal class BCipher : ICipher
    {
        private static readonly char[] Alphabet =
        {
            'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н',
            'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'
        };

        private static readonly char[] Reversed =
        {
            'я', 'ю', 'э', 'ь', 'ы', 'ъ', 'щ', 'ш', 'ч', 'ц', 'х', 'ф', 'у', 'т', 'с',
            'р', 'п', 'о', 'н', 'м', 'л', 'к', 'й', 'и', 'з', 'ж', 'ё', 'е', 'д', 'г', 'в', 'б', 'а'
        };

        /// <summary>
        /// Шифровка кода с помощью замены элемента на тот же элемент с другого конца
        /// </summary>
        public string Encode(string str)
        {
            char[] newArray = new char[str.Length];

            for (int i = 0; i < newArray.Length; i++)
            {
                char ch = str[i];
                char lowerCh = char.ToLower(ch);

                if (char.IsLetter(lowerCh))
                {
                    int alp = Alphabet.IndexOf(lowerCh);
                    char rev = Reversed[alp];
                    rev = char.IsUpper(ch) ? char.ToUpper(rev) : rev;
                    newArray[i] = rev;
                }
                else
                {
                    newArray[i] = ch;
                }
            }

            return new string(newArray);
        }

        /// <summary>
        /// Расшифровка кода
        /// </summary>
        public string Decode(string str)
        {
            return Encode(str);
        }
    }
}