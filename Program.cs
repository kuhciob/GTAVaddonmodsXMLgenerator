using GTAVmodsXMLgenerator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GTAVmodeADDHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Mods = GTAVmodsXMLGenerator.ConsoleRead();
            string result = GTAVmodsXMLGenerator.GetXMLmurkupToString(Mods);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
