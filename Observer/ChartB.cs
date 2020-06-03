using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class ChartB : Observer
    {
        private readonly Datasource datasource;

        public ChartB(Datasource datasource)
        {
            this.datasource = datasource;
        }

        public void Update()
        {
            Console.WriteLine("ChartB Update, SubjectState:" + datasource.SubjectState);
        }
    }
}
