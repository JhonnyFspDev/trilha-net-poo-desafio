namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        protected List<string> ListaAplicativos = [];

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;    
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void AtenderLigacao()
        {
            Console.WriteLine("Ligação Atendida");
        }

        public void RecusarLigacao()
        {
            Console.WriteLine("Ligação recusada");
        }

        public abstract void InstalarAplicativo(string nomeApp);
        public void ExibirAplicativos()
        {
            if(ListaAplicativos.Count() == 0)
            {
                Console.WriteLine("Ainda não foram instalador aplicativos");
            }
            else
            {
                Console.WriteLine("- Aplicativos intalados -");
                foreach(var lista in ListaAplicativos)
                {
                    Console.WriteLine(" - " + lista);
                }
            }
            
        }
    }
}