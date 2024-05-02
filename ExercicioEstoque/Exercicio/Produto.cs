using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Produto
    {
        private int codigo;
        private string nome;
        private int estoque;
        private double valor;

        public Produto(int codigo, string nome, int estoque, double valor)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.estoque = estoque;
            this.valor = valor;
        }

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public int getCodigo()
        {
            return codigo;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
        }
        public void setValor(double valor)
        {
            this.valor = valor;
        }
        public double getValor()
        {
            return valor;
        }
        public void entrada(int qtd)
        {
            estoque += qtd;
            Console.WriteLine("Entrada de "+qtd+" unidades.");
        }
        public void venda(int qtd)
        {
            estoque -= qtd;
            Console.WriteLine("Venda de "+qtd+" unidades.");
        }
        public void imprimir()
        {
            Console.WriteLine("Dados do produto");
            Console.WriteLine("Código: " + codigo);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Estoque: " + estoque);
            Console.WriteLine("Valor: " + valor);
        }
    }
}
