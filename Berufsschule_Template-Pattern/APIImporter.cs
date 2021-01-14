using System;
using System.Collections.Generic;
using System.Text;

namespace Berufsschule_Template_Pattern
{
    class APIImporter : Importer
    {
        protected override void CloseSource()
        {
            Console.WriteLine("Closing API");
        }

        protected override void OpenSource()
        {
            Console.WriteLine("Opening API");
        }

        protected override void ProcessSource()
        {
            Console.WriteLine("Processing API");
        }

        protected override void ReadSource()
        {
            Console.WriteLine("Reading API");
        }
    }
}
