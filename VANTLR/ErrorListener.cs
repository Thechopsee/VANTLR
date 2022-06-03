using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VANTLR
{
    class ErrorListener : BaseErrorListener
    {
        public override void SyntaxError([System.Diagnostics.CodeAnalysis.NotNull] IRecognizer recognizer, [Nullable] IToken offendingSymbol, int line, int charPositionInLine, [System.Diagnostics.CodeAnalysis.NotNull] string msg, [Nullable] RecognitionException e)
        {

            IList<string> stack = ((Parser)recognizer).GetRuleInvocationStack();
            stack.Reverse();

            Console.Error.WriteLine("stack: " + String.Join(", ", stack));
            Console.Error.WriteLine("radek " + line + ":" + charPositionInLine + " at " + offendingSymbol + ": " + msg);
        }
    }
}
