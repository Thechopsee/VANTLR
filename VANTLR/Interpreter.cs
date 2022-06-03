using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VANTLR.Struktury;

namespace VANTLR
{
    class Interpreter
    {
        public Stack<Prvek> zasobnik;
        public List<Promena> promene;
        public Interpreter()
        {
            zasobnik = new Stack<Prvek>();
            promene = new List<Promena>();
        }

        public void interpretFile(string filepath)
        {
            StreamReader file = new StreamReader(filepath);
            string ln;

            while ((ln = file.ReadLine()) != null)
            {

                string[] splited = ln.Split(" ");
                if (splited[0] == "print")
                {
                    this.print(splited[1]);
                }
                else if (splited[0] == "push")
                {
                    string temp = "";
                    for (int i = 2; i < splited.Length; i++)
                    {
                        temp += splited[i];
                    }
                    char col = '"';
                    string news = temp.Replace($"{col}", string.Empty);
                    this.push(splited[1], news);
                }
                else if (splited[0] == "pop")
                {
                    this.pop();
                }
                else if (splited[0] == "save")
                {
                    this.save(splited[1]);
                }
                else if (splited[0] == "load")
                {
                    this.load(splited[1]);
                }
                else if (splited[0] == "uminus")
                {
                    this.uminus();
                }
                else if (splited[0] == "mul")
                {
                    this.mul();
                }
                else if (splited[0] == "add")
                {
                    this.add();
                }
                else if (splited[0] == "div")
                {
                    this.div();
                }
                else if (splited[0] == "mod")
                {
                    this.mod();
                }
                else if (splited[0] == "itof")
                {
                    this.itof();
                }
                else if (splited[0] == "concat")
                {
                    this.concat();
                }
                else if (splited[0] == "read")
                {
                    this.read(splited[1]);
                }
                else if (splited[0] == "lt")
                {
                    this.lt();
                }
                else if (splited[0] == "gt")
                {
                    this.gt();
                }
                else if (splited[0] == "eq")
                {
                    this.eq();
                }
                else if (splited[0] == "not")
                {
                    this.not();
                }
                else if (splited[0] == "and")
                {
                    this.and();
                }
                else if (splited[0] == "or")
                {
                    this.or();
                }
                else if (splited[0] == "jmp")
                {
                    while (true)
                    {
                        ln = file.ReadLine();
                        if (ln == null)
                        {
                            file = new StreamReader(filepath);
                            ln = file.ReadLine();
                        }
                        string[] spl = ln.Split(" ");
                        if (spl[0] == "label" && spl[1] == splited[1])
                        {
                            break;
                        }
                    }
                }
                else if (splited[0] == "fjmp")
                {
                    if (!this.fjmp())
                    {
                        while (true)
                        {
                            ln = file.ReadLine();
                            if (ln == null)
                            {
                                file = new StreamReader(@"C:\Users\sebas\source\repos\Interpreter\Interpreter\vstup.txt");
                                ln = file.ReadLine();
                            }
                            string[] spl = ln.Split(" ");
                            if (spl[0] == "label" && spl[1] == splited[1])
                            {
                                break;
                            }
                        }
                    }
                }

            }
        }
        public void push(string kde, string co)
        {
            zasobnik.Push(new Prvek(kde, co));
        }
        public void pop()
        {
            zasobnik.Pop();
        }
        public void print(string exp)
        {
            int kolik = Int32.Parse(exp);
            for (int i = kolik - 1; i > -1; i--)
            {

                Console.Write(zasobnik.ElementAt(i).ToString());
            }
            Console.Write("\n");

        }
        public void save(string id)
        {
            foreach (Promena x in promene)
            {
                if (string.Compare(x.Nazev, id) == 0)
                {
                    x.part = zasobnik.ElementAt(0);
                    return;
                }
            }
            promene.Add(new Promena(id, zasobnik.ElementAt(0)));
        }
        public void load(string id)
        {
            foreach (Promena x in promene)
            {
                if (string.Compare(x.Nazev, id) == 0)
                {
                    push(x.part.datovy_typ, x.part.hodnota);
                    return;
                }
            }
        }
        public void uminus()
        {
            zasobnik.ElementAt(0).hodnota = "-" + zasobnik.ElementAt(0).hodnota;
        }
        public void mul()
        {
            Prvek top = zasobnik.ElementAt(0);
            Prvek bottom = zasobnik.ElementAt(1);
            zasobnik.Pop();
            zasobnik.Pop();
            double ttop = double.Parse(top.hodnota, System.Globalization.CultureInfo.InvariantCulture);
            double bbottom = double.Parse(bottom.hodnota, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("" + ttop + "×" + bbottom + "=" + (ttop * bbottom));
            push(top.datovy_typ, "" + (ttop * bbottom).ToString().Replace(',', '.'));
        }
        public void add()
        {
            Prvek top = zasobnik.ElementAt(0);
            Prvek bottom = zasobnik.ElementAt(1);
            zasobnik.Pop();
            zasobnik.Pop();
            double ttop = double.Parse(top.hodnota, System.Globalization.CultureInfo.InvariantCulture);
            double bbottom = double.Parse(bottom.hodnota, System.Globalization.CultureInfo.InvariantCulture);
            push(top.datovy_typ, "" + (ttop + bbottom).ToString().Replace(',', '.'));
        }
        public void div()
        {
            Prvek top = zasobnik.ElementAt(0);
            Prvek bottom = zasobnik.ElementAt(1);
            zasobnik.Pop();
            zasobnik.Pop();
            double ttop = double.Parse(top.hodnota, System.Globalization.CultureInfo.InvariantCulture);
            double bbottom = double.Parse(bottom.hodnota, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("" + ttop + " / " + bbottom + "=" + (ttop / bbottom));
            push(top.datovy_typ, "" + (bbottom / ttop).ToString().Replace(',', '.'));
        }
        public void mod()
        {
            Prvek top = zasobnik.ElementAt(0);
            Prvek bottom = zasobnik.ElementAt(1);
            zasobnik.Pop();
            zasobnik.Pop();
            double ttop = double.Parse(top.hodnota, System.Globalization.CultureInfo.InvariantCulture);
            double bbottom = double.Parse(bottom.hodnota, System.Globalization.CultureInfo.InvariantCulture);
            push(top.datovy_typ, "" + bbottom % ttop);
        }
        public void itof()
        {
            zasobnik.ElementAt(0).datovy_typ = "F";
            zasobnik.ElementAt(0).hodnota += ".0";

        }
        public void concat()
        {
            Prvek top = zasobnik.ElementAt(0);
            Prvek bottom = zasobnik.ElementAt(1);
            zasobnik.Pop();
            zasobnik.Pop();
            push(top.datovy_typ, "" + bottom.hodnota + top.hodnota);
        }
        public void read(string id)
        {
            Console.WriteLine("Insert " + id + ": ");
            string dt="";
            foreach (Promena x in promene)
            {
                if (string.Compare(x.Nazev, id) == 0)
                {
                    dt=x.part.datovy_typ;
                    //Console.WriteLine(dt);
                    //return;
                }
            }
            var name = Console.ReadLine();
            if (dt.Equals("F"))
            {
                float vysl;
                if (float.TryParse(name, out vysl))
                {
                    push(dt, "" + vysl);
                    save(id);
                }
                else
                {
                    Console.WriteLine("Wrong input,try again");
                    read(id);
                    return;
                }
            }
            else if (dt.Equals("I"))
            {
                int vysl;
                if (Int32.TryParse(name, out vysl))
                {
                    push(dt, "" + vysl);
                    save(id);
                }
                else
                {
                    Console.WriteLine("Wrong input,try again");
                    read(id);
                    return;
                }
            }
            else if (dt.Equals("B"))
            {
                bool vysl;
                if (bool.TryParse(name, out vysl))
                {
                    push(id, "" + vysl);
                    save(id);
                }
                else
                {
                    Console.WriteLine("Wrong input,try again");
                    read(id);
                    return;
                }
            }
            else if (dt.Equals("S"))
            {
                push(id, "" + name);
                save(id);
            }


        }
        public void and()
        {
            Prvek top = zasobnik.ElementAt(0);
            Prvek bottom = zasobnik.ElementAt(1);
            zasobnik.Pop();
            zasobnik.Pop();
            push(top.datovy_typ, "" + (bool.Parse(bottom.hodnota) && bool.Parse(top.hodnota)).ToString());
        }
        public void or()
        {
            Prvek top = zasobnik.ElementAt(0);
            Prvek bottom = zasobnik.ElementAt(1);
            zasobnik.Pop();
            zasobnik.Pop();
            // Console.WriteLine(bottom.hodnota + " " + top.hodnota);
            push(top.datovy_typ, "" + (bool.Parse(bottom.hodnota) || bool.Parse(top.hodnota)).ToString());
        }
        public void not()
        {
            Prvek top = zasobnik.ElementAt(0);
            zasobnik.Pop();
            push(top.datovy_typ, "" + (!bool.Parse(top.hodnota)).ToString());
        }
        public void gt()
        {
            Prvek top = zasobnik.ElementAt(0);
            Prvek bottom = zasobnik.ElementAt(1);
            zasobnik.Pop();
            zasobnik.Pop();
            if (top.datovy_typ == "S")
            {
                int i = string.Compare(top.hodnota, bottom.hodnota);
                push("B", "" + (Convert.ToBoolean(i)).ToString());
            }
            else
            {
                double ttop = double.Parse(top.hodnota, System.Globalization.CultureInfo.InvariantCulture);
                double bbottom = double.Parse(bottom.hodnota, System.Globalization.CultureInfo.InvariantCulture);

                push("B", "" + (bbottom > ttop).ToString());
            }
        }
        public void lt()
        {
            Prvek top = zasobnik.ElementAt(0);
            Prvek bottom = zasobnik.ElementAt(1);
            zasobnik.Pop();
            zasobnik.Pop();
            if (top.datovy_typ == "S")
            {
                int i = string.Compare(top.hodnota, bottom.hodnota);
                push("B", "" + (!Convert.ToBoolean(i)).ToString());
            }
            else
            {
               
               
                double ttop = double.Parse(top.hodnota, System.Globalization.CultureInfo.InvariantCulture);
                double bbottom = double.Parse(bottom.hodnota, System.Globalization.CultureInfo.InvariantCulture);

                push("B", "" + (bbottom < ttop).ToString());
            }
        }
        public void eq()
        {
            Prvek top = zasobnik.ElementAt(0);
            Prvek bottom = zasobnik.ElementAt(1);
            zasobnik.Pop();
            zasobnik.Pop();
            if (top.datovy_typ== "S")
            {
                int i = string.Compare(top.hodnota, bottom.hodnota);
                push("B", "" + (!Convert.ToBoolean(i)).ToString());
            }
            else
            {
                double ttop = double.Parse(top.hodnota, System.Globalization.CultureInfo.InvariantCulture);
                double bbottom = double.Parse(bottom.hodnota, System.Globalization.CultureInfo.InvariantCulture);
                
                push("B", "" + (bbottom == ttop).ToString());
            }
        }
        public bool fjmp()
        {
            Prvek top = zasobnik.ElementAt(0);
            return bool.Parse(top.hodnota);
        }


    }
}
