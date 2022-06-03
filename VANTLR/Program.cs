using System;
using System.IO;

namespace VANTLR
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\ValMe\Desktop\VANTLR\VANTLR\i1.txt";
            string vystuppath = @"C:\Users\ValMe\Desktop\VANTLR\VANTLR\vystup.txt";
            Prevadec pr = new Prevadec();
            string prelozene=pr.getVystupPro(filepath);
            string[] lines = prelozene.Split("\n");
            File.WriteAllLines(vystuppath, lines);

            Interpreter inter = new Interpreter();
            inter.interpretFile(vystuppath);
            
        }
    }
}
