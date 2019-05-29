using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, endereco, telefone = "";

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu Endereço: ");
            endereco = Console.ReadLine();
            Console.Write("Digite seu Telefone: ");
            telefone = Console.ReadLine();

            Console.WriteLine("seu nome é: {0}, e você mora em: {1}, com o telefone: {2}", nome, endereco, telefone); 

                

        }
    }
}
