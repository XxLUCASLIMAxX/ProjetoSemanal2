using System;

namespace CadastroVendaPoo.classes{


public class Clientes{
    private string nome;
    private string email;
    private string cpf;

    private DateTime datacadastro;


    private Clientes(){
    }
    public Clientes(string nome,string email,string cpf,DateTime datacadastro)
    {
        this.nome=nome;
        this.email=email;
        this.cpf=cpf;
        this.datacadastro=datacadastro;
        
    }
    public string Nome { get{return nome;} set{nome=value;} }
    public string Email { get{return email;} set{email=value;} }
    public string Cpf { get{return cpf;} set{cpf=value;} }
    public DateTime Datacadastra { get{return datacadastro;} set{datacadastro=value;} }




}

}