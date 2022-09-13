using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Pessoa 
    {
        public string Nome; // quando você marca como public, você quer que esse atributo seja público
        public int Idade;

        // Aqui está se criando um tipo personalizado meu próprio, que eu construí para " Pessoa "

        public string Apresentar()
        {
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos.");
        }
        // Esse método Apresentar() vai precisar do nome e da idade pra poder apresentar a pessoa.
        // Nesse caso específico eu não preciso apresentar parâmetros para o método apresentar, pois
        // quem é dono dos atributos, nesse caso, é a própria "class Pessoa", ou seja, dentro
        // de "Apresentar()" eu tenho acesso ao valor de Nome e ao valor de Idade. Então, nesse
        // caso, eu vou fazer o " return  string.Format() " - é um método q nao se viu ainda.
        // Esse método .Format faz quase a mesma coisa do writeline, só que em vez de imprimir
        // no console, ele retorna uma string formatada.

        // Todos os membros de uma classe, que são tipos básicos, são atribuídos
        // com valor padrão. Inclusive, se for um tipo string, tem valor padrão null;
        // Se for tipo int, tem valor padrão 0. Se verá isso mais para frente nos exemplos.

        // Outro método abaixo:

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar()); // Ou seja, isso retorna para mim uma string
        }

        public void Zerar ()
        {
            Nome = "";
            Idade = 0;
        }
    }
}
