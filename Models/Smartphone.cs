namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Models, IMEI;
        protected int Memoria;
         
        public Smartphone(string Numero, string Models, string IMEI, int Memoria)
        {
            this.Numero = Numero;
            this.Models = Models;
            this.IMEI = IMEI;
            this.Memoria = Memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
        public abstract void DadosSmartphone();
    }
}