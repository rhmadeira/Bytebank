﻿using Bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Contas
{
    public class ContaCorrente
    {
        private int numero_agencia;
        private double saldo = 10;



        public int Numero_agencia
        {
            get
            {
                return this.numero_agencia;
            }
            private set 
            { 
                if(value > 0)
                this.numero_agencia = value;
            }
        }
        public static int TotalContasCriadas { get; private set; }
        public string Conta { get; set; }

        

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (valor > saldo)
            {

                Console.WriteLine("Voce não possui saldo suficiente");
                Console.WriteLine("Seu saldo é de: " + saldo);
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                Console.WriteLine("Transferencia realizada com sucesso");
                return true;
            }
        }

        public void SetSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                this.saldo += valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public ContaCorrente(int numero_agencia, string conta)
        {
            Numero_agencia = numero_agencia;
            Conta = conta;
            TotalContasCriadas++;
        }
        public Cliente Titular { get; set; }
    }
}
