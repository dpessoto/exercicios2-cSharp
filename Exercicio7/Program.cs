using System;

namespace Exercicio7 {

    public class ClasseComErro {

        public int TesteDivisaoPorZero() {
            int CodErro = 0;
            try {
                int denominador = 2;
                int Numerador = 6;
                int x = Numerador / denominador;
                Console.WriteLine(x);
                CodErro = 1;
            }
            catch (DivideByZeroException e) {
                CodErro = -1;
                string err = e.Message;
            }
            catch (Exception ex) {
                CodErro = -2;
                string err = ex.Message;
            }
            return CodErro;
        }
    }

    class Program {
        static void Main(string[] args) {

            ClasseComErro erro = new ClasseComErro();

            Console.WriteLine(erro.TesteDivisaoPorZero());

        }
    }
}
