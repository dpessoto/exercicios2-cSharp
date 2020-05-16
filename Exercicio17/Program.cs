using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17 {

    abstract class Pessoa {
        public string NomePessoa { get; set; }

        public abstract double CalculeIR(int ano);
    }

    class PessoaFisica : Pessoa, ValidarDocumento {
        public override double CalculeIR(int ano) {
            return 1.0;
        }

        public bool Validar() {
            throw new NotImplementedException();
        }
    }

    class PessoaJuridica : Pessoa, ValidarDocumento {
        public override double CalculeIR(int ano) {
            return 1.0;
        }

        public bool Validar() {
            throw new NotImplementedException();
        }
    }

    interface ValidarDocumento {
        bool Validar();
    }


    class Program {
        static void Main(string[] args) {
        }
    }
}
