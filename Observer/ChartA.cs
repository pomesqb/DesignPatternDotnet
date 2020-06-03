using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class ChartA : Observer
    {
        private readonly Datasource datasource;

        public ChartA(Datasource datasource)
        {
            this.datasource = datasource;
        }

        public void Update()
        {
            Console.WriteLine("ChartA Update,SubjectState:" + datasource.SubjectState);
        }
    }
}
