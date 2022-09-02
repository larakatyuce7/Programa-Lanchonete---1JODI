using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lanches_burlis
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, opcaolanches;
            Double subtotal = 0;
            do
            {
                Console.WriteLine("lanches burlis");
                Console.WriteLine("--------------");
                Console.WriteLine("");
                Console.WriteLine("1- lanches e porções");
                Console.WriteLine("2- bebidas");
                Console.WriteLine("3- combos");
                Console.WriteLine("4- finalizar");
                opcao = Convert.ToInt32(Console.ReadKey());

                if (opcao == 1)
                {
                    do
                    {
                        Console.WriteLine("novo menu");
                        Console.WriteLine("------Produto -----      -------Preço");
                        Console.WriteLine("1- hamburguer simples ---------- 5.00");
                        Console.WriteLine("2- Hamburguer duplo ----------- 7,50 ");
                        Console.WriteLine("3- Hamburguer triplo---------- 10,00 ");
                        Console.WriteLine("4- vegano -------------------- 12,00 ");
                        Console.WriteLine("5- duplo com bacon ----------- 12,00 ");
                        Console.WriteLine("6- duplo com cheddar --------- 14,00 ");
                        Console.WriteLine("7- Triplo com bacon ---------- 15,00 ");
                        Console.WriteLine("8- Triplo com cheddar -------- 16,00 ");
                        Console.WriteLine("9- porção de batata ---------- 20,00 ");
                        Console.WriteLine("0- Sair ---------------------------- ");

                        opcaolanches = Convert.ToInt32(Console.ReadLine());


                        if (opcaolanches == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("você selecionou hamburguer simples" +
                                "Simples seu subtotal foi de: " + subtotal);
                            Console.ReadKey();
                        }


                    } while (opcaolanches != 0);

                    Console.Clear();
                    Console.WriteLine("você selecionou hamburguer duplo" +
                    "Simples seu subtotal foi de: " + subtotal);
                    Console.ReadKey();

                } while (opcao != 4) ;

                if (opcao == 2)
                {
                    do
                    {
                        Console.WriteLine("novo menu");
                        Console.WriteLine("------Produto -----      -------Preço");
                        Console.WriteLine("1- Refrigerante Lata ---------- 4.00");
                        Console.WriteLine("2- Refrigerante 600ml -------- 7,50 ");
                        Console.WriteLine("3- Refrigerante 2l----------- 10,00 ");
                        Console.WriteLine("0- Sair --------------------------- ");

                        opcaolanches = Convert.ToInt32(Console.ReadLine());



                    } while ();
                    if (opcao == 3)
                    {
                        do
                        {
                            Console.WriteLine("novo menu");
                            Console.WriteLine("------Produto -----      -----------Preço");
                            Console.WriteLine("1- Combo Infantil------------------ 10,00");
                            Console.WriteLine("2- Combo Duplo-------------------- 15,00 ");
                            Console.WriteLine("3- Combo Duplo Cheddar/Bacon------ 22,00 ");
                            Console.WriteLine("3- Combo Triplo Cheddar/Bacon----- 28,00 ");
                            Console.WriteLine("0- Sair -------------------------------- ");

                            opcaolanches = Convert.ToInt32(Console.ReadLine());




                        } while ();
                    }
                }
            