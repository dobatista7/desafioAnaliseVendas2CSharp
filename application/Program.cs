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

            // Leitura do arquivo e processamento dos dados
            var sales = File.ReadAllLines(path) // Lê todas as linhas do arquivo
                            .Skip(1) // Ignora o cabeçalho
                            .Select(line => line.Split(',')) // Divide cada linha em campos
                            .Select(fields => new
                            {
                                Seller = fields[2],
                                Total = double.Parse(fields[4])
                            }) // Mapeia para objetos anônimos
                            .ToList();
            // Agregação dos dados com LINQ
            var totalSalesBySeller = sales
                .GroupBy(sale => sale.Seller) // Agrupa pelo nome do vendedor
                .Select(group => new
                {
                    Seller = group.Key,
                    Total = group.Sum(sale => sale.Total)
                }) // Calcula o total de vendas por vendedor
                .OrderBy(result => result.Seller) // Ordena os resultados por nome do vendedor
                .ToList();

            Console.WriteLine("Total de vendas por vendedor:");
            // Exibe os resultados
            foreach (var entry in totalSalesBySeller)
            {
                Console.WriteLine($"{entry.Seller} - R$ {entry.Total:F2}");
            }

        }
    }
}
