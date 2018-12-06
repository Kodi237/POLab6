using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLab6
{
    internal class Zad3
    {
        public static void main(String[] args)
        {
            Complex z1 = new Complex(7, 3);
            Complex z2 = new Complex(6, -4);
            Complex c1 = new Complex(5, 5);
            Complex c2 = new Complex(2, 2);

            Console.WriteLine("Modul liczby " + z1 + " = " + Complex.Modul(z1));
            Console.WriteLine("Sprzezenie liczby " + z2 + " = " + Complex.Sprzezenie(z2));
            Console.WriteLine("Suma:\t " + c1 + " + " + c2 + " = " + Complex.SumaAlg(c1, c2));
            Console.WriteLine("Roznica:\t " + c1 + " + " + c2 + " = " + Complex.RoznicaAlg(c1, c2));
            Console.WriteLine("Iloczyn:\t " + c1 + " + " + c2 + " = " + Complex.IloczynAlg(c1, c2));
            Console.WriteLine("Iloraz:\t " + c1 + " + " + c2 + " = " + Complex.IlorazAlg(c1, c2));
        }
    }

    internal class Complex
    {
        double re, im;


        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public static double Modul(Complex c)
        {
            return Math.Sqrt(Math.Pow(c.re, 2) + Math.Pow(c.im, 2));
        }

        public static Complex Sprzezenie(Complex c)
        {
            return new Complex(c.re, (c.im) * (-1));
        }

        //public static double AlgToExp()

        //public static double ExpToAlg()

        public static Complex SumaAlg(Complex c1, Complex c2)
        {
            return new Complex(c1.re + c2.re, c1.im + c2.im);
        }

        //public static Complex SumaExp

        public static Complex RoznicaAlg(Complex c1, Complex c2)
        {
            return new Complex(c1.re - c2.re, c1.im - c2.im);
        }

        public static Complex IloczynAlg(Complex c1, Complex c2)
        {
            return new Complex((c1.re * c2.re) - (c1.im * c2.im), (c1.re * c2.im) + (c1.im * c2.re));
        }

        public static Complex IlorazAlg(Complex c1, Complex c2)
        {
            return new Complex((c1.re * c2.re + c1.im * c2.im) / (c2.re * c2.re + c2.im * c2.im), (c1.im * c2.re - c1.re * c2.im) / (c2.re * c2.re + c2.im * c2.im));
        }

        //public static Complex IlorazExp


        override
        public String ToString()
        {
            return "(" + re + " + " + im + "i)";
        }
    }
}
