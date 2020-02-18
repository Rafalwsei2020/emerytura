using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppinteraktywnie
{
    class Program
    {
        static void Main(string[] args)
        {
            // tu piszemy kod
            Console.WriteLine("Program Emerytura");
            Console.Write("Podaj Swoje imie:");
            string imie;
            imie = Console.ReadLine().Trim().ToUpper();
            //imie = imie.Trim();
            Console.Write("Podaj Swoje nazwisko:");
            string Nazwisko = Console.ReadLine().Trim();

            string pierwszaLitera = Nazwisko.Substring(0,1);
            string reszta = Nazwisko.Substring(1);
            Nazwisko = pierwszaLitera.ToUpper() + reszta.ToLower();
            

            //Console.WriteLine("Witaj, " + imie + " " + Nazwisko + "!");
            //Console.WriteLine("Witaj, {0} {1}!", Nazwisko, imie); //formatted string
            Console.WriteLine($"Witaj, {imie} {Nazwisko}!");

            Console.Write("Podaj swój wiek: ");
            int wiek;
            string s = Console.ReadLine();
            wiek = int.Parse(s);

            Console.WriteLine($"Masz {wiek} lat.");

            //jezeli wiek > 67 to jestes emerytem 
            // a w przeciwnym wypadku do emerytury zostało Ci 67-wiek lat
            if (wiek >= 67)
            {
                Console.WriteLine("jestes emerytem");
            }
            else
            {
                Console.WriteLine($" do emerytury zostalo ci {67 - wiek} lat");
            
            }





        }
    }
}
