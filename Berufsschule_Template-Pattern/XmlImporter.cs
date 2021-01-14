using System;
using System.Collections.Generic;
using System.Text;

namespace Berufsschule_Template_Pattern
{
    class XmlImporter : Importer
    {
        protected override void CloseSource()
        {
            Console.WriteLine("Closing XML");
        }

        protected override void OpenSource()
        {
            Console.WriteLine("Opening XML");
        }

        protected override void ProcessSource()
        {
            Console.WriteLine("Processing XML");
        }

        protected override void ReadSource()
        {
            Console.WriteLine("Reading XML");
        }
    }
}
