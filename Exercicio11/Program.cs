using System;

namespace Exercicio11 {
    class Program {
        static void Main(string[] args) {
            string y = "";
            char o1 = 'c';
            switch (o1) {
                case '1':
                case 'c':
                    y = "ACHEI A OPCAO 1"; goto case 'A';
                    break;
                case 'A':
                    y = "ACHEI A OPCAO A";
                    break;
                default:
                    y = "ACHEI A OPCAO 4";
                    break;
            }
            Console.WriteLine("y={0}", y);
        }
    }
}
