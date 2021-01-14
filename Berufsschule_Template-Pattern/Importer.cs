using System;
using System.Collections.Generic;
using System.Text;

namespace Berufsschule_Template_Pattern
{
    abstract class Importer
    {
        public void ExecuteImport()
        {
            OpenSource();
            ReadSource();
            ProcessSource();
            CloseSource();
        }
        abstract protected void OpenSource();
        abstract protected void ReadSource();
        abstract protected void ProcessSource();
        abstract protected void CloseSource();
    }
}
