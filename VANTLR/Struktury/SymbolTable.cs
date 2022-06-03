﻿using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VANTLR.Struktury
{
    public enum Type
    {
        Int, Float, Error, String, Bool
    }
    class SymbolTable
    {
        Dictionary<string, Type> memory = new Dictionary<string, Type>();

        public void Add(IToken variable, Type type)
        {
            var name = variable.Text.Trim();
            if (memory.ContainsKey(name))
            {
                Errors.ReportError(variable, $"Variable {name} was already declared.");
            }
            else
            {
                memory.Add(name, type);
            }
        }
        public Type this[IToken variable]
        {
            get
            {
                var name = variable.Text.Trim();
                if (memory.ContainsKey(name))
                {
                    return memory[name];
                }
                else
                {
                    Errors.ReportError(variable, "missing declaration");
                    return Type.Error;
                }
            }
            set
            {
                var name = variable.Text.Trim();
                memory[name] = value;
            }
        }
    }
}
