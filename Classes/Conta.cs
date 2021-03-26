using System;

namespace DIO.Bank
{
    public class Conta
    {
        //declarando as propriedades da conta
        private string Nome { get; set; }

        private double Credito { get; set; }

        private double Saldo { get; set; }

        private TipoConta TipoConta { get; set; }

        //Metodo construtor

        public Conta(TipoConta tipoConta, double credito, double saldo, string nome) {

            this.TipoConta = tipoConta;
            this.Nome = nome;
            this.Saldo = saldo;
            this.Credito = credito;

        }

        public bool Sacar(double valorSaque){
            //validação da operação sacar
            if (this.Saldo - valorSaque < (this.Credito * -1)){
                Console.WriteLine("Saldo indisponivel");
                return false;
            }
            this.Saldo -= valorSaque;
            Console.WriteLine("O saldo da conta de {0} é {1} ", this.Nome, this.Saldo);
                return true;
        }

        public void Depositar(double valorDeposito){
            //Valor é adicionado a conta
            this.Saldo += valorDeposito;
            Console.WriteLine("O saldo da conta de {0} é {1} ", this.Nome, this.Saldo);
        }

        public void Transferir(double valorTransferencia, Conta contaDestino){
            // para transferir a gente usar o metodo SACAR para validar se o valor pode ser transferido
            // e caso sim usamos o metodo DEPOSITAR para o dinheiro ser depositado na conta
            if (this.Sacar(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);
            }
        }
             public override string ToString()
            {
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Credito " + this.Credito + " | ";
            return retorno;
        }



     }
}
