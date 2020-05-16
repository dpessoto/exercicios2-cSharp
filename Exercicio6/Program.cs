using System;

namespace Exercicio6 {

    public class Calculadora {
        public static int operando1;
        public static int operando2;
        public static int Soma() {
            return operando1 + operando2;
        }
        public int Soma(int op1, int op2) {
            Calculadora.operando1 = op1;
            Calculadora.operando2 = op2;
            return Calculadora.Soma();
        }
    }

    class Program {
        static void Main(string[] args) {

            Calculadora calculadora = new Calculadora();

            Console.WriteLine(calculadora.Soma(3, 3));

            Console.WriteLine(Calculadora.Soma());

            Calculadora.operando1 = 4;
            Calculadora.operando2 = 6;
            Console.WriteLine(Calculadora.Soma());


        }
    }
}
