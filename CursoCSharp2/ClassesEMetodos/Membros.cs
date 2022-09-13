using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar () {
            
            Pessoa sicrano = new Pessoa(); 
            // Esse é o momento em que nós criamos um objeto a partir
            // da class "Pessoa".
            // Ou seja, o tipo da variável é "Pessoa", pois Class = Tipo da variável, como vimos.
            // O identificador (nome) da variável é sicrano.
            // E aí, depois a gente coloca " new Pessoa () ". Nós vamos ver esse conceito mais pra
            // frente. Isto é chamado de construtor. Nesse caso, tem os parenteses pq é um metodo.
            // Nesse caso é um método que está sendo executado para criar uma nova pessoa. 
            
            sicrano.Nome = "Renato"; // Com o novo objeto criado, eu coloco os atributos que eu quiser.
            sicrano.Idade = 21;


            // Uma vez que eu preenchi os dados desse objeto, eu posso usar como eu quiser.


            Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos");

            sicrano.ApresentarNoConsole();
            

            var fulano = new Pessoa(); // ou seja, eu posso colocar tanto o tipo "Pessoa" como
            // eu posso fazer com que o próprio compilador faça a inferência
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            var apresentacaoDoFulano = fulano.Apresentar();
            


            

        }
    }
}
