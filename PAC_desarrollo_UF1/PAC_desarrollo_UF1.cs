using System;

namespace PAC_desarrollo_UF1
{
    class Program
    {
        static void Main(string[] args){


            //variables 

            String frase_PAC = "ilerna online programacion 2021";
            int number_of_letters = 0;
            int number_of_vowels = 0;
            char [] vowels_only = new char[11];

          

            //For para recorrer: frase_PAC

            for (int i = 0; i < frase_PAC.Length; i++){

                number_of_letters++;

                if (frase_PAC[i] == 'a' | frase_PAC[i] == 'e' | frase_PAC[i] == 'i' | frase_PAC[i] == 'o' | frase_PAC[i] == 'u'){

                    vowels_only[number_of_vowels] = frase_PAC[i];
                    number_of_vowels++;
                }
            }

            Console.WriteLine("variable: numero total de letras en frase_PAC: " + number_of_letters);
            Console.WriteLine("variable: numero total de vocales en frase_PAC: " + number_of_vowels);
            Console.WriteLine("Frase_PAC en mayusculas: " + frase_PAC.ToUpper());
            Console.WriteLine(vowels_only);

        }

    }

}
