using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaSwitch {
        public static void Executar() {
            Console.WriteLine("Avalie o meu atendimento com uma nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota) {
                // Então, se a nota for 0, cai no case 0, se a nota for 1 ou 2, cai no case 1 ou 2 e assim sucessivamente.
                case 0:
                    Console.WriteLine("Péssimo");
                    break; // a palavra break significa que ele vai entrar no case 0, executa a sentença de código "péssimo", e logo depois
                           // de executar a sentença ele chama o break, e este faz com que ele saia da estrutura switch, e vá para a linha seguinte
                           // para imprimir "fim".
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4: {
                        Console.WriteLine("Bom");
                        break;
                    }
                    // pode fazer abrindo as chaves dessa forma também, formando um bloco de código.
                case 5:
                    Console.WriteLine("Ótimo");
                    Console.WriteLine("Parabéns!");
                    break;
                    // pode colocar duas sentenças de código também.
                default:
                    Console.WriteLine("Nota inválida");
                    break;

            }

            Console.WriteLine("Obrigado por responder!");
        }
    }
}
