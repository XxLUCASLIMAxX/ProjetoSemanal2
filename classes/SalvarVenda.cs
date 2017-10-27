using System;
using System.IO;

namespace CadastroVendaPoo.classes{
    public class SalvarVenda{

        public string Salvar(Venda v){
            string msg="";
             StreamWriter escrever = null;
            try
            {
                escrever = new StreamWriter("cadVenda.csv", true);
                escrever.WriteLine(v.Cpf+ ";" + v.Id + ";" + v.Datavenda);
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