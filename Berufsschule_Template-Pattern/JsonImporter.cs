using System;
using System.Collections.Generic;
using System.Text;

namespace Berufsschule_Template_Pattern
{
    class JsonImporter : Importer
    {
        protected override void CloseSource()
        {
            Console.WriteLine("Closing JSON");
        }

        protected override void OpenSource()
        {
            Console.WriteLine("Opening JSON");
        }

        protected override void ProcessSource()
        {
            Console.WriteLine("Processing JSON");
        }

        protected override void ReadSource()
        {
            Console.WriteLine("Reading JSON");
        }
    }
}
