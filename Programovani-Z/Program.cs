using System;
using System.Collections.Generic;
using System.Linq;

namespace Programovani_Z
{
    class Program
    {
        static void Main(string[] args)
        {
            Kostka k = new Kostka(6);





            // ax^2 + bx + c = 0

            string vstup = Console.ReadLine();
            int vst = int.Parse(vstup);

            int a = 1;
            int b = 1;
            int c = -2;

            int D = b * b - 4 * a * c;

            int x1 = (-b + (int)Math.Sqrt(D)) / (2 * a);
            int x2 = (-b - (int)Math.Sqrt(D)) / (2 * a);





















            while (true)
            {
                Console.WriteLine(k.HodKostkou());
                Console.ReadKey(true);
            }




            /*


            string[] oldp = { "abc", "def", "ghi" };
            string[] newp = new string[oldp.Length + 1];
            Array.Copy(oldp, newp, oldp.Length);
            newp[oldp.Length] = "jkl";


            List<string> pole = new List<string>();
            pole.Add("abc");
            pole.Add("abc");
            pole.Add("def");
            pole.Add("ghi");
            pole.Add("jkl");

            HashSet<string> mnozina = new HashSet<string>();
            mnozina.Add("abc");
            mnozina.Add("abc");
            mnozina.Add("def");
            mnozina.Add("ghi");
            mnozina.Add("jkl");

            Console.ReadKey();*/
        }
    }
}
