using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDeskWrapLib;

namespace ServiceDeskWrapLib.TestCol
{
    class Program
    {
        static void Main(string[] args)
        {
            var caselist = new ServiceDeskWrapper().GetUnassignedCaseList();
            Console.WriteLine(caselist.Count);
            Console.ReadKey();
        }
    }
}
