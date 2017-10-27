using System;
using System.IO;

namespace CadastroVendaPoo.classes
{
    /// <summary>
    /// a classe protudo possui informações sobre o cliente
    /// </summary>
    public class Produto
    {

        private int id;
        private string nomeproduto;
        private string descricao;

        private double preco;


        public Produto() { }
        /// <summary>
        /// controi o objeto produto e precisa de parametros
        /// </summary>
        /// <param name="id">Passe um int ID</param>
        /// <param name="nomeproduto">Passe uma string Nomde do produto</param>
        /// <param name="descricao">Passe uma string Descrição do produto</param>
        /// <param name="preco">Passe um double preço do produto</param>
        public Produto(int id, string nomeproduto, string descricao, double preco)
        {
            this.id = id;
            this.nomeproduto = nomeproduto;
            this.descricao = descricao;
            this.preco = preco;
        }
        public int Id { get { return id; } set { id = value; } }
        public string Nomeproduto { get { return nomeproduto; } set { nomeproduto = value; } }
        public string Descricao { get { return descricao; } set { descricao = value; } }
        public double Preco { get { return preco; } set { preco = value; } }




    }



}