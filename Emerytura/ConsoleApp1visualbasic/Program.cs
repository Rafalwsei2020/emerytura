using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ConsoleApp1visualbasic
{
    class Program
    {
        static void Main(string[] args)
        {

            // tu piszemy kod
            Console.OutputEncoding = Encoding.UTF8;

            Interaction.MsgBox("Program Emerytura");

            Console.WriteLine("Program Emerytura");
            Console.Write("Podaj Swoje imie:");
            string imie;
            // imie = Console.ReadLine().Trim().ToUpper();
            //imie = imie.Trim();
            imie = Interaction.InputBox("Podaj imie", "Tytuł Okienka").Trim().ToUpper();
            Console.Write("Podaj Swoje nazwisko:");
            //string Nazwisko = Console.ReadLine().Trim();
            string Nazwisko = Interaction.InputBox("Podaj Nazwisko", "Tytuł Okienka").Trim().ToUpper();
            string pierwszaLitera = Nazwisko.Substring(0, 1);
            string reszta = Nazwisko.Substring(1);
            Nazwisko = pierwszaLitera.ToUpper() + reszta.ToLower();


            //Console.WriteLine("Witaj, " + imie + " " + Nazwisko + "!");
            //Console.WriteLine("Witaj, {0} {1}!", Nazwisko, imie); //formatted string
            Console.WriteLine($"Witaj, {imie} {Nazwisko}!");

            Console.Write("Podaj swój wiek: ");
            int wiek;
            // string s = Console.ReadLine();
            string s = Interaction.InputBox("Podaj wiek", "Tytuł Okienka").Trim().ToUpper();
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
