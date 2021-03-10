using System;
using System.Collections.Generic;

namespace GeneriskaKlasser
{
    public class Butik
    {
        public static Dictionary<string, int> varor = new Dictionary<string, int>();
        private static int pengar = 50;
        private static string vara = "";
        private static bool harRåd = false;
        public Butik(){
            
            varor.Add("Äpple", 10);
            varor.Add("Apelsin", 15);
            varor.Add("Banan", 5);
        }
        private static void VadFinns(){
            foreach (string key in varor.Keys)
            {
                Console.WriteLine(key + ": " + varor[key]);
            }
        }
        private static void Berätta(){
            Console.WriteLine("Hej och välkommen till Coop! Idag har vi att erbjuda: ");
            VadFinns();
            Console.WriteLine("Du har " + pengar + "kronor att handla för idag!");
        }
        public static void Handla(){
            Berätta();
            Console.WriteLine("Vad vill du köpa idag?");
            /*Denna del funkar "inte". Den kollar igenom om varorna finns och om de gör de så drar den pengar annars får man skriva in igen.
            Dock så skriver den också ut att man har misslyckats med att köpa trots att den lyckats. Den kör alltså igneom hela listan oavsett om man
            har lyckats med sitt köp eller ej. Dessutom så skriver den ut felmedelandet varje gång i alla de olika varianter jag testat. Jag är
            för trött för att se vad som är fel idag. 
            */
            while (!harRåd)
            {
                vara = Console.ReadLine();
                foreach (string key in varor.Keys)
                {
                    if (vara != key || pengar < varor[key])
                    {
                        Console.WriteLine("Du måste välja en vara som finns, samt att du behäver ha råd med den! DU har: " + pengar + " kronor!. Butiken erbjuder: ");
                        VadFinns();
                    }
                    else
                    {
                        pengar -= varor[key];
                        harRåd = true;
                    }
                    
                }
            }
            
        }
    }
}
