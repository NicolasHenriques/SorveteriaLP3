using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    class Sorvete : Produto
    {
        private double preco = 5.50;
        public List<String> saborSorvete = new List<String>();
        public double precoSorvete {
            get { return this.preco; }
            set {
                this.preco = value;
            }
        }
        public Sorvete() {
            saborSorvete.Add("Baunilha");
            saborSorvete.Add("Morango");
            saborSorvete.Add("Chocolate");
            saborSorvete.Add("Uva");
            saborSorvete.Add("Limão");
        }
        public override void mostrarSabores() {
            Console.WriteLine("SABORES DE SORVETE: \n");
            Console.WriteLine("------------------------");
            foreach(string sabor in saborSorvete) {
                Console.WriteLine(sabor);
            }
            Console.WriteLine("------------------------");
        }
    }
}
