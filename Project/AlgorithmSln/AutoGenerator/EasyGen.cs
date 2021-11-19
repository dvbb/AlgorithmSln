using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.AutoGenerator
{
    internal class EasyGen : GenerateBase
    {
        private CodeType _type = CodeType.Easy;

        internal EasyGen()
        {
        }

        internal EasyGen(string className,string funcName)
        {
            _className = className;
            _funcName = funcName;
            _outfolder = $@"..\..\..\..\Tests\Easy\{_className}Tests.cs";
        }

        internal void Generate()
        {
            Generate(_type);
        }
    }
}
