using System;

namespace Exercicio8 {
    public class Pessoa {
        protected string _TipoDocumento;
        public string Nome { get; set; }
        protected string NumeroDocumento { get; set; }
        public string TipoDocumento { get { return _TipoDocumento; } }
    }
    public class PessoaJuridica : Pessoa {
        //ValidaCNPJ valCnpj = new ValidaCNPJ(); //Não tem classe ValidaCNPJ
        public string CNPJ {
            set { this.NumeroDocumento = value; }
            get { return this.NumeroDocumento; }
        }
        public PessoaJuridica() { _TipoDocumento = "CNPJ"; }
        public bool CnpjValido() {
            return false;
           //valCnpj.IsCnpj(this.NumeroDocumento);
        }
    }

    class Program {
        static void Main(string[] args) {
        }
    }
}
