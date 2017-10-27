using System;
using CadastroVendaPoo.classes;

namespace CadastroVendaPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        static void cadProd()
        {
            Produto pr = new Produto();
            SalvarProduto sv = new SalvarProduto();
            Console.Write("Digite o id do produto: ");
            pr.Id = Int32.Parse(Console.ReadLine());
            Console.Write("Digite o nome do produto: ");
            pr.Nomeproduto = Console.ReadLine();
            Console.Write("Digite a descrição do produto");
            pr.Descricao = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            pr.Preco=double.Parse(Console.ReadLine());
            sv.salvar(pr);


        }
        static void cadCli()
        {

            Cliente cl = new Cliente();
            SalvarCliente sv = new SalvarCliente();
            Console.Write("Digite o nome do cliente: ");
            cl.Nome = Console.ReadLine();
            Console.Write("Digite o email do cliente: ");
            cl.Email = Console.ReadLine();
            Console.Write("Digite o cpf do cliente: ");
            cl.Cpf = Console.ReadLine();
            cl.Datacadastro = DateTime.Now.Date;

            sv.Salvar(cl);
        }











        static void menu()
        {
            int aux = 0;
            while (aux != 9)
            {
                Console.WriteLine("Selecione :");
                Console.WriteLine("1 - Cadastro de Cliente");
                Console.WriteLine("2 - Cadastro de Produto ");
                Console.WriteLine("3 - Realizar Venda");
                Console.WriteLine("4 - Extrato do Cliente");
                Console.WriteLine("9 - Sair");
                aux = Int32.Parse(Console.ReadLine());

                switch (aux)
                {
                    case 1: cadCli(); break;
                    case 2: cadProd(); break;

                    case 9: Console.Clear();Console.WriteLine("TCHAU"); break;
                    default: Console.WriteLine("Numero incorreto "); break;
                }

            }
        }
    }
}

