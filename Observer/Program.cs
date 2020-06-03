using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var datasource = new Datasource();
            var chartA = new ChartA(datasource);
            var chartB = new ChartB(datasource);

            datasource.Attach(chartA);
            datasource.Attach(chartB);

            datasource.ChangeData();

            Console.ReadLine();
        }
    }
}
