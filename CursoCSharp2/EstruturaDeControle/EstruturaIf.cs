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


            // Uma estrutura de controle não tem ";". Só existe um caso que tem ";". Depois se mostrará qual é o caso.
            }
        }
    }
}
