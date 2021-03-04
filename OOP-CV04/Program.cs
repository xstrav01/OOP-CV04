using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CV04
{
    class Program
    {
        static void Main(string[] args)
        {
            string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
            + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
            + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
            + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
            + "posledni veta!";

            StringStatistics st = new StringStatistics(testovaciText);
            string[] subs = testovaciText.Split(' ');
            Console.WriteLine("{0}", string.Join(" ", subs));

            Console.WriteLine("\nPocet slov: " + st.wordCount());
            Console.WriteLine("Pocet radku: " + st.lineCount());
            Console.WriteLine("Pocet vet: " + st.sentenceCount());
            Console.Write("Nejdelsi slova: ");
            Console.WriteLine("{0}", string.Join(" , ", st.longestWords()));
            Console.Write("Nejkratsi slova: ");
            Console.WriteLine("{0}", string.Join(" , ", st.shortestWords()));
            Console.Write("Nejcetnejsi slova: ");
            Console.WriteLine("{0}", string.Join(" , ", st.mostFrequentElement()));
            Console.Write("Slova dle abecedy: ");
            Console.WriteLine("{0}", string.Join(" , ", st.sortAlfabeticaly()));
            Console.ReadLine();

        }
    }
}
