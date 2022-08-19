using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaIfElseIf {
        public static void Executar() {
            
            Console.WriteLine("Digite a nota do aluno: ");

            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9.0) {
                Console.WriteLine("Quadro de Honra!");
                // Ou seja, se a nota for maior ou igual a nove executa-se o quadro de honra. Se não for, cai para a estrutura abaixo.
            } else if (nota >= 7.0 && nota < 9.0) {
                Console.WriteLine("Aprovado!");
                // Se a nota caiu nessa estrutura, e está entre 7 e 9 cai no aprovado.
            } else if (nota >= 5.0 && nota < 7.0) {
                Console.WriteLine("Recuperação");
            } else {
                Console.WriteLine("Te vejo na próxima...");
            }

            Console.WriteLine("Fim!!");


        }
    }
}
