namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string Numero, string Models, string IMEI, int Memoria) : base(Numero, Models, IMEI, Memoria)
        {

        }

        public override void DadosSmartphone()
        {
            Console.WriteLine("Dados sobre o Nokia");
            Console.WriteLine($"Modelo: {Models}");
            Console.WriteLine($"IMEI: {IMEI}");
            Console.WriteLine($"Memoria: {Memoria}");

        }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no Nokia.");
        }
    }
}