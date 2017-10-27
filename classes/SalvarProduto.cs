using System;
using System.IO;

namespace CadastroVendaPoo.classes
{

    public class SalvarProduto
    {

        public string salvar(Produto pr)
        {
            string msg = "";
            StreamWriter escrever = null;
            try
            {
                escrever = new StreamWriter("cadProduto.csv", true);
                escrever.WriteLine(pr.Id + ";" + pr.Nomeproduto + ";" + pr.Descricao + ";" + pr.Preco);
                msg = "PRODUTO SALVO COM SUCESSO";


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