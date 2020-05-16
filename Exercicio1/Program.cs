namespace Exercicio1 {

    public class Aluno {
        public string NomeAluno { get; set; }

        public Aluno() {
            this.NomeAluno = "";
        }
        public Aluno(string Nome) {
            NomeAluno = Nome;
        }
    }

    class Program {
        static void Main(string[] args) {

            Aluno aluno = new Aluno();

            Aluno aluno2 = new Aluno("Daniel");
        }
    }
}
