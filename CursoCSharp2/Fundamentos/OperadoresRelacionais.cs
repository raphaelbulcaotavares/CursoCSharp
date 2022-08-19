using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresRelacionais {
        public static void Executar () {
            //double nota = 6.0;
            Console.Write("Digite a nota?: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota inválida? {0}", nota > 10.0); // então, se a nota for maior que 10, quer dizer que foi digitada uma nota inválida
            Console.WriteLine("Nota inválida? {0}", nota < 0.0);
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            // igual 2 vezes significa igualdade e não "recebe" como o único igual
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            // != significa "diferente"
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);
            // maior igual
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);
            // menor igual


        }
    }
}
