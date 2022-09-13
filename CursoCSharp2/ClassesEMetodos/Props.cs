using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public class CarroOpcional {

        double desconto = 0.1; // por padrão, o C# deixa "private".

        string nome;
        public string Nome {
            get {
                return "Opcional: " + nome;
            }
            set {
                nome = value;
            }
        }

        // Propriedade autoimplementada
        public double Preco { get; set; }
        
        // Somente leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco); //Lambda (vou ver mais na frente)
            // get {
            //      return Preco - (desconto * Preco);
            // }
        }

    }


    class Props {
        public static void Executar () {

        }
    }
}
