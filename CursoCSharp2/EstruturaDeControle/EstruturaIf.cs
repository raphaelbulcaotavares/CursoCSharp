using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaIf {
        public static void Executar () {

            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamente (S/N): ");
            entrada = Console.ReadLine();

            if (entrada == "S" || entrada == "s")
                bomComportamento = true;

            if(nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de Honra! ");

            // TESTE 2.
            // Modificações da estrutura if. 
            // Uma estrutura de controle não tem ";". Só existe um caso que tem ";". Depois se mostrará qual é o caso.
            // A estrutura de controle, como o próprio nome já fiz, ela vai controlar as sentenças. Ela, por si, não é uma sentença de código.
            // Por exemplo: uma estrutura de controle fará com que a sentença seja executada várias vezes. No caso do "if", ele vai decidir se uma sentença
            // ou bloco de código será ou não executado.
            // Portanto, o "if" e todas as estruturas de controle, em sua regra geral, não têm ";" em sua estrutura, com exceção de UM CASO.
            }
        }
    }
}
