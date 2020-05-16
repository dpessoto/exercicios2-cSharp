using System;
using Unip.POOI.Turma2019;

namespace MEU_ESPACO_DE_NOMES {
    class Program {
        static void Main(string[] args) {
            double graus = 30.0;
            Unip.POOI.A2019.CalCientifica calc1 = new Unip.POOI.A2019.CalCientifica();
            Console.WriteLine("Cosseno de {0} e {1}", graus, calc1.Cosseno(30.0));
            CalAritmetica calc2 = new CalAritmetica();
            Console.WriteLine("A subtracao de 5 - 3 e = {0}", calc2.Subtracao(5, 3));
        }
    }
}
