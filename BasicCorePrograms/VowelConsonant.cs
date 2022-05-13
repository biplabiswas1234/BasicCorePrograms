using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    internal class VowelConsonant
    {
        public void VowelCon()
        {

            Console.WriteLine("Enter an alphabet");

            char check = Convert.ToChar(Console.ReadLine());
            if (check == 'a' || check == 'e' || check == 'i' || check == 'o' || check == 'u' || check == 'A' || check == 'E' || check == 'I' || check == 'O' || check == 'U')
            {
                Console.WriteLine("The character {0} is vowel", check);
            }
            else
            {
                Console.WriteLine("The character {0} is consonent", check);
            }
        }
    }
}
