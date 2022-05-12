using System;
using System.Collections.Generic;

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
            Int32 opcao;
            while (sair == 0) {
                
                Console.Clear();
                Console.WriteLine("Escolha opcao desejada");
                Console.WriteLine("1)Criar Produto\n2)Listar Produtos\n3)Excluir Produtos\n4)Editar Produtos");
                opcao = Int32.Parse(Console.ReadLine().Trim());
                switch (opcao) {
                    case 1:
                        // Criar produto
                        CriarProduto();  
                        break;
                    case 2:
                        // Listar produtos
                        ListarProdutos();
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
                        Console.Read();
                        break;
                }
            }
        }
        static void CriarProduto() {
            Console.Clear();
            Console.WriteLine("Nome do produto:");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço do produto:");
            double preco = double.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Quantidade do produto:");
            int quantidade = int.Parse(Console.ReadLine().Trim());
            ID++;
            Produto NovoProduto = new Produto(nome, preco, quantidade,ID);
            ListaProdutos.Add(NovoProduto);
            Console.WriteLine("Produto {0} adicionado com sucesso! \npressione uma tecla para continuar\n",nome);
            Console.Read();
        }

        static void ListarProdutos() {
            Console.Clear();
            foreach (Produto produto in ListaProdutos) {
                Console.WriteLine(produto.ID1 + ") " + produto.Nome1);  
            }
        }
        static void RemoverProduto() {
            ListarProdutos();
            Console.WriteLine("Selecione o produto que deseja remover:");
            int opcao = int.Parse(Console.ReadLine().Trim());
            if(opcao <= ListaProdutos.Capacity) {
                ListaProdutos[opcao-1] = null;
                ListaProdutos.RemoveAt(opcao);
            }
            else {
                Console.WriteLine("Opcao invalida");
                Menu();
            }

        }

        static void EditarProduto() {
            ListarProdutos();
            Console.WriteLine("Selecione o produto que deseja editar:");
            int opcao = int.Parse(Console.ReadLine().Trim());
            if (opcao <= ListaProdutos.Capacity) {    
                Console.WriteLine("Escolha opcao desejada");
                Console.WriteLine("1)Editar Nome \n 2)Editar Preço \n 3)Sair");
                opcao = int.Parse(Console.ReadLine().Trim());
                switch (opcao) {
                        case 1:
                            // Editar Nome
                            Console.WriteLine("Nome atual = "+ ListaProdutos[opcao].Nome1);
                            Console.WriteLine("=========================================");
                            Console.WriteLine("Digite o novo nome:");
                            ListaProdutos[opcao].Nome1 = Console.ReadLine().Trim();
                            Console.WriteLine("nome alterado com sucesso!");
                            break;
                        case 2:
                            // Editar preço
                            Console.WriteLine("Preço atual = " + ListaProdutos[opcao].Preco1);
                            Console.WriteLine("=========================================");
                            Console.WriteLine("Digite o novo Preço:");
                            ListaProdutos[opcao].Preco1 = double.Parse(Console.ReadLine().Trim());
                            Console.WriteLine("Preço alterado com sucesso!");
                            break;
                        case 3:
                            // Sair
                            break;

                        default:
                            // opcao invalida,
                            Console.WriteLine("Opcao invalida, pressione qualquer tecla para continuar");
                            Console.Read();
                            break;
                }
                
            }
            else {
                Console.WriteLine("Opcao invalida, pressione qualquer tecla para continuar");
                Console.Read();
            }
        }
    }
}
