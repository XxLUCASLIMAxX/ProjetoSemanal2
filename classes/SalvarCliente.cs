using System;
using System.IO;

namespace CadastroVendaPoo.classes
{

    public class SalvarCliente
    {


        public string Salvar(Cliente cl)
        {
            string msg = "";
            StreamWriter escrever = null;
            try
            {
                if (cpfValido(cl.Cpf))
                {
                    escrever = new StreamWriter("cadCliente.csv", true);
                    escrever.WriteLine(cl.Nome + ";" + cl.Email + ";" + cl.Cpf + ";" + cl.Datacadastro);
                    msg = "CLIENTE SALVO COM SUCESSO";


                }
                else
                {
                    msg = "CPF INVALIDO";
                }

            }
            catch (Exception e)
            {
                msg = "Erro ao tentar gravar o arquivo " + e.Message;

            }
            finally
            {
                escrever.Close();
            }

            bool cpfValido(string cpf)
            {
                bool rs = true;
                string cpfCalculo = "";

                int[] v1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] v2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                int resultado = 0;
                int resto = 0;


                cpfCalculo = cl.Cpf.Substring(0, 9);

                for (int i = 0; i < cpfCalculo.Length; i++)
                {
                    resultado += Int16.Parse(cpfCalculo[i].ToString()) * v1[i];
                }

                resto = resultado % 11;
                if (resto < 2)
                    cpfCalculo += "0";
                else
                    cpfCalculo += (11 - resto).ToString();

                resultado = 0;

                for (int i = 0; i < cpfCalculo.Length; i++)
                {
                    resultado += Int16.Parse(cpfCalculo[i].ToString()) * v2[i];
                }

                resto = resultado % 11;
                if (resto < 2)
                    cpfCalculo += "0";
                else
                    cpfCalculo += (11 - resto).ToString();

                if (cl.Cpf != cpfCalculo)
                    rs = false;



                return rs;
            }





            return msg;


        }
    }
}