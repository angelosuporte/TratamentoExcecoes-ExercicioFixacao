using System;
using ExercicioFixacaoExcecoes.Entities.Exceptions;

namespace ExercicioFixacaoExcecoes.Entities
{
    class Account
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Account()
        {
        }

        public Account(int numero, string nome, double saldo, double limiteSaque)
        {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double valor)
        {
            Saldo =+ valor;
        }

        public void Saque(double valor)
        {
            if (Saldo < valor)
            {
                throw new DomainException("Saldo insuficiente");
            }
            if (LimiteSaque < valor)
            {
                throw new DomainException("O valor do saque excede o limite");
            }
            
                Saldo -= valor;
            
        }

        public override string ToString()
        {
            return "Novo saldo: " + Saldo;
        }

    }
}

