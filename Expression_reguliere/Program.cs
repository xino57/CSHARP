using System;
using System.Text.RegularExpressions;

namespace Expression_reguliere
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ChaineCommençantParP();
            Forcaractor();
        }


        //1) Chaîne commencant par p
        public static void ChaineCommençantParP()
        {
            Console.WriteLine("Veuillez entrer une chaîne de texte :");
            string userInput = Console.ReadLine();

            string pattern = @"P";

            if (Regex.IsMatch(userInput, pattern))
            {
                Console.WriteLine("La chaîne commence par P");
            }
            else
            {
                Console.WriteLine("La chaîne ne commence pas par P");
            }
        }


        // Chaîne commançant par p mais suivi d'exactement 4 caractères
        public static void Forcaractor()
        {
            Console.WriteLine("Veuillez entrer une chaîne de texte :");
            string userInput = Console.ReadLine();

            string pattern = @"^P.{4}$";

            if (Regex.IsMatch(userInput, pattern))
            {
                Console.WriteLine("La chaîne commence par P avec 4 caractères");
            }
            else
            {
                Console.WriteLine("La chaîne ne commence pas par P et n'a pas 4 caractères");
            }
        }

        //Pareil mais uniquement avec des caractère alphabétiques
        public static void CaractorAlphabetique()
        {
            Console.WriteLine("Veuillez entrer une chaîne de texte :");
            string userInput = Console.ReadLine();

            string pattern = @"^[a-zA-Z]";

            if (Regex.IsMatch(userInput, pattern))
            {
                Console.WriteLine("La chaîne commence par une lettre alphabétique");
            }
            else
            {
                Console.WriteLine("\"La chaîne ne commence pas par une lettre alphabétique\"");
            }
        }
    }
}
