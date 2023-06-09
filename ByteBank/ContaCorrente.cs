﻿using System.Threading.Channels;

namespace ByteBank
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public double saldo = 100;
        public Cliente titular;



        public void Deposito(double valor)
        {
            this.saldo += valor;
        }
        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                this.saldo = valor;
                return true;
            }
            else
                return false;

        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
                this.Sacar(valor);
            destino.Deposito(valor);
            return true;
        }
        public void MostrarDados()
        {
            Console.WriteLine("Titular: " + titular);
            Console.WriteLine("Conta: " + conta);
            Console.WriteLine("Número Agência: " + numero_agencia);
            Console.WriteLine("Saldo: "  + saldo);
        }   
    }

}