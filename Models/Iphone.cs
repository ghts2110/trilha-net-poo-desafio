namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string Numero, string Models, string IMEI, int Memoria) : base(Numero, Models, IMEI, Memoria)
        {
        }

        public override void DadosSmartphone()
        {
            Console.WriteLine("Dados sobre o Iphone");
            Console.WriteLine($"Modelo: {Models}");
            Console.WriteLine($"IMEI: {IMEI}");
            Console.WriteLine($"Memoria: {Memoria}");

            throw new NotImplementedException();
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no Iphone.");
        }
    }
}