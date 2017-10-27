using System;
using System.IO;

namespace CadastroVendaPoo.classes
{

    /// <summary>
    /// A classe cliente possui informações sobre o cliente
    /// </summary>
    public class Cliente
    {
        private string nome;
        private string email;
        private string cpf;

        private DateTime datacadastro;

        /// <summary>
        /// constroi o objeto cliente
        /// </summary>
        public Cliente()
        {
        }
        /// <summary>
        /// Constroi o objeto cliente e necessita de parametros
        /// </summary>
        /// <param name="nome">String</param>
        /// <param name="email">String</param>
        /// <param name="cpf">String</param>
        /// <param name="datacadastro">DateTime</param>
        public Cliente(string nome, string email, string cpf, DateTime datacadastro)
        {
            this.nome = nome;
            this.email = email;
            this.cpf = cpf;
            this.datacadastro = datacadastro;

        }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Cpf { get { return cpf; } set { cpf = value; } }
        public DateTime Datacadastro { get { return datacadastro; } set { datacadastro = value; } }

      



    }

}