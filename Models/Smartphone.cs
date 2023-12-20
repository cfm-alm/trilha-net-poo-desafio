namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string numero { get; set; }
        public string modelo { get; set; }
        public string imei { get; set; }
        public int memoria { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero2)
        {
            numero = numero2;
            // TODO: Passar os parâmetros do construtor para as propriedades
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
