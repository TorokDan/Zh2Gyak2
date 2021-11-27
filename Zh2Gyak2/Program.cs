using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh2Gyak2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHandler.srcPath = "MONITORING.DAT";
            FileHandler.dstPath = "ANALYSIS.RESULT";
            Analyzer analyzer = new Analyzer();
            analyzer.Analysis();
            ;
        }
    }
}
