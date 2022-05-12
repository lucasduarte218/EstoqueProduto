using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProduto {
    class Produto {
        private string Nome;
        private double Preco;
        private int Quantidade;
        private int ID;

        public string Nome1 { get => Nome; set => Nome = value; }
        public double Preco1 { get => Preco; set => Preco = value; }
        public int Quantidade1 { get => Quantidade; set => Quantidade = value; }

        public int ID1 { get => ID; set => ID = value; }

        public Produto(string nome, double preco, int quantidade, int id) {
            Nome1 = nome;
            Preco1 = preco;
            Quantidade1 = quantidade;
            ID1 = id;
        }

        public double ValorTotalEmEstoque() {
            return 0.0;
        }
         
        public void AdicionarProdutos( int quantidade) {

        }
        public void RemoverProdutos(int quantidade) {

        }
    }
}
