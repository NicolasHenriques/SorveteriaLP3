using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    class Yogurte : Produto
    {
        private double preco = 3.50;
        public List<String> saborYogurte = new List<String>();

        public double precoYogurte {
            get { return this.preco; }
            set {
                this.preco = value;
            }
        }
        public Yogurte() {
            saborYogurte.Add("Morango");
            saborYogurte.Add("Frutas Vermelhas");
            saborYogurte.Add("Ameixa");
            saborYogurte.Add("Uva Verde");
            saborYogurte.Add("Laranja com Cenoura");
        }

        public override void mostrarSabores() {
            Console.WriteLine("SABORES DE YOGURTE: \n");
            Console.WriteLine("------------------------");
            foreach(string sabor in saborYogurte) {
                Console.WriteLine(sabor);
            }
            Console.WriteLine("------------------------");
        }
    }
}