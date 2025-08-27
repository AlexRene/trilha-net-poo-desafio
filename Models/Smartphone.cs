namespace DesafioPOO.Models
{
    /// <summary>
    /// Classe abstrata que representa um smartphone genérico
    /// </summary>
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public int Memoria { get; set; }

        /// <summary>
        /// Construtor da classe Smartphone
        /// </summary>
        /// <param name="numero">Número do telefone</param>
        /// <param name="modelo">Modelo do smartphone</param>
        /// <param name="imei">IMEI do dispositivo</param>
        /// <param name="memoria">Capacidade de memória em GB</param>
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        /// <summary>
        /// Realiza uma ligação
        /// </summary>
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        /// <summary>
        /// Recebe uma ligação
        /// </summary>
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        /// <summary>
        /// Método abstrato para instalar aplicativo
        /// Deve ser implementado pelas classes filhas
        /// </summary>
        /// <param name="nomeApp">Nome do aplicativo a ser instalado</param>
        public abstract void InstalarAplicativo(string nomeApp);
    }
}