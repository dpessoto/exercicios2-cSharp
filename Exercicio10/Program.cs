using System;

namespace Exercicio10 {
    class Program {
        static void Main(string[] args) {
            int n1 = 3;
            int n2 = 4;
            int n3 = 5;
            if (n1 == n2) {
                Console.WriteLine(" n1 e diferente de n2");
            }
            else {
                Console.WriteLine(" n1 e igual a n2");
            }
            if (n3 < n2) {
                Console.WriteLine(" n3 e menor n2");
            }
            else {
                Console.WriteLine(" n3 nao e menor n2");
            }
        }
    }
}
