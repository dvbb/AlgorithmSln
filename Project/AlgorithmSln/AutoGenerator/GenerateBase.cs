using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Algorithm.AutoGenerator
{
    /// <summary>
    /// Generate Unit Test basic framework
    /// </summary>
    internal class GenerateBase
    {
        protected static IList<string> _codeWriter = new List<string>();

        protected static string[] _comments => GetComments();

        protected static Dictionary<string, string> _example => GetExample();

        protected static string _className;

        protected static string _funcName;

        protected static string _outfolder;

        internal enum CodeType
        {
            Hard,
            Medium,
            Easy,
        }

        private static string[] GetComments()
        {
            List<string> list = new List<string>(File.ReadAllLines(@".\..\..\..\..\..\Project\AlgorithmSln\AutoGenerator\comments.txt"));
            list.Remove("");
            return list.ToArray();
        }

        private static Dictionary<string, string> GetExample()
        {
            List<string> list = new List<string>(File.ReadAllLines(@".\..\..\..\..\..\Project\AlgorithmSln\AutoGenerator\comments.txt"));
            return new Dictionary<string, string>();
        }

        internal void Generate(CodeType type = CodeType.Easy)
        {
            if (string.IsNullOrEmpty(_className) || string.IsNullOrEmpty(_funcName) || string.IsNullOrEmpty(_outfolder))
            {
                throw new Exception("parameter missing");
            }
            AddUsing(type);
            AddNamespace(type);
            File.WriteAllLines(_outfolder, _codeWriter);
        }

        internal static void AddUsing(CodeType type)
        {
            _codeWriter.Add($"using Algorithm.{type};");
            _codeWriter.Add("using Common;");
            _codeWriter.Add("using NUnit.Framework;");
            _codeWriter.Add("using System;");
            _codeWriter.Add("using System.Collections.Generic;");
            _codeWriter.Add("using System.Text;");
            _codeWriter.Add("");
        }

        internal static void AddNamespace(CodeType type)
        {
            _codeWriter.Add($"namespace AlorithmTests.{type}");
            _codeWriter.Add("{");
            AddBody(type);
            _codeWriter.Add("}");
            _codeWriter.Add("");
        }

        internal static void AddBody(CodeType type)
        {
            _codeWriter.Add($"    public class {_className}Tests");
            _codeWriter.Add("    {");
            _codeWriter.Add($"        private {_className} _member;");
            _codeWriter.Add("");
            _codeWriter.Add("        [SetUp]");
            _codeWriter.Add("        public void SetUp()");
            _codeWriter.Add("        {");
            _codeWriter.Add($"            _member = new {_className}();");
            _codeWriter.Add("        }");
            _codeWriter.Add("");
            _codeWriter.Add("        /// <summary>");
            AddComments();
            _codeWriter.Add("        /// <summary>");
            _codeWriter.Add("        [Test]");
            _codeWriter.Add($"        public void {_funcName}()");
            _codeWriter.Add("        {");
            //AddInitialization();
            _codeWriter.Add("        }");
            _codeWriter.Add("    }");
        }

        internal static void AddComments()
        {
            if (_comments is null || _comments.Length == 0)
            {
                return;
            }

            foreach (var item in _comments)
            {
                _codeWriter.Add($"        /// {item}");
            }
        }

        internal static void AddExample()
        {
        }
    }
}
