using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05_5A_09_10_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print_all_English_Alphabet_letters_from_a_to_z_The_first_Usage();
            //Print_all_English_Alphabet_letters_from_a_to_z_The_second_Usage();
            Print_all_English_Alphabet_letters_from_a_to_z_The_third_Usage();

            Print_all_English_Alphabet_letters_from_z_to_a();

            Print_all_English_Alphabet_letters_from_A_to_Z_UPPER_CASE();

            Output_the_ASCII_code_of_an_inputted_character();

            Check_if_an_inputted_character_is_upper_or_lower_case();

            Change_an_inputted_character_is_upper_and_lower_case();
        }
        public static void Print_all_English_Alphabet_letters_from_a_to_z_The_first_Usage()
        {
            Console.WriteLine("Please Print All English Alphabet Letters From a To z ");
            Console.WriteLine("\nAll English Alphabet Letters From a To z Are: ");
            for (int i = 97; i <= 122; i++)
            {
                Console.Write((char)i + ",");
            }
        }

        public static void Print_all_English_Alphabet_letters_from_a_to_z_The_second_Usage()
        {
            Console.WriteLine("Please Print All English Alphabet Letters From a To z ");
            Console.WriteLine("\nAll English Alphabet Letters From a To z Are: ");
            char i;
            for (i = 'A'; i <= 'Z'; i++)
            {
                Console.Write("%c", i);
            }

        }

        public static void Print_all_English_Alphabet_letters_from_a_to_z_The_third_Usage()
        {
            Console.WriteLine("Please Print All English Alphabet Letters From a To z ");
            Console.WriteLine("\nAll English Alphabet Letters From a To z Are: ");
            string s = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + "-");
            }
        }

        public static void Print_all_English_Alphabet_letters_from_z_to_a()
        {
            Console.WriteLine("\n\nPlease Print All English Alphabet Letters From z To a");
            Console.WriteLine("\nAll English Alphabet Letters From z To a Are: ");
            for (int i = 122; i >= 97; i--)
            {
                Console.Write((char)i + "-");
            }
        }

        public static void Print_all_English_Alphabet_letters_from_A_to_Z_UPPER_CASE()
        {
            Console.WriteLine("\n\nPlease Print All English Alphabet Letters From A To Z (UPPER CASE)");
            Console.WriteLine("\nAll English Alphabet Letters From A To Z (UPPER CASE) Are :");
            for (int i = 65; i <= 90; i++)
            {
                Console.Write((char)i + "-");
            }
        }

        public static void Output_the_ASCII_code_of_an_inputted_character()
        {
            Console.WriteLine("\n\n==================================================The ASCII Code Of An Inputted Character:==================================================");
            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine(i + " = " + (char)i);

                if (i % 22 == 0)
                {
                    Console.Write("\nlease press any key to turn page");
                    Console.ReadKey();

                }
            }
        }

        public static void Check_if_an_inputted_character_is_upper_or_lower_case()
        {
            Console.Write("\n\nCheck whether a character is alphabet or not and if so, check for case :\n");
            Console.Write("-----------------------------------------------------------------------------\n");
            Console.Write("Input a character: ");
            char ch = (char)Console.Read();
            if (Char.IsLetter(ch))
            {
                if (Char.IsUpper(ch))
                {
                    Console.WriteLine("\nThe character is uppercase.\n");
                }
                else
                {
                    Console.WriteLine("\nThe character is lowercase.\n");
                }
            }
            else
            {
                Console.WriteLine("\nThe entered character is not an alphabetic character.\n");
            }
        }

        public static void Change_an_inputted_character_is_upper_and_lower_case()
        {

            string str1;
            char[] arr1;
            int l, i;
            l = 0;
            char ch;
            Console.Write("\n\nReplace lowercase characters by uppercase and vice-versa :\n");
            Console.Write("--------------------------------------------------------------\n");
            Console.Write("Input the string : ");
            str1 = Console.ReadLine();
            l = str1.Length;
            arr1 = str1.ToCharArray(0, l); // Converts string into char array.

            Console.Write("\nAfter conversion, the string is : ");
            for (i = 0; i < l; i++)
            {
                ch = arr1[i];
                if (Char.IsLower(ch)) // check whether the character is lowercase
                    Console.Write(Char.ToUpper(ch)); // Converts lowercase character to uppercase.
                else
                    Console.Write(Char.ToLower(ch)); // Converts uppercase character to lowercase.
            }
            Console.Write("\n\n");
        }
    }
}
