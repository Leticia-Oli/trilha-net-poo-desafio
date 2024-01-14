using System.Dynamic;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        
        private string modelo { get; set;}
        private string imei { get; set;}
        private int memoria { get; set; }

        public Smartphone(string numero)
        {
            Numero = numero;
            imei = "";
            modelo = "";
            memoria = 0;
            
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
    }
}