using System.Globalization;

namespace DesafioAnaliseVendas2CSharp.application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configuração para usar ponto como separador decimal
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Entre o caminho do arquivo: ");
            string path = Console.ReadLine(); // Leitura do caminho do arquivo pelo usuário
            Console.WriteLine();
        }
    }
}
