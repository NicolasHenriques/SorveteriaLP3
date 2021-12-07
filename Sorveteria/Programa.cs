using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class Programa
    {
        static void Main(string[] args)
        {
            int auxx = 1;
            do {
                Console.Clear();
                Console.WriteLine("Olá! Gostaria de um sorvete ou yogurte, amigo?");
                string escolha = Console.ReadLine();

                if(escolha == "Sorvete" || escolha == "sorvete") {
                    Console.Clear();
                    Sorvete s = new Sorvete();
                    s.mostrarSabores();
                    Pedido pe = new Pedido();

                    int aux = 1;
                    do {
                        Console.WriteLine("\nEscreva o sabor desejado.");
                        string sabor = Console.ReadLine();

                        if(s.saborSorvete.Contains(sabor)){
                            pe.pedido.Add(sabor);

                            Console.WriteLine("\nDeseja inserir outro sabor?\n1 - Sim         0 - Não");
                            aux = int.Parse(Console.ReadLine());
                        }
                        else {
                            Console.WriteLine(sabor + " não está na lista :(");
                        }
                    } while (aux != 0);
                    
                    Console.Clear();
                    pe.mostrarPedidoSorvete(s);
                    Console.WriteLine("TOTAL ---------- R$" + pe.totalSorvete(pe.pedido.Count(), s));
                    auxx = 0;
                }

                else if (escolha == "Yogurte" || escolha == "yogurte") {
                    Console.Clear();
                    Yogurte y = new Yogurte();
                    y.mostrarSabores();
                    Pedido pe = new Pedido();

                    int aux = 1;
                    do {
                        Console.WriteLine("\nEscreva o sabor desejado.");
                        string sabor = Console.ReadLine();

                        if(y.saborYogurte.Contains(sabor)){
                            pe.pedido.Add(sabor);

                            Console.WriteLine("\nDeseja inserir outro sabor?\n1 - Sim         0 - Não");
                            aux = int.Parse(Console.ReadLine());
                        }
                        else {
                            Console.WriteLine("Insira um sabor da lista.");
                        }
                    } while (aux != 0);
                    
                    Console.Clear();
                    pe.mostrarPedidoYogurte(y);
                    Console.WriteLine("TOTAL ---------- R$" + pe.totalYogurte(pe.pedido.Count(), y));
                    auxx = 0;
                }

                else {
                    Console.WriteLine("\nEscreva 'Sorvete' ou 'Yogurte' para prosseguir.");
                    Console.ReadKey();
                }
            } while (auxx != 0);

            Console.ReadKey();
        }
    }
}