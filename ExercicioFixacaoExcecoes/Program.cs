using System;
using System.Globalization;
using ExercicioFixacaoExcecoes.Entities;
using ExercicioFixacaoExcecoes.Entities.Exceptions;


namespace ExercicioFixacaoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe os dados da conta: ");
                Console.Write("Número: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Saldo Inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Limite de Saque: ");
                double limiteSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(numero, nome, saldo, limiteSaque);
                account.Deposito(saldo);

                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Informe o valor para saque: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Saque(valor);

                Console.WriteLine();
                Console.WriteLine(account.ToString(), "F2", CultureInfo.InvariantCulture);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro no saque: " + e.Message);
            }
            




        }
    }
}
