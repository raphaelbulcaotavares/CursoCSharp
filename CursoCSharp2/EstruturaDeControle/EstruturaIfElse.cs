using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaIfElse {
        public static void Executar() {
            double nota = 7.0;
            string entrada;

            Console.WriteLine("Digite uma nota: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out nota);

            if (nota >= 7.0) {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Não fez mais que sua obrigação");
            } else {
                Console.WriteLine("Recuperação");


            }
        }
    }
}
