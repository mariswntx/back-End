namespace Sesi.Model
{

    //criando a classe
    public class ContaCorrente
    {

        //criando atributos
        private string titular { get; set; }

        private double saldo { get; set; }

        public ContaCorrente(string nomeTitular, double saldoDisponivel)
        {
            this.titular = nomeTitular;
            this.saldo = saldoDisponivel;
        }


        //criando metodos
        public void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo disponivel: {saldo}");
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo = saldo + valor;
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0)
            {
                if (valor <= saldo)
                {
                    saldo = saldo - valor;
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente");
                }
            }



        }

    }


}