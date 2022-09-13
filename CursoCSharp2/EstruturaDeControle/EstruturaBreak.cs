using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class UsandoBreak {
        public static void Executar () {
            // O break não é propriamente uma estrutura de controle. Nós usamos ela junto com a estrutura de controle, pois causa um impacto na mesma.
            Random random = new Random();
            int numero = random.Next(1, 51); // lembrando que o nº 1 entra e o 51 não entra.

            Console.WriteLine("O número que queremos é {0}.", numero); 

            for (int i = 1; i <= 50; i++) {
                Console.Write("{0} é o número que queremos?", i);
                if (i == numero) {
                    Console.WriteLine("Sim!");
                    break;

                }  else {
                    Console.WriteLine("Não!");
                }


        
            }
            Console.WriteLine("Fim!");
        }

    }
}
