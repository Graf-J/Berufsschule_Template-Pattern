using System;
using System.Collections.Generic;

namespace Berufsschule_Template_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Importer> importerList = new List<Importer>() { new XmlImporter(), new JsonImporter(), new APIImporter() };

            foreach (Importer importer in importerList)
            {
                importer.ExecuteImport();
                Console.WriteLine("---------------------------------------");
            }

            Console.ReadLine();
        }
    }
}
