using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VANTLR
{
    public class Visitor: GramatikaBaseVisitor<string>
    {

        public Dictionary<string, string> memory = new Dictionary<string, string>();
        int g_counter = -1;
        int label_counter=0;
        bool pending_if = false;
        bool pending_while = false;
        //LabelNamer labelNamer = new LabelNamer();
        public override string VisitProgram([NotNull] GramatikaParser.ProgramContext context)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var expr in context.command())
            {
                g_counter = -1;
                var code = Visit(expr);

                sb.Append(code);

            }
            return sb.ToString();
        }
        public override string VisitString([NotNull] GramatikaParser.StringContext context)
        {
            var value = context.STRING().GetText();
            return "push S " + value + "\n";
        }
        public override string VisitFloat([NotNull] GramatikaParser.FloatContext context)
        {

            var value = float.Parse(context.FLOAT().GetText(), CultureInfo.InvariantCulture.NumberFormat);
            return "push F " + value + "\n";
        }
        public override string VisitBoolean([NotNull] GramatikaParser.BooleanContext context)
        {
            var value = Boolean.Parse(context.BOOLEAN().GetText());
            return "push B " + value + "\n";
        }
        public override string VisitInteger([NotNull] GramatikaParser.IntegerContext context)
        {
            var value = Convert.ToInt32(context.INTEGER().GetText());
            return "push I " + value + "\n";
        }
        public override string VisitAddition([NotNull] GramatikaParser.AdditionContext context)
        {
            var left = Visit(context.expr()[0]);
            var right = Visit(context.expr()[1]);
            if (context.op.Text.Equals("+"))
            {
                return left + right + "add\n";
            }
            else if (context.op.Text.Equals("-"))
            {
                return left + right + "sub\n";
            }
            else
            {
                return left + right + "concat\n";
            }
        }
        public override string VisitMultiplication([NotNull] GramatikaParser.MultiplicationContext context)
        {
            var left = Visit(context.expr()[0]);
            var right = Visit(context.expr()[1]);
            if (context.op.Text.Equals("*"))
            {
                return left + right + "mul\n";
            }
            else if (context.op.Text.Equals("/"))
            {
                return left + right + "div\n";
            }
            else
            {
                return left + right + "mod\n";
            }
        }


        public override string VisitWrite([NotNull] GramatikaParser.WriteContext context)
        {
            string text = "";
            int counter = 0;
            foreach (var x in context.expr())
            {
                text += Visit(x);
                counter++;
            }
            g_counter = counter;
            return text + "print " + counter + "\n";
        }


        public override string VisitDeclaration([NotNull] GramatikaParser.DeclarationContext context)
        {
            string vystupy = "";

            if (context.children[0].ToString().Equals("int"))
            {
                vystupy += "push I 0\n";
            }
            else if (context.children[0].ToString().Equals("float"))
            {
                vystupy += "push F 0.0\n";
            }
            else if (context.children[0].ToString().Equals("bool"))
            {
                vystupy += "push B false\n";
            }
            else
            {
                vystupy += @"push S """"\n";
            }
            for (int i = 1; i < context.children.Count; i += 2)
            {

                vystupy += "save " + context.children[i].GetText() + "\n";
            }

            return vystupy;
        }
        public override string VisitAssignment([NotNull] GramatikaParser.AssignmentContext context)
        {
            return VisitChildren(context) + "save " + context.IDENTIFIER().GetText() + "\n";
        }
        public override string VisitExpression([NotNull] GramatikaParser.ExpressionContext context)
        {
            string cont = Visit(context.expr());
            return cont;


        }

        public override string VisitIdentifier([NotNull] GramatikaParser.IdentifierContext context)
        {
            return "load " + context.IDENTIFIER().GetText() + "\n";
        }
        public override string VisitRead([NotNull] GramatikaParser.ReadContext context)
        {
            foreach(var id in context.IDENTIFIER())
            {
                
            }
            return "read " + context.IDENTIFIER().GetValue(0) + "\n";
        }
        public override string VisitOr([NotNull] GramatikaParser.OrContext context)
        {
            var left = Visit(context.expr()[0]);
            var right = Visit(context.expr()[1]);
            return left + right + "or\n";
        }
        public override string VisitAnd([NotNull] GramatikaParser.AndContext context)
        {
            var left = Visit(context.expr()[0]);
            var right = Visit(context.expr()[1]);
            return left + right + "and\n";
        }
        public override string VisitNegation([NotNull] GramatikaParser.NegationContext context)
        {
            var left = Visit(context.expr());
            return left + "not\n";
        }
        public override string VisitRelation([NotNull] GramatikaParser.RelationContext context)
        {
            var left = Visit(context.expr()[0]);
            var right = Visit(context.expr()[1]);
            if (context.op.Text.Equals(">"))
            {

                return left + right + "gt\n";
            }
            else
            {

                return left + right + "lt\n";
            }
        }
        public override string VisitEquality([NotNull] GramatikaParser.EqualityContext context)
        {

            var left = Visit(context.expr()[0]);
            var right = Visit(context.expr()[1]);
            return left + right + "eq\n";

        }
        public override string VisitIf([NotNull] GramatikaParser.IfContext context)
        {
            if (context.ELSE() == null)
            {
                this.pending_if = true;
            }

            string podminka = "";
            podminka += Visit(context.children[0]);
            string iff = "";
            label_counter++;
            label_counter++;
            iff += Visit(context.children[4]);
            string eelse = "";

            if (context.ELSE() != null)
            {
                eelse = Visit(context.children[6]);


                return Visit(context.expr()) + $"fjmp {label_counter-1}\n" + podminka + iff + $"jmp {label_counter}\n" + $"label {label_counter-1}\n"+ eelse + $"label {label_counter}\n";
            }
            else
            {

                return Visit(context.expr()) + $"fjmp {label_counter-1}\n" + podminka + iff;
            }

        }

        public override string VisitCode_block([NotNull] GramatikaParser.Code_blockContext context)
        {
            string abc = "";
            foreach (var x in context.children)
            {
                abc += Visit(x);
            }
            if (pending_if)
            {
                pending_if = false;
                
                return abc + $"label {label_counter-1}\n";
            }
            if (pending_while)
            {
                pending_while = false;
                return abc + $"jmp {label_counter-1}\n" + $"label {label_counter }\n";
            }
            return abc;

        }
        public override string VisitWhile([NotNull] GramatikaParser.WhileContext context)
        {
            label_counter++;
            label_counter++;
            pending_while = true;
            return $"label {label_counter-1}\n" + Visit(context.expr()) + $"fjmp {label_counter}\n" + VisitChildren(context) + "\n";
        }
        public override string VisitCommand([NotNull] GramatikaParser.CommandContext context)
        {
            string value = "";
            foreach (var x in context.children)
            {
                value += Visit(x);
            }

            return value;

        }
    }
}
