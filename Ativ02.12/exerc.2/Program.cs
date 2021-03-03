using System;
using exerc._2.classe;
namespace exerc._2
{
    class Program
    {
        static void Main(string[] args)
        {
            celular celular = new celular();

            Console.WriteLine("");

            Console.WriteLine("Deseja ligar o celular? s/n");
            string resposta = Console.ReadLine();
            if (resposta == "s")
            {
               Console.WriteLine("Deseja usar qual modelo de celular?");
               celular.modelo = Console.ReadLine();

               Console.WriteLine("");
            }
            else{
                Console.WriteLine("Você não pode executar nenhuma ação se seu celular estiver desligado!");
            }
        }
    }
}
