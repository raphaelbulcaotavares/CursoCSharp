using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaForEach {
        public static void Executar () {
            // O primeiro exemplo do foreach é percorrer todas as letras de uma palavra.
            var palavra = "Valentina!";
            
            foreach (var letra in palavra) {
                Console.WriteLine(letra);
            }
            
            var alunos = new string[] { "Ana", "Bia", "Carlos" };

            foreach (string aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }

    }
}
