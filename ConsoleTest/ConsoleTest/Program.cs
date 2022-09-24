using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            LicenseKeyFormatting a = new LicenseKeyFormatting(); ;
            Console.WriteLine(a.licenseKeyFormatting("---",3));
            Console.ReadKey();
        }
    }


}
