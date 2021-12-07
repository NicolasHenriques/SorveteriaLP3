using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho {
    class Pedido {
        public List<String> pedido = new List<String>();
        public void mostrarPedidoSorvete(Sorvete s) {
            Console.WriteLine("Seu pedido: \n");
            foreach(string sabor in pedido) {
                Console.WriteLine(sabor + " ---------- R$" + s.precoSorvete);
            }
        }
        public double totalSorvete(int quantidade, Sorvete s) {
            return quantidade * s.precoSorvete; 
        }
        public void mostrarPedidoYogurte(Yogurte y) {
            Console.WriteLine("Seu pedido: \n");
            foreach(string sabor in pedido) {
                Console.WriteLine(sabor + " ---------- R$" + y.precoYogurte);
            }
        }
        public double totalYogurte(int quantidade, Yogurte y) {
            return quantidade * y.precoYogurte; 
        }
    }
}