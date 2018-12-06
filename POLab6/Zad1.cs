using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLab6
{
    internal class Zad1
    {
        public static void main(String[] args)
        {
            // TODO zad 3

            Console.WriteLine(Figury.PoleKola(0.5));
            Console.WriteLine(Figury.ObwodKola(0.5));

            Console.WriteLine(Figury.PoleKwadratu(1.5));
            Console.WriteLine(Figury.ObwodKwadratu(1.5));
            Console.WriteLine(Figury.PoleProstokata(2.5, 5.5));
            Console.WriteLine(Figury.ObwodProstokata(2.5, 5.5));
            Console.WriteLine(Figury.PoleStozka(3.5, 7.5));
            Console.WriteLine(Figury.ObjetoscStozka(3.5, 8.3));
            Console.WriteLine(Figury.PoleWalca(2.7, 7.7));
            Console.WriteLine(Figury.ObjetoscWalca(2.7, 7.7));
        }
    }

    internal class Figury
    {
        /**
     * Inicjalizator statyczny
     */



        /**
        * Metoda statyczna obliczająca pole koła
        */
        public static double PoleKola(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        /**
         * Metoda statyczna obliczająca obwód koła
         */
        public static double ObwodKola(double r)
        {
            return 2 * Math.PI * r;
        }

        /**
         *
         * Metoda statyczna obliczająca pole kwadratu
         */
        public static double PoleKwadratu(double a) { return Math.Pow(a, 2); }

        /**
         * Metoda statyczna obliczająca obwód kwadratu
         */
        public static double ObwodKwadratu(double a) { return 4 * a; }

        /**
         * Metoda statyczna obliczająca pole prostokata
         */
        public static double PoleProstokata(double a, double b) { return a * b; }

        /**
         * Metoda statyczna obliczająca obwód prostokąta
         */
        public static double ObwodProstokata(double a, double b) { return 2 * a + 2 * b; }

        /**
         * Metoda statyczna obliczająca pole stożka
         */
        public static double PoleStozka(double r, double l) { return Math.PI * Math.Pow(r, 2) + Math.PI * r * l; }

        /**
         * Metoda statyczna obliczająca objętość stożka
         */
        public static double ObjetoscStozka(double r, double h) { return (Math.PI * Math.Pow(r, 2) * h) / 3; }

        /**
         * Metoda statyczna obliczająca pole walca
         */
        public static double PoleWalca(double r, double h) { return 2 * Math.PI * Math.Pow(r, 2) + 2 * Math.PI * r * h; }

        /**
         * Metoda statyczna obliczająca objetość walca
         */
        public static double ObjetoscWalca(double r, double h) { return Math.PI * Math.Pow(r, 2) * h; }

    }
}
