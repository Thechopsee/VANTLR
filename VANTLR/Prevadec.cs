using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VANTLR.Struktury;

namespace VANTLR
{
    class Prevadec
    {
        private string vystup = "error";
        public void start(string filepath)
        {
            var inputFile = new StreamReader(filepath);
            AntlrInputStream input = new AntlrInputStream(inputFile);
            GramatikaLexer lexer = new GramatikaLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            GramatikaParser parser = new GramatikaParser(tokens);
            parser.AddErrorListener(new ErrorListener());
            IParseTree tree = parser.program();
            if (parser.NumberOfSyntaxErrors != 0)
            {
                return;
            }
            ParseTreeWalker walker = new ParseTreeWalker();
            MainListener l = new MainListener();
            walker.Walk(l, tree);
            if (Errors.NumberOfErrors > 0)
            {
                Errors.PrintAndClearErrors();
                return;
            }

            Visitor visitore = new Visitor();
            String vystup = visitore.Visit(tree);
            this.vystup = vystup;
        }
        public string getVystupPro(string filepath)
        {
            start(filepath);
            return vystup;
        }
    }
}
