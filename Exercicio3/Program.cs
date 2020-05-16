using System;

namespace Exercicio3 {

    public class Casa {
        private string Cor;

        public void SetCor(string nomeCor) {
            this.Cor = nomeCor;
        }

        public string GetCor() {
            return this.Cor;
        }
    }

    class Program {
        static void Main(string[] args) {

            Casa casa = new Casa();

            //casa.Cor = "Azul"; //não compila

            casa.SetCor("Azul"); //compila

            Console.WriteLine(casa.GetCor()); //compila

        }
    }
}
