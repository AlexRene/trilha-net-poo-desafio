namespace DesafioPOO.Models
{
    /// <summary>
    /// Classe que representa um smartphone Nokia
    /// </summary>
    public class Nokia : Smartphone
    {
        /// <summary>
        /// Construtor da classe Nokia
        /// </summary>
        /// <param name="numero">Número do telefone</param>
        /// <param name="modelo">Modelo do Nokia</param>
        /// <param name="imei">IMEI do dispositivo</param>
        /// <param name="memoria">Capacidade de memória em GB</param>
        public Nokia(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        /// <summary>
        /// Implementação específica do Nokia para instalar aplicativos
        /// </summary>
        /// <param name="nomeApp">Nome do aplicativo a ser instalado</param>
        public override void InstalarAplicativo(string nomeApp)
        {
            if (string.IsNullOrWhiteSpace(nomeApp))
            {
                Console.WriteLine("Nome do aplicativo não pode ser vazio.");
                return;
            }

            Console.WriteLine($"Instalando {nomeApp} via Nokia Store...");
        }
    }
}