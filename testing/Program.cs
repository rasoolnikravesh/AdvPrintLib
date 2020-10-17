using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvPrintLib;
namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            AdvPrint.PrintLn("hello", AdvColor.Red, AdvColor.Blue); 
        }
    }
}
