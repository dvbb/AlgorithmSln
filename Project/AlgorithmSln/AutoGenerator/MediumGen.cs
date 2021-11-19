using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.AutoGenerator
{
    internal class MediumGen : GenerateBase
    {
        private CodeType _type = CodeType.Medium;

        internal MediumGen()
        {
        }

        internal MediumGen(string className, string funcName)
        {
            _className = className;
            _funcName = funcName;
            _outfolder = $@"..\..\..\..\Tests\Medium\{_className}Tests.cs";
        }

        internal void Generate()
        {
            Generate(_type);
        }
    }
}
