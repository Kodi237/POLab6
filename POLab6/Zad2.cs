using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLab6
{
    internal class Zad2
    {
        public static void main(String[] args)
        {
            Punkt[] p = new Punkt[10];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                p[i] = new Punkt(r.Next(1000), r.Next(1000), r.Next(1000));
                Console.WriteLine(p[i].ToString());
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine(Punkt.last_point.toString());
            Console.WriteLine("-------------------------------------------------");
            Punkt.PokazOstatniObiekt();
        }
    }

    internal class Punkt
    {
        private int x;
        private int y;
        private int z;

        // Pole statyczne przechowujące w pamięci ilość obiektów klasy Punkt
        // Pole jest współdzielone dla wszystkich obiektów
        private static int counter;
        public static Punkt last_point;

        public Punkt(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            counter++;
            last_point = this;
        }

        public static void PokazOstatniObiekt()
        {
            Console.WriteLine("Klasa Punkt o współrzędnych (x = " + last_point.x
                    + " y = " + last_point.y + ""
                    + " z = " + last_point.z + "). Istnieje już"
                    + " " + counter + " obiekt tej klasy.");
        }
    
    override
    public String ToString()
        {
            String s = "Klasa Punkt o współrzędnych (x = " + last_point.x
                    + " y = " + last_point.y + ""
                    + " z = " + last_point.z + "). Istnieje już"
                    + " " + counter + " obiekt tej klasy.";
            return s;
        }
    }
}
