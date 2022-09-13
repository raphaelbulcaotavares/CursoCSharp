using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos 
{
    public class Moto {
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        // 1º construtor
        public Moto(string marca, string modelo, uint cilindrada) {
            Marca = marca; 
            Modelo = modelo;
            Cilindrada = cilindrada;
        }

        // 2ª construtor (padrão)
        public Moto () {

        }

        public string GetMarca() {
            return Marca;
        }
        public void SetMarca(string marca) {
            Marca = marca;
        }
        public string GetModelo() {
            return Modelo;
        }
        public void SetModelo(string modelo) {
            Modelo = modelo;
        }
        public uint GetCilindrada () {
            return Cilindrada;
        }
        public void SetCilindrada (uint cilindrada) {
            // 1ª Opção
            // if(cilindrada > 0) {
            //    Cilindrada = cilindrada;
            //}
            // 2ª opção
            //Cilindrada = Math.Abs(cilindrada);
            Cilindrada = Cilindrada;

            // O "uint" significa que obrigatoriamente o valor do inteiro tem que ser positivo. Se isso não ocorrer, ocorre um erro.
            
        }


    }

    class GetSet {
        public static void Executar () {
            
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());


            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());
           


            // O mais importante é saber que, uma vez colocando os atributos privados, você tem a possibilidade de a partir dos métodos
            // Get e Set de fazer tratamento na hora de setar o valor e na hora de devolver o valor a partir do método get.

        }
    }
}
