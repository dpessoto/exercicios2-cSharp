using System;

namespace Exercicio_9 {

    interface Interface01 {
        int metodo01(int num1);
        double metodo01(string parametro1);
    }
    interface Interface02 {
        string metodo02(char UmaLetra);
    }
    class Classe01 : Interface01,Interface02 {
        public int metodo01(int num1) {
            return num1 + 1;
        }
        public double metodo01(string parametro1) {
            double Resultado = 9.3;
            return Resultado;
        }
        public string metodo02(char UmaLetra) {
            string Resultado = string.Empty;
            Resultado = "A letra fornecida foi [" +
            UmaLetra.ToString() + "]";
            return Resultado;
        }
    }

    class Program {
        static void Main(string[] args) {

            Classe01 classe = new Classe01();

            Console.WriteLine(classe.metodo01(2));
            Console.WriteLine(classe.metodo01("Bom dia"));
            Console.WriteLine(classe.metodo02('a'));

        }
    }
}
