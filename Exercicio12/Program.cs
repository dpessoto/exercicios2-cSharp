using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12 {
    class Program {

        static void Main(string[] args) {
            int z = 0;
            while (z < 10) {
                Console.WriteLine("Primeiro LOOP: " + z);
                string v = z.ToString();
                z++;
            }
            z = 0;
            while (z > 3) {
                Console.WriteLine("Segundo LOOP: " + z);
                string v = z.ToString();
                z++;
            }
        }
    }
}
