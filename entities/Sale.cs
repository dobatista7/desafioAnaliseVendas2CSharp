using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAnaliseVendas2CSharp.entities
{
    internal class Sale
    {
        public int Month { get; private set; }
        public int Year { get; private set; }
        public string Seller { get; private set; }
        public int Items { get; private set; }
        public double Total { get; private set; }

        public Sale(int month, int year, string seller, int items, double total)
        {
            Month = month;
            Year = year;
            Seller = seller;
            Items = items;
            Total = total;
        }

        // Método para calcular o preço médio por item
        public double AveragePrice()
        {
            return Items == 0 ? 0.0 : Total / Items;
        }

        public override string ToString()
        {
            return $"Sale{{Month={Month}, Year={Year}, Seller='{Seller}', Items={Items}, Total={Total}, AveragePrice={AveragePrice():F2}}}";
        }

    }
}
