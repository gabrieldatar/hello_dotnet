using System;

namespace _2_instrucoes
{
    class Program
    {
        static void Declaracoes()
        {
            int a;
            int b=2, c=3;
            const int d=4;
            a=1;
            Console.WriteLine("Soma: "+a+b+c+d);
        }

        static void InstrucaoIf(string[]args){
            if(args.Length==0){
                Console.WriteLine("Nenhum argumento");
            }
            else if(args.Length==1){
                Console.WriteLine($"{args.Length} argumentos");
            }
        }

        static void IntrucaoSwitch(string[]args)
        {
            int numeroArgumentos=args.Length;

            switch(numeroArgumentos)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                default:
                    Console.WriteLine($"{numeroArgumentos} argumentos");
                    break;
            }
        }

        static void InstrucaoWhile(string[]args)
        {
            int i=0;

            while(i<args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }

        static void InstrucaoDo(string[]args)
        {
            string texto;

            do
            {
                texto=Console.ReadLine();
                Console.WriteLine(texto);
            }while(!string.IsNullOrEmpty(texto));
        }

        static void IntrucaoFor(string[]args)
        {
            for(int i=0;i<args.Length;i++)
            {
                Console.WriteLine(args[i]);
            }
        }

        static void IntrucaoForeach(string[]args)
        {
            foreach(string s in args)
            {
                Console.WriteLine(s);
            }
        }

        static void IntrucaoBreak(string[]args)
        {
            while(true)
            {
                string s=Console.ReadLine();

                if(string.IsNullOrEmpty(s)) break;

                Console.WriteLine(s);
            }
        }

        static void IntrucaoContinue(string[]args)
        {
            for(int i=0;i<args.Length;i++)
            {
                if(args[i].StartsWith("/")) continue;

                Console.WriteLine(args[i]);
            }
        }

        static void IntrucaoReturn(string[]args)
        {
            int Somar(int a, int b)
            {
                return a+b;
            }

            Console.WriteLine(Somar(1,2));
            Console.WriteLine(Somar(3,4));
            Console.WriteLine(Somar(5,6));

            return;
        }

        static void IntrucaoTryCatchFinallyThrow(string[]args)
        {
            double Dividir(double x,double y)
            {
                if(y==0) throw new DivideByZeroException();

                return x/y;
            }

            try
            {
                if(args.Length!=2) throw new InvalidCastException("Informa 2 número");

                double x=double.Parse(args[0]);
                double y=double.Parse(args[1]);

                Console.WriteLine(Dividir(x,y));

            }
            catch(InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine($"Erro genérico: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Ate breve!");
            }
        }

        static void IntrucaoUsing(string[]args)
        {
            using (System.IO.TextWriter w=System.IO.File.CreateText("text.txt"))
            {
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
