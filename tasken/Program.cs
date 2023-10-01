using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasken
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new tasken.Numbers();
            Letras letras = new tasken.Letras();
            bool b = false;
            int n;
            do
            {
                Console.WriteLine(@"Digite: 
1 para a Função relacionadas a numeros 
2 para função relacionada a Letras
3 para Contador de numeros digitados
4 para contador de vogais e consoantes");
            
                char a = Console.ReadKey().KeyChar;

                Console.Clear();
                int.TryParse(a.ToString(), out n);
                switch (n)
                {
                    case 1:
                        numbers.NumberCalc();
                        b= Retry();
                        break;
                    case 2:
                        letras.ConcatLetras();
                        b = Retry();
                        break;
                    case 3:
                        numbers.NumberCap();
                        b = Retry();
                        break;
                    case 4:
                        letras.DocRead();
                        b = Retry();
                        break;
                    default:
                        b = true;
                        Console.WriteLine("favor digitar numero valido");
                        break;
                }
            }
            while(b);
        }

        static bool Retry()
        {
            bool b;
            Console.WriteLine();
            Console.WriteLine("deseja continuar? S/N");
            var a = Console.ReadKey();
            Console.Clear();
            b = a.KeyChar == 's' || a.KeyChar == 'S';
            return b;
        }
    }
}
