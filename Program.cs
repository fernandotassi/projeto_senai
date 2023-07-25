using System;
using System.Security.Cryptography;

namespace primeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            float valPag;

            Console.Write("Informar Nome: ");
            String nome = Console.ReadLine();
            Console.Write("Informar Endereço: ");
            String endereco = Console.ReadLine();

           Console.Write("Física(f) ou Jurídica(j): ");
           String tipo = Console.ReadLine();
           if(tipo == "f")
           {
                PessoaFisica pf = new PessoaFisica();
                pf.nome = nome;
                pf.endereco = endereco;
                Console.Write("Informar cpf: ");
                pf.cpf = Console.ReadLine();
                Console.Write("Informar rg: ");
                pf.rg = Console.ReadLine();
                Console.Write("Informar valor da compra: ");
                valPag = float.Parse(Console.ReadLine());
                pf.pagarImposto(valPag);
                Console.WriteLine("----Pessoa Fisíca----");
                Console.WriteLine("nome ..........: " + pf.nome);
                Console.WriteLine("endereço ......: " + pf.endereco);
                Console.WriteLine("cpf ...........: " + pf.cpf);
                Console.WriteLine("rg ............: " + pf.rg);
                Console.WriteLine("valor da compra: " + pf.valor.ToString("C"));
                Console.WriteLine("imposto .......: " + pf.valorImposto.ToString("C"));
                Console.WriteLine("total a pagar .: " + pf.total.ToString("C"));
           }            
           
           else if(tipo == "j")
           {
               PessoaJuridica pj = new PessoaJuridica();
               pj.nome = nome;
               pj.endereco = endereco;
               Console.Write("Informar cnpj: ");
               pj.cnpj = Console.ReadLine();
               Console.Write("Informar ie :");
               pj.ie = Console.ReadLine();
               Console.Write("Informar valor da compra: ");
               valPag = float.Parse(Console.ReadLine());
               pj.pagarImposto(valPag);
               Console.WriteLine("----Pessoa Juridíca----");
               Console.WriteLine("nome ..........: " + pj.nome);
               Console.WriteLine("endereço ......: " + pj.endereco);
               Console.WriteLine("cnpj ..........: " + pj.cnpj);
               Console.WriteLine("ie ............: " + pj.ie);
               Console.WriteLine("valor da compra: " + pj.valor.ToString("C"));
               Console.WriteLine("imposto .......: " + pj.valorImposto.ToString("C"));
               Console.WriteLine("total a pagar .: " + pj.total.ToString("C"));
           }                   
        }
    }
}
