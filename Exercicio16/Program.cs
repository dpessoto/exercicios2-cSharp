using System;

namespace Exercicio16 {
     interface IDBBanco {
        bool Salvar();
        bool Atualizar();
        bool Apagar();
        bool Consultar();
    }

    class Teste : IDBBanco {
        public bool Apagar() {
            throw new NotImplementedException();
        }

        public bool Atualizar() {
            throw new NotImplementedException();
        }

        public bool Consultar() {
            throw new NotImplementedException();
        }

        public bool Salvar() {
            throw new NotImplementedException();
        }
    }

    class Program {
        static void Main(string[] args) {

            Teste teste = new Teste();
        }
    }
}
