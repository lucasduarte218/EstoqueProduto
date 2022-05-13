using System;
using System.Collections.Generic;
using System.IO;

namespace EstoqueProduto {
    class Program {

        static List<Produto> ListaProdutos;
        static int ID;
        static void Main(string[] args) {
            ListaProdutos = new List<Produto>();
            Menu();
        }
        static void Menu() {
            int sair = 0;
            int opcao;
            while (sair == 0) {
                
                Console.Clear();
                Console.WriteLine("Escolha opcao desejada");
                Console.WriteLine("1)Criar Produto\n2)Listar Produtos\n3)Excluir Produtos\n4)Editar Produtos");
                opcao = int.Parse(Console.ReadLine().Trim());
                switch (opcao) {
                    case 1:
                        // Criar produto
                        CriarProduto();  
                        break;
                    case 2:
                        // Listar produtos
                        if ( ListaProdutos.Count != 0) {
                            ListarProdutos();
                            Console.WriteLine("pressione uma tecla para continuar\n");
                            Console.ReadLine();
                        }
                        else {
                            Console.WriteLine("Não há produtos!\npressione uma tecla para continuar\n ");
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        //Excluir produto
                        RemoverProduto();
                        break;
                    case 4:
                        EditarProduto();
                        // editar produto
                        break;
                    case 5:
                        // Adicionar estoque de produtos
                        break;
                    case 6:
                        // Remover estoque de produtos
                        break;
                    case 7:
                        // Sair
                        sair = 1;
                        break;
                    default:
                        // opcao invalida,
                        Console.WriteLine("Opcao invalida, pressione qualquer tecla para continuar");
                        Console.ReadLine();
                        break;
                }
            }
        }
        static void CriarProduto() {
            Console.Clear();
            Console.WriteLine("Nome do produto:");
            string nome = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("Preço do produto:");
            double preco = double.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Quantidade do produto:");
            int quantidade = int.Parse(Console.ReadLine().Trim());
            ID++;
            Produto NovoProduto = new Produto(nome, preco, quantidade,ID);
            ListaProdutos.Add(NovoProduto);
            Console.WriteLine("Produto {0} adicionado com sucesso! \npressione uma tecla para continuar\n",nome);
            Console.ReadLine();
        }

        static void ListarProdutos() {
            Console.Clear();
            Console.WriteLine("  Nome   Preço   Quantidade");
            for (int i = 0; i < ListaProdutos.Count; i++) {
                Console.WriteLine("{0}) {1} {2}R$  {3} ",i,ListaProdutos[i].Nome1,ListaProdutos[i].Preco1,ListaProdutos[i].Quantidade1 );  
            }
        }
        static void RemoverProduto() {
            if (ListaProdutos.Count != 0)
            {
                ListarProdutos();
                Console.WriteLine("Selecione o produto que deseja remover:");
                int opcao = int.Parse(Console.ReadLine().Trim());
                if (opcao <= ListaProdutos.Count)
                {
                    ListaProdutos[opcao] = null;
                    ListaProdutos.RemoveAt(opcao);
                }   
                else
                {
                    Console.WriteLine("Opcao invalida\npressione uma tecla para continuar\n");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Não há produtos!\npressione uma tecla para continuar\n ");
                
                Console.ReadLine();
            }
        }

        static void EditarProduto()
        {
            if (ListaProdutos.Count != 0)
            {
                ListarProdutos();
                Console.WriteLine("Selecione o produto que deseja editar:");
                int produtoID = int.Parse(Console.ReadLine().Trim());
                if (produtoID <= ListaProdutos.Count)
                {
                    Console.WriteLine("Escolha opcao desejada\n");
                    Console.WriteLine(" \n1)Editar Nome\n2)Editar Preço\n3)Sair");
                    int opcao = int.Parse(Console.ReadLine().Trim());
                    switch (opcao)
                    {
                        case 1:
                            // Editar Nome
                            Console.WriteLine("Nome atual = " + ListaProdutos[produtoID].Nome1);
                            Console.WriteLine("=========================================");
                            Console.Write("Digite o novo nome:");
                            ListaProdutos[produtoID].Nome1 = Console.ReadLine().Trim().ToLower();
                            Console.WriteLine("nome alterado com sucesso!\npressione qualquer tecla para continuar\n");
                            Console.ReadLine();
                            break;
                        case 2:
                            // Editar preço
                            Console.WriteLine("Preço atual = " + ListaProdutos[produtoID].Preco1);
                            Console.WriteLine("=========================================");
                            Console.WriteLine("Digite o novo Preço:");
                            ListaProdutos[produtoID].Preco1 = double.Parse(Console.ReadLine().Trim());
                            Console.WriteLine("Preço alterado com sucesso! \npressione qualquer tecla para continuar\n");
                            Console.ReadLine();

                            break;
                        case 3:
                            // Sair
                            break;

                        default:
                            // opcao invalida,
                            Console.WriteLine("Opcao invalida! \npressione qualquer tecla para continuar\n");
                            Console.ReadLine();
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Opcao invalida, pressione qualquer tecla para continuar");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Não há produtos!\npressione uma tecla para continuar\n ");
                Console.ReadLine();
            }
        }
    }
}
