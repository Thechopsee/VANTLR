using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VANTLR.Struktury;
using Type = VANTLR.Struktury.Type;

namespace VANTLR
{
    class MainListener : GramatikaBaseListener
    {
        private SymbolTable symbolTable;

        public MainListener()
        {
            this.symbolTable = new SymbolTable();
        }

        public ParseTreeProperty<Type> Types { get; } = new ParseTreeProperty<Type>();

        private void SetNodeType(IParseTree node, Type value)
        {
            Types.Put(node, value);
        }

        private Type GetNodeType(IParseTree node)
        {
            return Types.Get(node);
        }

        public override void ExitDeclaration([System.Diagnostics.CodeAnalysis.NotNull] GramatikaParser.DeclarationContext context)
        {
            foreach (var expr in context.IDENTIFIER())
            {
                if (context.DATA_TYPE().GetText() == "int")
                {
                    SetNodeType(expr, Type.Int);
                }
                else if (context.DATA_TYPE().GetText() == "float")
                {
                    SetNodeType(expr, Type.Float);
                }
                else if (context.DATA_TYPE().GetText() == "string")
                {
                    SetNodeType(expr, Type.String);
                }
                else if (context.DATA_TYPE().GetText() == "bool")
                {
                    SetNodeType(expr, Type.Bool);
                }
                else if (context.DATA_TYPE().GetText() == "Error")
                {
                    SetNodeType(expr, Type.Error);
                }
                symbolTable.Add(expr.Symbol, GetNodeType(expr));
            }
        }
        public override void ExitAddition([System.Diagnostics.CodeAnalysis.NotNull] GramatikaParser.AdditionContext context)
        {
            string error = String.Empty;
            if (context.op.Text == ".")
            {
                foreach (var item in context.expr())
                {
                    var text = item.GetText();
                    if (!(text[0] == '"' && text[text.Length - 1] == '"' && text.Count(f => f == '"') == 2))
                    {
                        error = $"Concat '.' only for string";
                    }
                }
            }
            if (context.op.Text == "+")
            {
                foreach (var item in context.expr())
                {
                    var text = item.GetText();
                    if ((text[0] == '"' && text[text.Length - 1] == '"' && text.Count(f => f == '"') == 2))
                    {
                        error = $" + wont work with strings";
                    }
                }
            }
            if (error != String.Empty)
            {
                Errors.ReportError(context.start, error);
            }
        }

        public override void ExitMultiplication([System.Diagnostics.CodeAnalysis.NotNull] GramatikaParser.MultiplicationContext context)
        {
            string error = String.Empty;

            if (context.op.Text == "%")
            {
                foreach (var item in context.expr())
                {
                    if (!int.TryParse(item.GetText(), out _))
                    {
                        error = $"MOD used with Float";
                    }
                }
            }
            if (error != String.Empty)
            {
                Errors.ReportError(context.start, error);
            }
        }
        public override void ExitAssignment([System.Diagnostics.CodeAnalysis.NotNull] GramatikaParser.AssignmentContext context)
        {
            string error = string.Empty;


            var type = symbolTable[context.start];
            if (type != Type.Error)
            {
                var text = context.expr().GetText();

                if (type == Type.Float && !float.TryParse(text.Replace('.', ','), out _))
                {
                    error = $"assignment of {context.expr().GetText()} into Float";
                }
                if (type == Type.Int && !int.TryParse(text, out _))
                {
                    if (!text.Contains("+") && !text.Contains("="))
                    {
                        error = $"assignment of {context.expr().GetText()} into Int";
                    }
                 
            
                }
                if (type == Type.String && !(text[0] == '"' && text[text.Length - 1] == '"' && text.Count(f => f == '"') == 2))
                {
                    error = $"assignment of {context.expr().GetText()} into String";
                }
                if (type == Type.Bool && !bool.TryParse(text, out _))
                {
                    error = $"assignment of {context.expr().GetText()} into Bool";
                }

            }




            if (error != String.Empty)
            {
                Errors.ReportError(context.start, error);
            }
        }
    }
}
