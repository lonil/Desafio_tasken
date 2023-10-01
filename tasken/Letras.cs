using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasken
{
    class Letras
    {
        public void ConcatLetras()
        {
            string result = "";
            string line = "";
            int count = 0;
            char lastchar;

            Console.WriteLine("escreve uma serie de caracteres");
            line = Console.ReadLine();
            lastchar = line[0];
            foreach (char character in line)
            {
                if(character != lastchar)
                {
                    result += lastchar.ToString() + count;
                    lastchar = character;
                    count = 0;
                }
                count++;
            }
            result += lastchar.ToString() + count;
            Console.WriteLine(result);
        }
        public void DocRead()
        {
            int consoantes = 0;
            string hiConsoantes = ""; 
            int vogais = 0;
            string hiVogais = "";
            Console.WriteLine("Escreva o caminho do arquivo TXT para ser lido");
            string a =Console.ReadLine();
            while (!System.IO.File.Exists(a))
            {
                Console.WriteLine("caminho invalido deseja repetir? S/N");
                if(!(Console.ReadKey().KeyChar.ToString().ToUpper() == "S"))
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("Escreva o caminho do arquivo TXT para ser lido");
                a = Console.ReadLine();
            }

            var b = System.IO.File.ReadAllText(a).Split(new string[] { "\r\n" },StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in b)
            {
                if((consoantes += item.Count((x) => "bcdfghjklmnopqrstuvxyz".Contains(x))) > hiConsoantes.Count((x) => "bcdfghjklmnopqrstuvxyz".Contains(x)))
                {
                    hiConsoantes = item;
                }
                if((vogais += item.Count((x) => "aeiou".Contains(x)))> hiVogais.Count((x) => "aeiou".Contains(x)))
                {
                    hiVogais = item;
                }
            }
            Console.WriteLine($@"Foram digitadas 
{vogais} vogais
{consoantes} consoantes

a linha que possui mais vogais
{hiVogais}

A linha que possui mais consoantes
{hiConsoantes}");

        }
    }
}	

