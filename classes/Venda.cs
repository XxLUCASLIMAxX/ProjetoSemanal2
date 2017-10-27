using System;
using System.IO;

namespace CadastroVendaPoo.classes
{

    public class Venda
    {
        private string cpf;
        private int id;
        private DateTime datavenda;

        public Venda() { }

        public Venda(string cpf, int id, DateTime datavenda)
        {
            this.cpf = cpf;
            this.id = id;
            this.datavenda = datavenda;
        }

        public string Cpf { get { return cpf; } set { cpf = value; } }
        public int Id { get { return id; } set { id = value; } }


        public DateTime Datavenda { get { return datavenda; } set { datavenda = value; } }


         public string Salvar()
        {
            string msg = "";
            StreamWriter escrever = null;
            try
            {
                escrever = new StreamWriter("venda.csv", true);
                escrever.WriteLine(cpf+ ";" + id + ";" + datavenda);
                msg = "ARQUIVO SALVO COM SUCESSO";


            }
            catch (Exception e)
            {
                msg = "Erro ao tentar manipular o arquivo " + e.Message;

            }
            finally
            {
                escrever.Close();
            }


            return msg;
        }

    }
}