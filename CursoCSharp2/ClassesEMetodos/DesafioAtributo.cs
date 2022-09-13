using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos 
{
    class DesafioAtributo 
    {
        int a = 10; // isso é um atributo de instância.

        public static void Executar() 
        {
            // DESAFIO: Acessar variável 'a' dentro do método Executar. Ou seja, acessar uma variável que está fora do método.
            //Console.WriteLine(a); Desse jeito não dá.

            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);

            // Aqui a grande questão é estar dentro de um método static tentando acessar um atributo que pertence a instância. 
            // Como atributo pertence a instância, você precisa criar uma instância, atribuir isso a uma variável 

        }
    }
}
