using System;


namespace CoreProgram
{
    internal class VowelConsonant
    {
        public static void CheckVowelConsonant()
        {
            Console.WriteLine("Enter any character");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
            {
                Console.WriteLine(ch + " character is a vowel");
            }
            else
            {
                Console.WriteLine(ch + " character is a consonant");
            }
        }
    }
}
