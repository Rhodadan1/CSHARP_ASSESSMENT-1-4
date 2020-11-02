using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_ASSESSMENT_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the string: ");
            var inputedstring = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputedstring))
            {
                Console.WriteLine("No string Inputed. ");
            }
            var list = inputedstring.GroupBy(a => a).ToList();

            foreach (var c in list)
            {
                Console.WriteLine($"Character {c.Key}: {c.Count()} times\n");

            }




            //NQuestion 2
            Console.WriteLine("Question 2: \n");
            string[] CountryList = new string[] {"Rome", "Amsterdam", "Paris",
                "California", "New Delhi", "London", "Zurich", "Nairobi", "Abu Dhabi"};

            var SortedCountryList = CountryList.OrderBy(x => x.Length).ThenBy(y => y);

            foreach (string City in SortedCountryList)
            {
                Console.WriteLine(City.ToUpper());
            }


            //Question 3
            Console.WriteLine("Question 3: \n");
            Console.WriteLine("input your string");
            string inputstring = Console.ReadLine();

            if (inputstring.Length < 2)
            {
                Console.WriteLine(inputstring);
            }
            else
            {
                char firstletter = inputstring[0];
                char lastletter = inputstring[inputstring.Length - 1];
                char peak = lastletter;


                lastletter = firstletter;
                firstletter = peak;

                string inbetween = inputstring.Substring(1, inputstring.Length - 2);

                Console.WriteLine($"{firstletter}{inbetween}{lastletter}");
            }


            //Question 4
            Console.WriteLine("Question 4: \n");

            var alphabets = new List<char>()
            {
                'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S',
                'T','U','V','W','X','Y','Z'
            };
            var vowels = new List<char>()
            {
                'A','E','I','O','U'
            };



            Console.WriteLine("Enter an alphabet (will pick the first character when morre than one word is entered: ");
            var alphabet = Convert.ToChar(Console.Read());
            if (char.IsWhiteSpace(alphabet))
            {
                Console.WriteLine("Alphabet cannot be empty");
            }
            else
            {
                if (alphabets.Contains(char.ToUpper(alphabet)))
                {
                    if (vowels.Contains(char.ToUpper(alphabet)))
                    {
                        Console.WriteLine($"The alphabet '{alphabet}' is a vowel");
                    }
                    else
                    {
                        Console.WriteLine($"The alphabet '{alphabet}' is a consonant");
                    }
                }
                else

                {
                    Console.WriteLine("The character is not an alphabet");
                }
            }
            Console.ReadKey();
        }    
        
     
       
    }
}
