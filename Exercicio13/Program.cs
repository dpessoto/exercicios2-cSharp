using System;

namespace Exercicio13 {
    class Program {
        static void Main(string[] args) {
            int[] lista;
            lista = new int[] { 1, 2, 3, 4, 5, 6 };
            int k14 = -2;
            foreach (int num in lista) {
                Console.WriteLine(k14 + " num: " + num);
                k14 = k14 + num;

                if (k14 % 2 == 0) break;
            }
            Console.WriteLine("K14={0}", --k14);
        }
    }
}
