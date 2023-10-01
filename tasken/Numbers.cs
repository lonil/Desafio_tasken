using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasken
{
    public class Numbers
    {
        string input;
        int n;
        bool valid;
        Dictionary<int, int> listNumber;
        public void NumberCalc()
        {
            Console.WriteLine("Digite um valor inteiro positivo");
            do 
            {
                input = Console.ReadLine();

                if (valid = int.TryParse(input, out n) && n > -1)
                {
                    for (int i = n-1; i > -1; i--)
                    {
                        string line = "";
                        Console.WriteLine();
                        int x = 0;
                        for (int j = 0; j <= i; j++)
                        {
                            x = x + (j * 2) + 1;
                            line = x + " " + line;
                        }
                        Console.Write(line);
                    }
                }
                else
                {
                    Console.WriteLine("Por favor Digitar numero valido");
                } 
            }
            while (!valid);
        }
        public void NumberCap()
        {
            listNumber = new Dictionary<int, int>();
            int n;
            do
            {

                Console.WriteLine("Digite Numeros maiores que 0, a tarefa será finalizada após a capitação do primeiro 0");
                bool b = int.TryParse(Console.ReadLine(), out n);
                if (listNumber.ContainsKey(n))
                {
                    listNumber[n]++;
                }
                else
                {
                    if(n !=0)
                        listNumber.Add(n, 1);
                }
                Console.Clear();

            }
            while (n != 0);
            
            Console.WriteLine("O maior numero foi " + listNumber.OrderByDescending(x => x.Key).ToList()[0].Key);
            int total = 0;
            int count = 0;
            var a = listNumber.OrderBy(x => x.Key).Where(x => x.Key % 2 == 1).First().Key;
            Console.WriteLine("O menor número impar foi " + a);
            listNumber.ToList().ForEach(x => { total += x.Key * x.Value; count += x.Value; });
            Console.WriteLine("A media do valor total foi " + total/count);


            Console.WriteLine("A media dos numero digitados foi " + listNumber.Average(x => x.Key));
            foreach (KeyValuePair<int, int> x in listNumber)
            {
                Console.WriteLine("O número " + x.Key + " ocorreu " + x.Value + " vezes.");
            }
        }
    }
}
