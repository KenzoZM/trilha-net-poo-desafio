namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memorio) : base(numero, modelo, imei, memorio)
        {

        }

        public override void InstalarAplicativo(string nome)
        {
            System.Console.WriteLine($"Instalando app {nome} no Nokia");
        }
    }
}