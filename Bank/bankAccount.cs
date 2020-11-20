﻿using System;

namespace Bank
{
   public class bankAccount
    {
        //atributos da classe
        private readonly string m_customerName;
        private double m_balance;

        //construtores
        public bankAccount() { } //BankAccount ba = new BankAccount();
        public bankAccount(string customerName, double balance) 
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        //propriedades - Encapsulamento
        public string CustomerName
        {
            get { return m_customerName; } 
        }
        public double Balance
        {
            get { return m_balance; }
        }
        //metodos da classe

        /// <summary>
        /// Valor de Débito Adicionado
        /// </summary>
        /// <param name="amount">Quantidade de Débito</param>
        public void Debit(double amount) 
        {
            if (amount > m_balance) 
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            if (amount < 0) 
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance -= amount;
        }

        /// <summary>
        /// Valor de Crédito Adicionado
        /// </summary>
        /// <param name="amount">Quantidade de Crédito</param>
        public void Credit(double amount) 
        {
            if (amount > m_balance) 
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance += amount;
        } 


       public static void Main()
        {
            bankAccount ba = new bankAccount("Felipe", 11.99);
            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance id ${0}", ba.Balance);
        }
    }
}
