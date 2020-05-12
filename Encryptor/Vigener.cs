using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    class Vigener
    {
        public static readonly string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";

        public Vigener()
        {

        }

        public string Encrypt(string input, string password)
        {
            input = CheckAlphabet(input);
            password = CheckAlphabet(password);

            string output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                int it = Alphabet.IndexOf(input[i]);
                int pw = Alphabet.IndexOf(password[i % password.Length]);

                int ot = (it + pw + 1) % Alphabet.Length;

                output += Alphabet[ot];
            }

            return output;
        }

        public string Decrypt(string input, string password)
        {
            input = CheckAlphabet(input);
            password = CheckAlphabet(password);

            string output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                int it = Alphabet.IndexOf(input[i]);
                int pw = Alphabet.IndexOf(password[i % password.Length]);

                int ot = (it - pw - 1);

                if (ot < 0)
                    ot += Alphabet.Length;

                output += Alphabet[ot];
            }

            return output;
        }

        private string CheckAlphabet(string input)
        {
            string output = string.Empty;

            foreach (char c in input)
            {
                if (Alphabet.Contains(c))
                    output += c;
            }

            return output;
        }
    }
}
